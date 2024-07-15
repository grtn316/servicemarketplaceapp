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

            modelBuilder.Entity<Business>(entity =>
            {
                entity.OwnsOne(b => b.Address);
            });


            //Dummy data for Customers
            modelBuilder.Entity<CustomerUser>().HasData(
                new CustomerUser { Id = 1, AccountType = AccountType.Standard, Username = "customer1", Password = "password1", Email = "customer1@yahoo.com", FirstName = "Customer", LastName = "One", PhoneNumber = "5555555555" },
                new CustomerUser { Id = 2, AccountType = AccountType.Standard, Username = "customer2", Password = "password2", Email = "customer2@yahoo.com", FirstName = "Customer", LastName = "Two", PhoneNumber = "5555555555" },
                new CustomerUser { Id = 3, AccountType = AccountType.Standard, Username = "customer3", Password = "password3", Email = "customer3@yahoo.com", FirstName = "Customer", LastName = "Three", PhoneNumber = "5555555555" },
                new CustomerUser { Id = 4, AccountType = AccountType.Standard, Username = "customer4", Password = "password4", Email = "customer4@yahoo.com", FirstName = "Customer", LastName = "Four", PhoneNumber = "5555555555" },
                new CustomerUser { Id = 5, AccountType = AccountType.Standard, Username = "customer5", Password = "password5", Email = "customer5@yahoo.com", FirstName = "Customer", LastName = "Five", PhoneNumber = "5555555555" }
            );

            //Dummy data for Businesses
            modelBuilder.Entity<Business>().HasData(
                new Business { Id = 1, Name = $"Business 1", Description = $"Description for Business 1", PhoneNumber = "5555555551" },
                new Business { Id = 2, Name = $"Business 2", Description = $"Description for Business 2", PhoneNumber = "5555555552" },
                new Business { Id = 3, Name = $"Business 3", Description = $"Description for Business 3", PhoneNumber = "5555555553" },
                new Business { Id = 4, Name = $"Business 4", Description = $"Description for Business 4", PhoneNumber = "5555555554" },
                new Business { Id = 5, Name = $"Business 5", Description = $"Description for Business 5", PhoneNumber = "5555555555" }
            );

            //Dummy data for Businesses Addresses
            modelBuilder.Entity<Business>().OwnsOne(b => b.Address).HasData(
                new { BusinessId = 1, Street = "Street 1", City = "City 1", State = "State 1", Zipcode = "Zip1" },
                new { BusinessId = 2, Street = "Street 2", City = "City 2", State = "State 2", Zipcode = "Zip2" },
                new { BusinessId = 3, Street = "Street 3", City = "City 3", State = "State 3", Zipcode = "Zip3" },
                new { BusinessId = 4, Street = "Street 4", City = "City 4", State = "State 4", Zipcode = "Zip4" },
                new { BusinessId = 5, Street = "Street 5", City = "City 5", State = "State 5", Zipcode = "Zip5" }
            );

            //Dummy data for Business Users
            modelBuilder.Entity<BusinessUser>().HasData(
                new BusinessUser { Id = 1 * 2 - 1, AccountType = AccountType.Business, Username = $"businessuser1a", Password = "password", Email = $"businessuser1a@gmail.com", FirstName = "BusinessUser", LastName = $"1A", PhoneNumber = "5555555551", IsAdmin = true, BusinessId = 1 },
                new BusinessUser { Id = 1 * 2, AccountType = AccountType.Business, Username = $"businessuser1b", Password = "password", Email = $"businessuser1b@gmail.com", FirstName = "BusinessUser", LastName = $"1B", PhoneNumber = "5555555552", IsAdmin = false, BusinessId = 1 },
                new BusinessUser { Id = 2 * 2 - 1, AccountType = AccountType.Business, Username = $"businessuser2a", Password = "password", Email = $"businessuser2a@gmail.com", FirstName = "BusinessUser", LastName = $"2A", PhoneNumber = "5555555551", IsAdmin = true, BusinessId = 2 },
                new BusinessUser { Id = 2 * 2, AccountType = AccountType.Business, Username = $"businessuser2b", Password = "password", Email = $"businessuser2b@gmail.com", FirstName = "BusinessUser", LastName = $"2B", PhoneNumber = "5555555552", IsAdmin = false, BusinessId = 2 },
                new BusinessUser { Id = 3 * 2 - 1, AccountType = AccountType.Business, Username = $"businessuser3a", Password = "password", Email = $"businessuser3a@gmail.com", FirstName = "BusinessUser", LastName = $"3A", PhoneNumber = "5555555551", IsAdmin = true, BusinessId = 3 },
                new BusinessUser { Id = 3 * 2, AccountType = AccountType.Business, Username = $"businessuser3b", Password = "password", Email = $"businessuser3b@gmail.com", FirstName = "BusinessUser", LastName = $"3B", PhoneNumber = "5555555552", IsAdmin = false, BusinessId = 3 },
                new BusinessUser { Id = 4 * 2 - 1, AccountType = AccountType.Business, Username = $"businessuser4a", Password = "password", Email = $"businessuser4a@gmail.com", FirstName = "BusinessUser", LastName = $"4A", PhoneNumber = "5555555551", IsAdmin = true, BusinessId = 4 },
                new BusinessUser { Id = 4 * 2, AccountType = AccountType.Business, Username = $"businessuser4b", Password = "password", Email = $"businessuser4b@gmail.com", FirstName = "BusinessUser", LastName = $"4B", PhoneNumber = "5555555552", IsAdmin = false, BusinessId = 4 },
                new BusinessUser { Id = 5 * 2 - 1, AccountType = AccountType.Business, Username = $"businessuser5a", Password = "password", Email = $"businessuser5a@gmail.com", FirstName = "BusinessUser", LastName = $"5A", PhoneNumber = "5555555551", IsAdmin = true, BusinessId = 5 },
                new BusinessUser { Id = 5 * 2, AccountType = AccountType.Business, Username = $"businessuser5b", Password = "password", Email = $"businessuser5b@gmail.com", FirstName = "BusinessUser", LastName = $"5B", PhoneNumber = "5555555552", IsAdmin = false, BusinessId = 5 }
            );

            //Dummy data for Business Services
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, ServiceName = $"Service 1", BusinessId = 1, Description = "Description for Service 1", Price = 50.00, Duration = 30, Rating = 1 },
                new Service { Id = 2, ServiceName = $"Service 2", BusinessId = 2, Description = "Description for Service 2", Price = 60.00, Duration = 60, Rating = 2 },
                new Service { Id = 3, ServiceName = $"Service 3", BusinessId = 3, Description = "Description for Service 3", Price = 70.00, Duration = 30, Rating = 3 },
                new Service { Id = 4, ServiceName = $"Service 4", BusinessId = 4, Description = "Description for Service 4", Price = 80.00, Duration = 60, Rating = 4 },
                new Service { Id = 5, ServiceName = $"Service 5", BusinessId = 5, Description = "Description for Service 5", Price = 90.00, Duration = 90, Rating = 5 }
            );

            //Dummy data for Bookings
            modelBuilder.Entity<Booking>().HasData(
            new Booking { Id = 1, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1), ServiceId = 1, CustomerID = 1, BusinessID = 1, Cost = 100, Status = BookingStatus.Confirmed },
            new Booking { Id = 2, StartTime = DateTime.Now.AddDays(2), EndTime = DateTime.Now.AddDays(2).AddHours(1), ServiceId = 2, CustomerID = 2, BusinessID = 2, Cost = 150, Status = BookingStatus.Canceled },
            new Booking { Id = 3, StartTime = DateTime.Now.AddDays(3), EndTime = DateTime.Now.AddDays(3).AddHours(1), ServiceId = 3, CustomerID = 3, BusinessID = 3, Cost = 200, Status = BookingStatus.Complete },
            new Booking { Id = 4, StartTime = DateTime.Now.AddDays(4), EndTime = DateTime.Now.AddDays(4).AddHours(1), ServiceId = 4, CustomerID = 4, BusinessID = 4, Cost = 250, Status = BookingStatus.Confirmed },
            new Booking { Id = 5, StartTime = DateTime.Now.AddDays(5), EndTime = DateTime.Now.AddDays(5).AddHours(1), ServiceId = 5, CustomerID = 5, BusinessID = 5, Cost = 300, Status = BookingStatus.Canceled }
        );



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
