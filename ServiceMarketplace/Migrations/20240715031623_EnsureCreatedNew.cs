using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceMarketplace.Migrations
{
    /// <inheritdoc />
    public partial class EnsureCreatedNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false),
                    BusinessID = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<float>(type: "REAL", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: false),
                    Address_State = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Zipcode = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccountType = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AccountType = table.Column<int>(type: "INTEGER", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    BusinessId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentInquiriesId = table.Column<int>(type: "INTEGER", nullable: false),
                    Response = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceAvailability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceAvailability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BusinessId = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceName = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentReviewId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false),
                    BusinessID = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rating = table.Column<float>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BusinessID", "Cost", "CustomerID", "Duration", "EndTime", "ServiceId", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, 1, 100f, 1, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 16, 0, 16, 23, 265, DateTimeKind.Local).AddTicks(6994), 1, new DateTime(2024, 7, 15, 23, 16, 23, 265, DateTimeKind.Local).AddTicks(6941), 0 },
                    { 2, 2, 150f, 2, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 17, 0, 16, 23, 265, DateTimeKind.Local).AddTicks(7001), 2, new DateTime(2024, 7, 16, 23, 16, 23, 265, DateTimeKind.Local).AddTicks(6999), 1 },
                    { 3, 3, 200f, 3, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 18, 0, 16, 23, 265, DateTimeKind.Local).AddTicks(7006), 3, new DateTime(2024, 7, 17, 23, 16, 23, 265, DateTimeKind.Local).AddTicks(7004), 2 },
                    { 4, 4, 250f, 4, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 19, 0, 16, 23, 265, DateTimeKind.Local).AddTicks(7012), 4, new DateTime(2024, 7, 18, 23, 16, 23, 265, DateTimeKind.Local).AddTicks(7010), 0 },
                    { 5, 5, 300f, 5, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 20, 0, 16, 23, 265, DateTimeKind.Local).AddTicks(7018), 5, new DateTime(2024, 7, 19, 23, 16, 23, 265, DateTimeKind.Local).AddTicks(7016), 1 }
                });

            migrationBuilder.InsertData(
                table: "BusinessUsers",
                columns: new[] { "Id", "AccountType", "Email", "FirstName", "IsAdmin", "LastName", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 1, 1, "businessuser1a@gmail.com", "BusinessUser", true, "1A", "password", "5555555551", "businessuser1a" },
                    { 2, 1, "businessuser1b@gmail.com", "BusinessUser", false, "1B", "password", "5555555552", "businessuser1b" },
                    { 3, 1, "businessuser2a@gmail.com", "BusinessUser", true, "2A", "password", "5555555551", "businessuser2a" },
                    { 4, 1, "businessuser2b@gmail.com", "BusinessUser", false, "2B", "password", "5555555552", "businessuser2b" },
                    { 5, 1, "businessuser3a@gmail.com", "BusinessUser", true, "3A", "password", "5555555551", "businessuser3a" },
                    { 6, 1, "businessuser3b@gmail.com", "BusinessUser", false, "3B", "password", "5555555552", "businessuser3b" },
                    { 7, 1, "businessuser4a@gmail.com", "BusinessUser", true, "4A", "password", "5555555551", "businessuser4a" },
                    { 8, 1, "businessuser4b@gmail.com", "BusinessUser", false, "4B", "password", "5555555552", "businessuser4b" },
                    { 9, 1, "businessuser5a@gmail.com", "BusinessUser", true, "5A", "password", "5555555551", "businessuser5a" },
                    { 10, 1, "businessuser5b@gmail.com", "BusinessUser", false, "5B", "password", "5555555552", "businessuser5b" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address_City", "Address_State", "Address_Street", "Address_Zipcode", "Description", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "City 1", "State 1", "Street 1", "Zip1", "Description for Business 1", "Business 1", "5555555551" },
                    { 2, "City 2", "State 2", "Street 2", "Zip2", "Description for Business 2", "Business 2", "5555555552" },
                    { 3, "City 3", "State 3", "Street 3", "Zip3", "Description for Business 3", "Business 3", "5555555553" },
                    { 4, "City 4", "State 4", "Street 4", "Zip4", "Description for Business 4", "Business 4", "5555555554" },
                    { 5, "City 5", "State 5", "Street 5", "Zip5", "Description for Business 5", "Business 5", "5555555555" }
                });

            migrationBuilder.InsertData(
                table: "CustomerUsers",
                columns: new[] { "Id", "AccountType", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Username" },
                values: new object[,]
                {
                    { 1, 0, "customer1@yahoo.com", "Customer", "One", "password1", "5555555555", "customer1" },
                    { 2, 0, "customer2@yahoo.com", "Customer", "Two", "password2", "5555555555", "customer2" },
                    { 3, 0, "customer3@yahoo.com", "Customer", "Three", "password3", "5555555555", "customer3" },
                    { 4, 0, "customer4@yahoo.com", "Customer", "Four", "password4", "5555555555", "customer4" },
                    { 5, 0, "customer5@yahoo.com", "Customer", "Five", "password5", "5555555555", "customer5" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BusinessId", "Description", "Duration", "Price", "Rating", "ServiceName" },
                values: new object[,]
                {
                    { 1, 1, "Description for Service 1", new TimeSpan(0, 0, 30, 0, 0), 50.0, 1.0, "Service 1" },
                    { 2, 2, "Description for Service 2", new TimeSpan(0, 1, 0, 0, 0), 60.0, 2.0, "Service 2" },
                    { 3, 3, "Description for Service 3", new TimeSpan(0, 0, 30, 0, 0), 70.0, 3.0, "Service 3" },
                    { 4, 4, "Description for Service 4", new TimeSpan(0, 1, 0, 0, 0), 80.0, 4.0, "Service 4" },
                    { 5, 5, "Description for Service 5", new TimeSpan(0, 1, 30, 0, 0), 90.0, 5.0, "Service 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ServiceId",
                table: "Reviews",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "BusinessUsers");

            migrationBuilder.DropTable(
                name: "CustomerUsers");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ServiceAvailability");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
