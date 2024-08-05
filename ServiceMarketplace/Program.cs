using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Data;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

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

        app.MapGet("/pingauth", async (UserManager<User> userManager, ClaimsPrincipal user) =>
        {
            var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                var appUser = await userManager.FindByIdAsync(userId);
                if (appUser != null)
                {
                    var firstName = appUser.FirstName;
                    var lastName = appUser.LastName;
                    var email = appUser.Email;
                    var address = appUser.Address;
                    var city = appUser.City;
                    var state = appUser.State;
                    var zipCode = appUser.ZipCode;
                    var accountType = appUser.AccountType;
                    var phoneNumber = appUser.PhoneNumber;
                    return Results.Json(new { id = userId, firstName, lastName, email, address, city, state, zipCode, accountType, phoneNumber });
                }
            }
            return Results.Unauthorized();
        }).RequireAuthorization();

        app.MapPost("/registeruser", async ([FromBody] RegisterUser model, UserManager<User> userManager, SignInManager<User> signInManager) =>
        {
            if (model == null)
            {
                return Results.BadRequest("Invalid user data.");
            }

            var user = new User
            {
                AccountType = model.AccountType,
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
                PhoneNumber = model.PhoneNumber
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return Results.Ok("User registered successfully.");
            }

            var errors = string.Join("; ", result.Errors.Select(e => e.Description));
            return Results.BadRequest(errors);
        });

        //Block default register api
        app.Use(async (context, next) =>
        {
            if (context.Request.Path == "/register" && context.Request.Method == "POST")
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await context.Response.WriteAsync("Not Accessible, please use /registeruser");
            }
            else
            {
                await next();
            }
        });

        app.UseRouting();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html");
    }
}
