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
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    AccountType = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    TimeSlotId = table.Column<int>(type: "INTEGER", nullable: false),
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
                    Address_Coordinate = table.Column<string>(type: "TEXT", nullable: false),
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
                    BusinessId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
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
                    DaysAvailable = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentReviewId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rating = table.Column<float>(type: "REAL", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSlot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSlot_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "1633f073-0193-4bed-815e-db4cdeaf4713", 0, 0, "612 Warf Avenue", "Seattle", "28d91fbf-2df6-411b-919a-6a8f0f8029fe", "USER2@SERVICEMARKETPLACE.COM", false, "Jane", "Doe", true, null, "USER2@SERVICEMARKETPLACE.COM", "USER2@SERVICEMARKETPLACE.COM", null, "5555555555", false, "f6f78e70-4c38-4a48-93f8-5178dabe9125", "WA", false, "user2@servicemarketplace.com", "66666" },
                    { "2a0ee853-cec6-421c-b705-fcb67eecc5cd", 0, 1, "612 Warf Avenue", "Seattle", "19902036-46c2-4d38-8c3a-b8a46bb58282", "USER3@SERVICEMARKETPLACE.COM", false, "Jack", "Doe", true, null, "USER3@SERVICEMARKETPLACE.COM", "USER3@SERVICEMARKETPLACE.COM", null, "5555555555", false, "833dd20a-1db5-4bf8-adf5-e5efdbe2b40d", "WA", false, "user3@servicemarketplace.com", "66666" },
                    { "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 0, 0, "612 Warf Avenue", "Seattle", "e1c40dcc-125e-44c7-aac8-cdd160bc357a", "USER1@SERVICEMARKETPLACE.COM", false, "John", "Doe", true, null, "USER1@SERVICEMARKETPLACE.COM", "USER1@SERVICEMARKETPLACE.COM", null, "5555555555", false, "c8f63e76-7226-482d-9253-d552c7b6abbb", "WA", false, "user1@servicemarketplace.com", "66666" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CustomerId", "ServiceId", "Status", "TimeSlotId" },
                values: new object[,]
                {
                    { 1, "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 1, 0, 1 },
                    { 2, "1633f073-0193-4bed-815e-db4cdeaf4713", 2, 1, 2 },
                    { 3, "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 3, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "BusinessUsers",
                columns: new[] { "Id", "BusinessId", "IsAdmin", "UserId" },
                values: new object[,]
                {
                    { 1, 1, true, "2a0ee853-cec6-421c-b705-fcb67eecc5cd" },
                    { 2, 2, true, "2a0ee853-cec6-421c-b705-fcb67eecc5cd" },
                    { 3, 3, true, "2a0ee853-cec6-421c-b705-fcb67eecc5cd" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address_City", "Address_Coordinate", "Address_State", "Address_Street", "Address_Zipcode", "Description", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Townsville", "", "TS", "123 Main St, TS ", "12345", "Providing top-notch alpha services.", "Alpha Services", "1234567890" },
                    { 2, "Villageton", "", "VS", "456 Oak St", "67890", "Innovative solutions for your business needs.", "Beta Solutions", "9876543210" },
                    { 3, "Cityburg", "", "CB", "789 Pine St", "11223", "Your go-to partner for business growth.", "Gamma Enterprises", "5551234567" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BusinessId", "Description", "Duration", "Price", "Rating", "ServiceName" },
                values: new object[,]
                {
                    { 1, 1, "Building modern and responsive websites.", new TimeSpan(0, 1, 0, 0, 0), 50.0, 1.0, "Web Development" },
                    { 2, 2, "Creating stunning visual content.", new TimeSpan(0, 1, 30, 0, 0), 75.0, 2.0, "Graphic Design" },
                    { 3, 3, "Improving your website ranking on search engines.", new TimeSpan(0, 2, 0, 0, 0), 100.0, 3.0, "SEO Optimization" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CustomerId", "ParentReviewId", "Rating", "ServiceId", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "I love this service. Repeat customer!", "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 0, 5f, 1, new DateTime(2024, 8, 3, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3334) },
                    { 2, "Service was okay. Would use again.", "1633f073-0193-4bed-815e-db4cdeaf4713", 0, 3f, 2, new DateTime(2024, 8, 1, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3338) },
                    { 3, "BEWARE!! SEO did not work!!", "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 0, 1f, 3, new DateTime(2024, 7, 24, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3341) }
                });

            migrationBuilder.InsertData(
                table: "TimeSlot",
                columns: new[] { "Id", "EndTime", "ServiceId", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3266), 1, new DateTime(2024, 8, 13, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3216) },
                    { 2, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3270), 2, new DateTime(2024, 8, 13, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3269) },
                    { 3, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3274), 3, new DateTime(2024, 8, 13, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3273) },
                    { 4, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3277), 1, new DateTime(2024, 8, 4, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3276) },
                    { 5, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3280), 2, new DateTime(2024, 8, 4, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3279) },
                    { 6, new DateTime(2024, 8, 4, 14, 31, 3, 133, DateTimeKind.Local).AddTicks(3283), 3, new DateTime(2024, 8, 4, 13, 31, 3, 133, DateTimeKind.Local).AddTicks(3282) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ServiceId",
                table: "Reviews",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSlot_ServiceId",
                table: "TimeSlot",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "BusinessUsers");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ServiceAvailability");

            migrationBuilder.DropTable(
                name: "TimeSlot");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateOnly(2023, 6, 1), "Freezing", -5 },
                    { 2, new DateOnly(2023, 6, 2), "Bracing", 0 },
                    { 3, new DateOnly(2023, 6, 3), "Chilly", 5 },
                    { 4, new DateOnly(2023, 6, 4), "Cool", 10 },
                    { 5, new DateOnly(2023, 6, 5), "Mild", 15 },
                    { 6, new DateOnly(2023, 6, 6), "Warm", 20 },
                    { 7, new DateOnly(2023, 6, 7), "Balmy", 25 },
                    { 8, new DateOnly(2023, 6, 8), "Hot", 30 },
                    { 9, new DateOnly(2023, 6, 9), "Sweltering", 35 },
                    { 10, new DateOnly(2023, 6, 10), "Scorching", 40 }
                });
        }
    }
}
