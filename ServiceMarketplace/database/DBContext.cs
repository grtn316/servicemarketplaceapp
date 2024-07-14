using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Entities;

namespace ServiceMarketplace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        //public DbSet<AccountType> AccountTypes { get; set; }
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        //public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<BusinessUser> BusinessUsers { get; set; }
        public DbSet<CustomerUser> CustomerUsers { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceAvailability> ServiceAvailability { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Business>()
                .OwnsOne(b => b.Address);

            modelBuilder.Entity<Business>()
                .OwnsOne(b => b.PhoneNumber);


            modelBuilder.Entity<WeatherForecast>().HasData(
                new WeatherForecast
                {
                    Id = 1,
                    Date = new DateOnly(2023, 6, 1),
                    TemperatureC = -5,
                    Summary = "Freezing"
                },
                new WeatherForecast
                {
                    Id = 2,
                    Date = new DateOnly(2023, 6, 2),
                    TemperatureC = 0,
                    Summary = "Bracing"
                },
                new WeatherForecast
                {
                    Id = 3,
                    Date = new DateOnly(2023, 6, 3),
                    TemperatureC = 5,
                    Summary = "Chilly"
                },
                new WeatherForecast
                {
                    Id = 4,
                    Date = new DateOnly(2023, 6, 4),
                    TemperatureC = 10,
                    Summary = "Cool"
                },
                new WeatherForecast
                {
                    Id = 5,
                    Date = new DateOnly(2023, 6, 5),
                    TemperatureC = 15,
                    Summary = "Mild"
                },
                new WeatherForecast
                {
                    Id = 6,
                    Date = new DateOnly(2023, 6, 6),
                    TemperatureC = 20,
                    Summary = "Warm"
                },
                new WeatherForecast
                {
                    Id = 7,
                    Date = new DateOnly(2023, 6, 7),
                    TemperatureC = 25,
                    Summary = "Balmy"
                },
                new WeatherForecast
                {
                    Id = 8,
                    Date = new DateOnly(2023, 6, 8),
                    TemperatureC = 30,
                    Summary = "Hot"
                },
                new WeatherForecast
                {
                    Id = 9,
                    Date = new DateOnly(2023, 6, 9),
                    TemperatureC = 35,
                    Summary = "Sweltering"
                },
                new WeatherForecast
                {
                    Id = 10,
                    Date = new DateOnly(2023, 6, 10),
                    TemperatureC = 40,
                    Summary = "Scorching"
                }
            );
        }
    }
}
