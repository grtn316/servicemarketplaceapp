using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Entities;

namespace ServiceMarketplace.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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
        //public DbSet<CustomerUser> CustomerUsers { get; set; }
        public DbSet<User> Users { get; set; }
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


            ////Dummy data for Customers
            //modelBuilder.Entity<CustomerUser>().HasData(
            //    new CustomerUser { Id = 1, AccountType = AccountType.Standard, Username = "customer1", Password = "password1", Email = "customer1@yahoo.com", FirstName = "Customer", LastName = "One", PhoneNumber = "5555555555" },
            //    new CustomerUser { Id = 2, AccountType = AccountType.Standard, Username = "customer2", Password = "password2", Email = "customer2@yahoo.com", FirstName = "Customer", LastName = "Two", PhoneNumber = "5555555555" },
            //    new CustomerUser { Id = 3, AccountType = AccountType.Standard, Username = "customer3", Password = "password3", Email = "customer3@yahoo.com", FirstName = "Customer", LastName = "Three", PhoneNumber = "5555555555" },
            //    new CustomerUser { Id = 4, AccountType = AccountType.Standard, Username = "customer4", Password = "password4", Email = "customer4@yahoo.com", FirstName = "Customer", LastName = "Four", PhoneNumber = "5555555555" },
            //    new CustomerUser { Id = 5, AccountType = AccountType.Standard, Username = "customer5", Password = "password5", Email = "customer5@yahoo.com", FirstName = "Customer", LastName = "Five", PhoneNumber = "5555555555" }
            //);

            //    //Dummy data for Customers
            //    modelBuilder.Entity<User>().HasData(
            //        new User { Id = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", AccountType = AccountType.Standard, Email = "USER1@SERVICEMARKETPLACE.COM", NormalizedEmail = "USER1@SERVICEMARKETPLACE.COM", UserName = "user1@servicemarketplace.com", NormalizedUserName = "USER1@SERVICEMARKETPLACE.COM", FirstName = "John", LastName = "Doe", Address = "612 Warf Avenue", City = "Seattle", State="WA", ZipCode="66666", PhoneNumber = "5555555555", LockoutEnabled=true, PasswordHash= "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==" },
            //        new User { Id = "1633f073-0193-4bed-815e-db4cdeaf4713", AccountType = AccountType.Standard, Email = "USER2@SERVICEMARKETPLACE.COM", NormalizedEmail = "USER2@SERVICEMARKETPLACE.COM", UserName = "user2@servicemarketplace.com", NormalizedUserName = "USER2@SERVICEMARKETPLACE.COM", FirstName = "Jane", LastName = "Doe", Address = "612 Warf Avenue", City = "Seattle", State = "WA", ZipCode = "66666", PhoneNumber = "5555555555", LockoutEnabled = true, PasswordHash = "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==" },
            //        new User { Id = "2a0ee853-cec6-421c-b705-fcb67eecc5cd", AccountType = AccountType.Business, Email = "USER3@SERVICEMARKETPLACE.COM", NormalizedEmail = "USER3@SERVICEMARKETPLACE.COM", UserName = "user3@servicemarketplace.com", NormalizedUserName = "USER3@SERVICEMARKETPLACE.COM", FirstName = "Jack", LastName = "Doe", Address = "612 Warf Avenue", City = "Seattle", State = "WA", ZipCode = "66666", PhoneNumber = "5555555555", LockoutEnabled = true, PasswordHash = "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==" }
            //    );

            //    //Dummy data for Businesses
            //    modelBuilder.Entity<Business>().HasData(
            //        new Business { Id = 1, Name = $"Alpha Services", Description = $"Providing top-notch alpha services.", PhoneNumber = "1234567890" },
            //        new Business { Id = 2, Name = $"Beta Solutions", Description = $"Innovative solutions for your business needs.", PhoneNumber = "9876543210" },
            //        new Business { Id = 3, Name = $"Gamma Enterprises", Description = $"Your go-to partner for business growth.", PhoneNumber = "5551234567" }
            //    );

            //    //Dummy data for Businesses Addresses
            //    modelBuilder.Entity<Business>().OwnsOne(b => b.Address).HasData(
            //        new { BusinessId = 1, Street = "123 Main St, TS ", City = "Townsville", State = "TS", Zipcode = "12345", Coordinate = "" },
            //        new { BusinessId = 2, Street = "456 Oak St", City = "Villageton", State = "VS", Zipcode = "67890", Coordinate = "" },
            //        new { BusinessId = 3, Street = "789 Pine St", City = "Cityburg", State = "CB", Zipcode = "11223", Coordinate = "" }
            //    );

            //    //Dummy data for Business Users
            //    modelBuilder.Entity<BusinessUser>().HasData(
            //        new BusinessUser { Id = 1, IsAdmin = true, BusinessId = 1, UserId= "2a0ee853-cec6-421c-b705-fcb67eecc5cd" },
            //        new BusinessUser { Id = 2, IsAdmin = true, BusinessId = 2, UserId= "2a0ee853-cec6-421c-b705-fcb67eecc5cd" },
            //        new BusinessUser { Id = 3, IsAdmin = true, BusinessId = 3, UserId= "2a0ee853-cec6-421c-b705-fcb67eecc5cd" }
            //    );

            //    //Dummy data for Services
            //    modelBuilder.Entity<Service>().HasData(
            //        new Service { Id = 1, ServiceName = $"Web Development", BusinessId = 1, Description = "Building modern and responsive websites.", Price = 50.00, Duration = new TimeSpan(00,60,00), Rating = 1 },
            //        new Service { Id = 2, ServiceName = $"Graphic Design", BusinessId = 2, Description = "Creating stunning visual content.", Price = 75.00, Duration = new TimeSpan(01, 30, 00), Rating = 2 },
            //        new Service { Id = 3, ServiceName = $"SEO Optimization", BusinessId = 3, Description = "Improving your website ranking on search engines.", Price = 100.00, Duration = new TimeSpan(02, 00, 00), Rating = 3 }
            //    );

            //    //Dummy data for Timeslot
            //    modelBuilder.Entity<TimeSlot>().HasData(
            //    new TimeSlot { Id = 1, ServiceId = 1, StartTime = DateTime.Now.AddDays(10), EndTime = DateTime.Now.AddDays(1).AddHours(1) },
            //    new TimeSlot { Id = 2, ServiceId = 2, StartTime = DateTime.Now.AddDays(10), EndTime = DateTime.Now.AddDays(1).AddHours(1) },
            //    new TimeSlot { Id = 3, ServiceId = 3, StartTime = DateTime.Now.AddDays(10), EndTime = DateTime.Now.AddDays(1).AddHours(1) },
            //    new TimeSlot { Id = 4, ServiceId = 1, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1) },
            //    new TimeSlot { Id = 5, ServiceId = 2, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1) },
            //    new TimeSlot { Id = 6, ServiceId = 3, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1) }
            //);

            //    //Dummy data for Bookings
            //    modelBuilder.Entity<Booking>().HasData(
            //    new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", TimeSlotId=1, Status = BookingStatus.Confirmed },
            //    new Booking { Id = 2, ServiceId = 2, CustomerId = "1633f073-0193-4bed-815e-db4cdeaf4713", TimeSlotId =2, Status = BookingStatus.Canceled },
            //    new Booking { Id = 3, ServiceId = 3, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", TimeSlotId =3, Status = BookingStatus.Complete }
            //);

            //    //Dummy data for Service Reviews
            //    modelBuilder.Entity<Review>().HasData(
            //    new Review { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", ParentReviewId=0, TimeStamp = DateTime.Now, Rating =5, Comment = "I love this service. Repeat customer!"},
            //    new Review { Id = 2, ServiceId = 2, CustomerId = "1633f073-0193-4bed-815e-db4cdeaf4713", ParentReviewId = 0, TimeStamp = DateTime.Now.AddDays(-2), Rating = 3, Comment = "Service was okay. Would use again." },
            //    new Review { Id = 3, ServiceId = 3, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", ParentReviewId = 0, TimeStamp = DateTime.Now.AddDays(-10), Rating = 1, Comment = "BEWARE!! SEO did not work!!" }
            //);





            //modelBuilder.Entity<WeatherForecast>().HasData(
            //    new WeatherForecast
            //    {
            //        Id = 1,
            //        Date = new DateOnly(2023, 6, 1),
            //        TemperatureC = -5,
            //        Summary = "Freezing"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 2,
            //        Date = new DateOnly(2023, 6, 2),
            //        TemperatureC = 0,
            //        Summary = "Bracing"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 3,
            //        Date = new DateOnly(2023, 6, 3),
            //        TemperatureC = 5,
            //        Summary = "Chilly"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 4,
            //        Date = new DateOnly(2023, 6, 4),
            //        TemperatureC = 10,
            //        Summary = "Cool"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 5,
            //        Date = new DateOnly(2023, 6, 5),
            //        TemperatureC = 15,
            //        Summary = "Mild"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 6,
            //        Date = new DateOnly(2023, 6, 6),
            //        TemperatureC = 20,
            //        Summary = "Warm"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 7,
            //        Date = new DateOnly(2023, 6, 7),
            //        TemperatureC = 25,
            //        Summary = "Balmy"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 8,
            //        Date = new DateOnly(2023, 6, 8),
            //        TemperatureC = 30,
            //        Summary = "Hot"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 9,
            //        Date = new DateOnly(2023, 6, 9),
            //        TemperatureC = 35,
            //        Summary = "Sweltering"
            //    },
            //    new WeatherForecast
            //    {
            //        Id = 10,
            //        Date = new DateOnly(2023, 6, 10),
            //        TemperatureC = 40,
            //        Summary = "Scorching"
            //    }
            //);


            string commonPasswordHash = "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==";

            var realAddresses = new List<string>
            {
                "100 N Osceola Ave", "200 N Fort Harrison Ave", "300 N Betty Ln", "400 N Highland Ave",
                "500 Eldridge St", "600 N Garden Ave", "700 N Myrtle Ave", "800 N Washington Ave",
                "900 Drew St", "1000 Palmetto St", "1100 Druid Rd", "1200 Jeffords St",
                "1300 Cleveland St", "1400 N Martin Luther King Jr Ave", "1500 Douglas Ave", "1600 Sunset Point Rd",
                "1700 N Keene Rd", "1800 N Lincoln Ave", "1900 S Martin Luther King Jr Ave", "2000 Glenwood Ave",
                "2100 Cherry St", "2200 Brentwood Dr", "2300 N McMullen Booth Rd", "2400 N Bayshore Blvd",
                "2500 N Lake Dr", "2600 N Missouri Ave", "2700 Overbrook Ave", "2800 Palm Dr",
                "2900 Grove St", "3000 Robin Hood Ln", "3100 N Osceola Ave", "3200 Magnolia Dr",
                "3300 Evergreen Ave", "3400 Fairmont St", "3500 Oak St", "3600 Sunset Dr",
                "3700 Lakeview Rd", "3800 Morningside Dr", "3900 N Osceola Ave", "4000 Pinellas St",
                "4100 Highland Dr", "4200 N Garden Ave", "4300 N Keene Rd", "4400 Edgewood Ave",
                "4500 Belcher Rd", "4600 Flagler Dr", "4700 Admiral Dr", "4800 Palmetto St",
                "4900 Sunset Point Rd", "5000 Greenbriar Blvd"
            };

            var realBusinessNames = new List<string>
            {
                "Sunshine Lawn Care", "Ocean Breeze Spa", "Gulf Coast Plumbing", "Clearwater Auto Repair",
                "Beachside Cafe", "Harborview Dentistry", "Bayfront Accounting", "Seaside Yoga Studio",
                "Tropical Landscaping", "Clearwater Electric", "Island Pet Grooming", "Sunset Realty",
                "Palm Tree Services", "Paradise Painting", "Coastal Roofing", "Sandy Shores Marina",
                "Coral Reef Cleaning", "Sunset Salon", "Tampa Bay Tech Support", "Bay Area Fitness",
                "Suncoast Pest Control", "Beachside Bakery", "Bay Breeze HVAC", "Coastal Legal Services",
                "Gulfview Tutoring", "Sunshine Printing", "Clearwater Chiropractic", "Sunset Landscaping",
                "Sunshine Automotive", "Oceanfront Legal Services", "Beachside Bicycles", "Bay Area Movers",
                "Sunshine Web Design", "Clearwater Financial Planning", "Tampa Bay Event Planning",
                "Coastal Veterinary Clinic", "Sunshine Insurance", "Gulf Coast Home Repair",
                "Sunset Photography", "Clearwater Window Cleaning", "Beachside Florist", "Sunshine Travel Agency",
                "Bay Area Catering", "Sunshine Daycare", "Clearwater Dry Cleaning", "Gulf Coast Fitness",
                "Sunshine Tutoring", "Clearwater Real Estate", "Tampa Bay Music Lessons", "Sunshine IT Services"
            };

            var realServiceNames = new List<string>
            {
                "Lawn Mowing", "Massage Therapy", "Pipe Repair", "Oil Change",
                "Coffee and Pastries", "Dental Cleaning", "Tax Preparation", "Yoga Classes",
                "Garden Maintenance", "Electrical Repair", "Pet Grooming", "Real Estate Services",
                "Painting Services", "Roof Repair", "Boat Docking", "House Cleaning",
                "Hair Styling", "IT Support", "Personal Training", "Pest Control",
                "Bakery Services", "HVAC Repair", "Legal Consultation", "Tutoring Services",
                "Printing Services", "Chiropractic Adjustment", "Landscaping", "Auto Repair",
                "Legal Services", "Bicycle Repair", "Moving Services", "Web Design",
                "Financial Planning", "Event Planning", "Veterinary Services", "Insurance Services",
                "Home Repair", "Photography", "Window Cleaning", "Florist Services",
                "Travel Planning", "Catering", "Childcare", "Dry Cleaning",
                "Fitness Training", "Academic Tutoring", "Real Estate Consulting", "Music Lessons",
                "IT Consulting", "Bicycle Repair"
            };


            var users = new List<User>();
            var businesses = new List<Business>();
            var businessAddresses = new List<object>();
            var businessUsers = new List<BusinessUser>();
            var services = new List<Service>();
            var timeSlots = new List<TimeSlot>();

            users.Add(new User { Id = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", AccountType = AccountType.Standard, Email = "USER1@SERVICEMARKETPLACE.COM", NormalizedEmail = "USER1@SERVICEMARKETPLACE.COM", UserName = "user1@servicemarketplace.com", NormalizedUserName = "USER1@SERVICEMARKETPLACE.COM", FirstName = "John", LastName = "Doe", Address = "123 Oasis Ave", City = "Clearwater", State = "FL", ZipCode = "33755", PhoneNumber = "5555555555", LockoutEnabled = true, PasswordHash = "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==" });
            users.Add(new User { Id = "1633f073-0193-4bed-815e-db4cdeaf4713", AccountType = AccountType.Standard, Email = "USER2@SERVICEMARKETPLACE.COM", NormalizedEmail = "USER2@SERVICEMARKETPLACE.COM", UserName = "user2@servicemarketplace.com", NormalizedUserName = "USER2@SERVICEMARKETPLACE.COM", FirstName = "Jane", LastName = "Doe", Address = "124 Beach Side Rd", City = "Clearwater", State = "FL", ZipCode = "33755", PhoneNumber = "5555555555", LockoutEnabled = true, PasswordHash = "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==" });

            int timeslotId = 1; //timeslot counter

            for (int i = 1; i <= 50; i++)
            {
                var userId = Guid.NewGuid().ToString();
                users.Add(new User
                {
                    Id = userId,
                    AccountType = AccountType.Business,
                    Email = $"user{i + 2}@servicemarketplace.com",
                    NormalizedEmail = $"USER{i + 2}@SERVICEMARKETPLACE.COM",
                    UserName = $"user{i + 2}@servicemarketplace.com",
                    NormalizedUserName = $"USER{i + 2}@SERVICEMARKETPLACE.COM",
                    FirstName = $"First{i}",
                    LastName = $"Last{i}",
                    Address = realAddresses[i - 1],
                    City = "Clearwater",
                    State = "FL",
                    ZipCode = "33755",
                    PhoneNumber = $"727555{i:0000}",
                    LockoutEnabled = true,
                    PasswordHash = commonPasswordHash
                });

                var businessId = i;
                businesses.Add(new Business
                {
                    Id = businessId,
                    Name = realBusinessNames[i - 1],
                    Description = $"Description for {realBusinessNames[i - 1]}",
                    PhoneNumber = $"727555{i:0000}"
                });

                businessAddresses.Add(new
                {
                    BusinessId = businessId,
                    Street = realAddresses[i - 1],
                    City = "Clearwater",
                    State = "FL",
                    Zipcode = "33755",
                    Coordinate = ""
                });

                businessUsers.Add(new BusinessUser
                {
                    Id = i,
                    IsAdmin = true,
                    BusinessId = businessId,
                    UserId = userId
                });

                var serviceId = businessId;
                services.Add(new Service
                {
                    Id = serviceId,
                    ServiceName = realServiceNames[i - 1],
                    BusinessId = businessId,
                    Description = $"Description for {realServiceNames[i - 1]}",
                    Price = 50.00 + i * 5,
                    Duration = new TimeSpan(0, 60, 0),
                    Rating = (i % 5) + 1
                });

                for (int k = 1; k <= 10; k++) // Generate 10 timeslots per service
                {
                    var startTime = DateTime.Now.AddDays(k).AddHours(i).AddMinutes(-DateTime.Now.Minute).AddSeconds(-DateTime.Now.Second).AddMilliseconds(-DateTime.Now.Millisecond);
                    var endTime = startTime.AddHours(1);

                    timeSlots.Add(new TimeSlot
                    {
                        Id = timeslotId++,
                        ServiceId = serviceId,
                        StartTime = startTime,
                        EndTime = endTime
                    });
                }
            }

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Business>().HasData(businesses);
            modelBuilder.Entity<Business>().OwnsOne(b => b.Address).HasData(businessAddresses);
            modelBuilder.Entity<BusinessUser>().HasData(businessUsers);
            modelBuilder.Entity<Service>().HasData(services);
            modelBuilder.Entity<TimeSlot>().HasData(timeSlots);

        }
    }
}

