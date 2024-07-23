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
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 0, "a0922d43-e12d-474b-a2d9-da60fdd6f7a6", "customer1@yahoo.com", false, "Customer", "One", false, null, null, null, null, "5555555555", false, "99f5d795-24d9-4b47-a91d-e64e042885ff", false, null },
                    { "2", 0, 0, "7b1f20d7-a32d-438d-9e1b-1cf862475c19", "customer2@yahoo.com", false, "Customer", "Two", false, null, null, null, null, "5555555555", false, "2f4b479c-a9d0-424d-a266-315ee5e34507", false, null },
                    { "3", 0, 0, "569f917a-9f8c-4846-91f4-a493e9455452", "customer3@yahoo.com", false, "Customer", "Three", false, null, null, null, null, "5555555555", false, "7c68c3ab-866c-483f-a9a3-3b621a64b04b", false, null },
                    { "4", 0, 0, "d8cda4c8-4eaf-4392-a31b-e13c952d6ed6", "customer4@yahoo.com", false, "Customer", "Four", false, null, null, null, null, "5555555555", false, "a20946c6-01d0-4cef-8d6e-05d89554e151", false, null },
                    { "5", 0, 0, "8c515369-28b6-4b6a-b9ed-480723e62104", "customer5@yahoo.com", false, "Customer", "Five", false, null, null, null, null, "5555555555", false, "fbe2f0a7-8118-47b2-b7d5-16b04310242b", false, null }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BusinessID", "Cost", "CustomerID", "Duration", "EndTime", "ServiceId", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, 1, 100f, 1, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 23, 22, 54, 51, 692, DateTimeKind.Local).AddTicks(1084), 1, new DateTime(2024, 7, 23, 21, 54, 51, 692, DateTimeKind.Local).AddTicks(1036), 0 },
                    { 2, 2, 150f, 2, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 24, 22, 54, 51, 692, DateTimeKind.Local).AddTicks(1090), 2, new DateTime(2024, 7, 24, 21, 54, 51, 692, DateTimeKind.Local).AddTicks(1089), 1 },
                    { 3, 3, 200f, 3, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 25, 22, 54, 51, 692, DateTimeKind.Local).AddTicks(1095), 3, new DateTime(2024, 7, 25, 21, 54, 51, 692, DateTimeKind.Local).AddTicks(1093), 2 },
                    { 4, 4, 250f, 4, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 26, 22, 54, 51, 692, DateTimeKind.Local).AddTicks(1098), 4, new DateTime(2024, 7, 26, 21, 54, 51, 692, DateTimeKind.Local).AddTicks(1097), 0 },
                    { 5, 5, 300f, 5, new TimeSpan(0, 0, 0, 0, 0), new DateTime(2024, 7, 27, 22, 54, 51, 692, DateTimeKind.Local).AddTicks(1102), 5, new DateTime(2024, 7, 27, 21, 54, 51, 692, DateTimeKind.Local).AddTicks(1101), 1 }
                });

            migrationBuilder.InsertData(
                table: "BusinessUsers",
                columns: new[] { "Id", "IsAdmin", "UserId" },
                values: new object[,]
                {
                    { 1, true, 0 },
                    { 2, false, 0 },
                    { 3, true, 0 },
                    { 4, false, 0 },
                    { 5, true, 0 },
                    { 6, false, 0 },
                    { 7, true, 0 },
                    { 8, false, 0 },
                    { 9, true, 0 },
                    { 10, false, 0 }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
