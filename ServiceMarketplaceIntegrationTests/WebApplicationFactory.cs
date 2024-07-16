using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceMarketplace.Data;
using ServiceMarketplace.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceMarketplace.Tests
{

    public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));

                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                });


                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<ApplicationDbContext>();

                    db.Database.EnsureCreated();

                    ClearDatabase(db);
                }
            });
        }

        public void ClearDatabase(ApplicationDbContext dbContext)
        {
            dbContext.WeatherForecasts.RemoveRange(dbContext.WeatherForecasts);
            dbContext.Bookings.RemoveRange(dbContext.Bookings);
            dbContext.Businesses.RemoveRange(dbContext.Businesses);
            dbContext.BusinessUsers.RemoveRange(dbContext.BusinessUsers);
            dbContext.CustomerUsers.RemoveRange(dbContext.CustomerUsers);
            dbContext.Inquiries.RemoveRange(dbContext.Inquiries);
            dbContext.Reviews.RemoveRange(dbContext.Reviews);
            dbContext.Services.RemoveRange(dbContext.Services);
            dbContext.ServiceAvailability.RemoveRange(dbContext.ServiceAvailability);
            dbContext.SaveChanges();
        }

    }

}