using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Data;
using ServiceMarketplace.Repository;

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

        builder.Services.AddScoped<IServiceMarketplaceRepository, ServiceMarketplaceRepository>();

        builder.Services.AddControllersWithViews();
    }

    public static void ConfigureMiddleware(WebApplication app)
    {
       
        if (!app.Environment.IsDevelopment())
        {
            
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html");
    }
}
