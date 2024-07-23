using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Data;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;
using System.Security.Claims;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        ConfigureServices(builder);

        var app = builder.Build();

        ConfigureMiddleware(app);

        app.MigrateDatabase(); 

        app.Run();
    }

    public static void ConfigureServices(WebApplicationBuilder builder)
    {
        
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

        builder.Services.AddAuthorization();
        builder.Services.AddIdentityApiEndpoints<User>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<IServiceMarketplaceRepository, ServiceMarketplaceRepository>();

        builder.Services.AddControllersWithViews();
    }

    public static void ConfigureMiddleware(WebApplication app)
    {
       
        if (!app.Environment.IsDevelopment())
        {
            
            app.UseHsts();
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.MapIdentityApi<User>();

        app.MapPost("/logout", async (SignInManager<User> signInManager) =>
        {

            await signInManager.SignOutAsync();
            return Results.Ok();

        }).RequireAuthorization();

        app.MapGet("/pingauth", (ClaimsPrincipal user) =>
            {
                var email = user.FindFirstValue(ClaimTypes.Email);
                return Results.Json(new { Email = email });

        }).RequireAuthorization();

        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html");
    }
}
