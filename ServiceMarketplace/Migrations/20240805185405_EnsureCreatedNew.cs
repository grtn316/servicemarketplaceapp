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
                    table.ForeignKey(
                        name: "FK_BusinessUsers_Businesses_BusinessId",
                        column: x => x.BusinessId,
                        principalTable: "Businesses",
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
                    table.ForeignKey(
                        name: "FK_Bookings_TimeSlot_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "Address", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "State", "TwoFactorEnabled", "UserName", "ZipCode" },
                values: new object[,]
                {
                    { "0be46e40-a432-490a-b0a9-7d66480a6949", 0, 1, "4700 Admiral Dr", "Clearwater", "c55cf7fc-8141-48da-a574-7220da45f23e", "user49@servicemarketplace.com", false, "First47", "Last47", true, null, "USER49@SERVICEMARKETPLACE.COM", "USER49@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550047", false, "6903d36e-9b21-4732-ad8f-e3fa0aa0bf0f", "FL", false, "user49@servicemarketplace.com", "33755" },
                    { "128e1ea9-166e-47d0-91e5-f80913c72cd2", 0, 1, "3600 Sunset Dr", "Clearwater", "c63a302d-6504-4c46-a9b3-e1574e44f4ba", "user38@servicemarketplace.com", false, "First36", "Last36", true, null, "USER38@SERVICEMARKETPLACE.COM", "USER38@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550036", false, "b54a554d-aabc-43a1-a128-9944ebd25934", "FL", false, "user38@servicemarketplace.com", "33755" },
                    { "1633f073-0193-4bed-815e-db4cdeaf4713", 0, 0, "124 Beach Side Rd", "Clearwater", "2dbb0b33-174a-47d3-90dc-f8d6c1fbdf97", "USER2@SERVICEMARKETPLACE.COM", false, "Jane", "Doe", true, null, "USER2@SERVICEMARKETPLACE.COM", "USER2@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "5555555555", false, "6084ce6f-d3c2-4cbf-af36-240317391d92", "FL", false, "user2@servicemarketplace.com", "33755" },
                    { "23784f5f-a390-4428-b6e7-c85b2c455701", 0, 1, "1800 N Lincoln Ave", "Clearwater", "11389ea9-b1ce-46fb-b794-00eb18937fb6", "user20@servicemarketplace.com", false, "First18", "Last18", true, null, "USER20@SERVICEMARKETPLACE.COM", "USER20@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550018", false, "5c98217f-f66a-4d95-a451-64e88d49327b", "FL", false, "user20@servicemarketplace.com", "33755" },
                    { "239111c2-b752-4666-b783-1ba66d8ceeaa", 0, 1, "3900 N Osceola Ave", "Clearwater", "28b0bf3a-d54e-4124-b7eb-f18258174d1e", "user41@servicemarketplace.com", false, "First39", "Last39", true, null, "USER41@SERVICEMARKETPLACE.COM", "USER41@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550039", false, "ebda21c9-104d-4c91-b843-cea1627aa25f", "FL", false, "user41@servicemarketplace.com", "33755" },
                    { "25544a0b-7943-4ae2-900a-0c7813e48bef", 0, 1, "900 Drew St", "Clearwater", "bca2fc6d-d466-44fc-b433-d52047952458", "user11@servicemarketplace.com", false, "First9", "Last9", true, null, "USER11@SERVICEMARKETPLACE.COM", "USER11@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550009", false, "bab78a4f-c546-41ef-8a7c-6b100d19c385", "FL", false, "user11@servicemarketplace.com", "33755" },
                    { "26b3d11f-be4b-4f1d-834f-17335bbfc945", 0, 1, "4900 Sunset Point Rd", "Clearwater", "02a36d4f-ad71-4b85-b6b6-8a125645b91b", "user51@servicemarketplace.com", false, "First49", "Last49", true, null, "USER51@SERVICEMARKETPLACE.COM", "USER51@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550049", false, "bed20aaa-eb87-464f-a6cb-f68ba2c5d7dc", "FL", false, "user51@servicemarketplace.com", "33755" },
                    { "28a84cdb-2a65-4585-b8cb-7b153c26c599", 0, 1, "1200 Jeffords St", "Clearwater", "45d71032-f267-438d-847d-c756bbc69cdf", "user14@servicemarketplace.com", false, "First12", "Last12", true, null, "USER14@SERVICEMARKETPLACE.COM", "USER14@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550012", false, "47a9fb86-e959-43e1-abf3-272d4e724a34", "FL", false, "user14@servicemarketplace.com", "33755" },
                    { "2daae73f-67b6-432b-8be4-81b4a63050da", 0, 1, "400 N Highland Ave", "Clearwater", "7b3681e6-fc5d-49cd-aad2-eab64cd7dbdc", "user6@servicemarketplace.com", false, "First4", "Last4", true, null, "USER6@SERVICEMARKETPLACE.COM", "USER6@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550004", false, "e752e5c8-279a-472e-8330-c0c70f959a2f", "FL", false, "user6@servicemarketplace.com", "33755" },
                    { "3077005a-8b54-4c69-a286-8e6017f6de45", 0, 1, "3400 Fairmont St", "Clearwater", "62abe934-b291-4453-8469-d6360e7d7a28", "user36@servicemarketplace.com", false, "First34", "Last34", true, null, "USER36@SERVICEMARKETPLACE.COM", "USER36@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550034", false, "09495633-4d35-48ae-a653-adef7fd1c787", "FL", false, "user36@servicemarketplace.com", "33755" },
                    { "439beb41-15f2-4d52-aa29-f0916c3ddce8", 0, 1, "1100 Druid Rd", "Clearwater", "45551f26-c928-4246-8f54-b1d9dfdd4fae", "user13@servicemarketplace.com", false, "First11", "Last11", true, null, "USER13@SERVICEMARKETPLACE.COM", "USER13@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550011", false, "cb27ff6e-4061-4e61-b36e-76ae732a84d3", "FL", false, "user13@servicemarketplace.com", "33755" },
                    { "4844e7a1-93f9-4ece-86a5-43fd4056d482", 0, 1, "3700 Lakeview Rd", "Clearwater", "dc59eabc-01fa-4161-b912-31b0e593bcb0", "user39@servicemarketplace.com", false, "First37", "Last37", true, null, "USER39@SERVICEMARKETPLACE.COM", "USER39@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550037", false, "9e16d59a-5b3a-469f-a8fb-353b20cec06c", "FL", false, "user39@servicemarketplace.com", "33755" },
                    { "4affd071-5d78-477e-99ef-b7262557a1ef", 0, 1, "3000 Robin Hood Ln", "Clearwater", "4392c2e7-ad0b-4830-a644-c8e4ad626cb1", "user32@servicemarketplace.com", false, "First30", "Last30", true, null, "USER32@SERVICEMARKETPLACE.COM", "USER32@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550030", false, "67b4c3cd-9dde-499b-bd29-2c8e03ce2332", "FL", false, "user32@servicemarketplace.com", "33755" },
                    { "4bb98165-51a1-4651-bc81-1c51865144e5", 0, 1, "2000 Glenwood Ave", "Clearwater", "f2c4877f-1336-44c5-8be4-38968e710548", "user22@servicemarketplace.com", false, "First20", "Last20", true, null, "USER22@SERVICEMARKETPLACE.COM", "USER22@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550020", false, "7954ef6b-059c-4e5e-940b-d32fcd8de121", "FL", false, "user22@servicemarketplace.com", "33755" },
                    { "4ca0f081-27c9-4ab7-938d-a2433a876f7f", 0, 1, "2500 N Lake Dr", "Clearwater", "c29be0f5-7c29-4db5-9374-51d7d81e6f52", "user27@servicemarketplace.com", false, "First25", "Last25", true, null, "USER27@SERVICEMARKETPLACE.COM", "USER27@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550025", false, "2ad6a369-c9ef-4a63-84bf-b0a13083e643", "FL", false, "user27@servicemarketplace.com", "33755" },
                    { "52d49244-516c-478b-9420-33a25f081faf", 0, 1, "1000 Palmetto St", "Clearwater", "7a6d6295-fa37-4bd6-b78d-fb79bd8cba6a", "user12@servicemarketplace.com", false, "First10", "Last10", true, null, "USER12@SERVICEMARKETPLACE.COM", "USER12@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550010", false, "a4042aaf-bba9-4064-b878-04ab3b87456f", "FL", false, "user12@servicemarketplace.com", "33755" },
                    { "536d31be-56af-4a35-9e8e-03d5682236ac", 0, 1, "2700 Overbrook Ave", "Clearwater", "33686250-ecdc-47a8-b8a6-ee5cdcffbc69", "user29@servicemarketplace.com", false, "First27", "Last27", true, null, "USER29@SERVICEMARKETPLACE.COM", "USER29@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550027", false, "7b0a065c-a721-4489-9c3f-a39ad26565a1", "FL", false, "user29@servicemarketplace.com", "33755" },
                    { "5604c0ca-3810-4f01-8933-8428ddfeff0a", 0, 1, "1600 Sunset Point Rd", "Clearwater", "e48a4c55-bd50-4865-9962-bea41ad239bd", "user18@servicemarketplace.com", false, "First16", "Last16", true, null, "USER18@SERVICEMARKETPLACE.COM", "USER18@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550016", false, "febe429d-d19c-48ea-8527-c64a5a10185e", "FL", false, "user18@servicemarketplace.com", "33755" },
                    { "56c29cfc-e2b5-4167-b929-36a25eed778d", 0, 1, "2100 Cherry St", "Clearwater", "c47e2650-ff57-414e-a975-4330f718c550", "user23@servicemarketplace.com", false, "First21", "Last21", true, null, "USER23@SERVICEMARKETPLACE.COM", "USER23@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550021", false, "31d619be-1846-4b38-baf1-a551477caba4", "FL", false, "user23@servicemarketplace.com", "33755" },
                    { "573a7747-0216-4a4e-a71e-6d0b11ae1d04", 0, 1, "4600 Flagler Dr", "Clearwater", "dd1eb610-04ec-4c00-b718-84014e97b6d6", "user48@servicemarketplace.com", false, "First46", "Last46", true, null, "USER48@SERVICEMARKETPLACE.COM", "USER48@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550046", false, "dfbb0dbf-9f8e-4655-b2c6-b1a2302a7afb", "FL", false, "user48@servicemarketplace.com", "33755" },
                    { "5d954119-7249-47d0-8cb4-7f3dd23d05a4", 0, 1, "2200 Brentwood Dr", "Clearwater", "dea3a864-0078-426e-928d-c48a24642f5c", "user24@servicemarketplace.com", false, "First22", "Last22", true, null, "USER24@SERVICEMARKETPLACE.COM", "USER24@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550022", false, "afddeef0-15ee-4925-bb26-a28cca580b9c", "FL", false, "user24@servicemarketplace.com", "33755" },
                    { "6c8dcb1e-5362-4567-ac7a-233d1e375994", 0, 1, "2400 N Bayshore Blvd", "Clearwater", "48d54516-b14c-4d5c-a866-9cd1ecd3c09c", "user26@servicemarketplace.com", false, "First24", "Last24", true, null, "USER26@SERVICEMARKETPLACE.COM", "USER26@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550024", false, "e5fe9f0e-736a-498a-afbc-b8e8b4c20a47", "FL", false, "user26@servicemarketplace.com", "33755" },
                    { "7462a972-6397-4a38-8ccb-92cc83ea99ad", 0, 1, "800 N Washington Ave", "Clearwater", "23eddb46-025d-44fe-bdee-43dd7d12d606", "user10@servicemarketplace.com", false, "First8", "Last8", true, null, "USER10@SERVICEMARKETPLACE.COM", "USER10@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550008", false, "2b69b4dd-f66c-4079-8c81-18fbada2ebe7", "FL", false, "user10@servicemarketplace.com", "33755" },
                    { "7a715aec-b75f-4056-87d9-64c544b1c16d", 0, 1, "3300 Evergreen Ave", "Clearwater", "75159f24-4062-448f-af86-218a3d705917", "user35@servicemarketplace.com", false, "First33", "Last33", true, null, "USER35@SERVICEMARKETPLACE.COM", "USER35@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550033", false, "dd164b0e-1729-4cc4-86e0-ac614d0f6402", "FL", false, "user35@servicemarketplace.com", "33755" },
                    { "7daae948-89a2-4865-be60-40631241beed", 0, 1, "4500 Belcher Rd", "Clearwater", "03e1427e-34de-40a5-9ee5-5e0e70bc4ed2", "user47@servicemarketplace.com", false, "First45", "Last45", true, null, "USER47@SERVICEMARKETPLACE.COM", "USER47@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550045", false, "9cc22677-4922-4cf4-8343-27fc0eaa2a18", "FL", false, "user47@servicemarketplace.com", "33755" },
                    { "7ff3f0f3-44b0-45e5-9206-0d5141b303dc", 0, 1, "4100 Highland Dr", "Clearwater", "94c05d19-d586-4667-a92a-e8f0861c54fd", "user43@servicemarketplace.com", false, "First41", "Last41", true, null, "USER43@SERVICEMARKETPLACE.COM", "USER43@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550041", false, "3a963ec8-02e3-4876-b188-48158d744ef0", "FL", false, "user43@servicemarketplace.com", "33755" },
                    { "8232fdf2-97c3-4fed-a1ef-523b173a573b", 0, 1, "1700 N Keene Rd", "Clearwater", "2610c8f0-550d-4ae3-aec6-d40ec6676a30", "user19@servicemarketplace.com", false, "First17", "Last17", true, null, "USER19@SERVICEMARKETPLACE.COM", "USER19@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550017", false, "fd226e12-9a21-4d01-bc1e-f7d7c8df87c3", "FL", false, "user19@servicemarketplace.com", "33755" },
                    { "8bd58ff3-bdba-4c0a-8c4e-9f38b89cd15a", 0, 1, "1900 S Martin Luther King Jr Ave", "Clearwater", "795470c5-4d7d-41bb-a05f-d4677860af3b", "user21@servicemarketplace.com", false, "First19", "Last19", true, null, "USER21@SERVICEMARKETPLACE.COM", "USER21@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550019", false, "526e1811-a4e4-4b01-87d6-dac98182ef99", "FL", false, "user21@servicemarketplace.com", "33755" },
                    { "950debab-5465-4ce3-b8bd-bfbcc21bed52", 0, 1, "4300 N Keene Rd", "Clearwater", "4398c391-30d3-47bf-b731-c96eab80e609", "user45@servicemarketplace.com", false, "First43", "Last43", true, null, "USER45@SERVICEMARKETPLACE.COM", "USER45@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550043", false, "5d1f2164-47f3-4561-aeab-29dbbeacf7b6", "FL", false, "user45@servicemarketplace.com", "33755" },
                    { "9968dd99-8b8f-4e12-a2f1-1ff4e89ad892", 0, 1, "500 Eldridge St", "Clearwater", "475354e0-6034-4bf7-9a30-5533f675b924", "user7@servicemarketplace.com", false, "First5", "Last5", true, null, "USER7@SERVICEMARKETPLACE.COM", "USER7@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550005", false, "c0c951ae-3e7c-4076-aff5-6ac1e078e9ab", "FL", false, "user7@servicemarketplace.com", "33755" },
                    { "9a54338d-49f5-420b-904e-a7d6b94ef8ed", 0, 0, "123 Oasis Ave", "Clearwater", "5dd806a4-1c9e-42c8-bb8a-628c4794cba0", "USER1@SERVICEMARKETPLACE.COM", false, "John", "Doe", true, null, "USER1@SERVICEMARKETPLACE.COM", "USER1@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "5555555555", false, "3b2607fe-a48f-4b32-8656-0af0a63d0110", "FL", false, "user1@servicemarketplace.com", "33755" },
                    { "a0f8a2c5-ea95-4bea-9771-2978d8b482b2", 0, 1, "300 N Betty Ln", "Clearwater", "07865a79-87b5-40fa-bbf1-19256aea5d27", "user5@servicemarketplace.com", false, "First3", "Last3", true, null, "USER5@SERVICEMARKETPLACE.COM", "USER5@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550003", false, "487973f5-d73f-4397-a460-661e40538c68", "FL", false, "user5@servicemarketplace.com", "33755" },
                    { "a1390974-c55f-45ff-9515-f50b7234fc60", 0, 1, "2600 N Missouri Ave", "Clearwater", "49057edd-9de4-4e63-a8fd-495b8f049533", "user28@servicemarketplace.com", false, "First26", "Last26", true, null, "USER28@SERVICEMARKETPLACE.COM", "USER28@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550026", false, "fb8345b7-b8b8-47cb-af7f-e0b0c72a8899", "FL", false, "user28@servicemarketplace.com", "33755" },
                    { "a2584660-c993-43ab-9221-335cefc214d0", 0, 1, "4400 Edgewood Ave", "Clearwater", "45b13e14-3ab0-45a0-a91d-3cd958b1a294", "user46@servicemarketplace.com", false, "First44", "Last44", true, null, "USER46@SERVICEMARKETPLACE.COM", "USER46@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550044", false, "4364b5a8-b61f-4038-a182-4cdbf0921921", "FL", false, "user46@servicemarketplace.com", "33755" },
                    { "aa0a14c5-9e3b-4922-a563-10832328c11e", 0, 1, "3800 Morningside Dr", "Clearwater", "e6fb7573-1876-4be2-bc03-678d98d64aac", "user40@servicemarketplace.com", false, "First38", "Last38", true, null, "USER40@SERVICEMARKETPLACE.COM", "USER40@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550038", false, "470c5ae5-9f25-45f2-ad98-b557c8addcae", "FL", false, "user40@servicemarketplace.com", "33755" },
                    { "aa8570b8-22d1-4a97-a219-c70c31f76cce", 0, 1, "3100 N Osceola Ave", "Clearwater", "fe7fd83b-9938-4daf-8c58-f62c85419854", "user33@servicemarketplace.com", false, "First31", "Last31", true, null, "USER33@SERVICEMARKETPLACE.COM", "USER33@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550031", false, "40f5a616-4123-42ab-9ae3-ebd33cef9488", "FL", false, "user33@servicemarketplace.com", "33755" },
                    { "ae14a643-e7b5-468e-99dd-4a3c21b3e733", 0, 1, "200 N Fort Harrison Ave", "Clearwater", "add6264a-89fc-40f4-92cc-a7410f6a8e10", "user4@servicemarketplace.com", false, "First2", "Last2", true, null, "USER4@SERVICEMARKETPLACE.COM", "USER4@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550002", false, "dd2c4111-ad30-47f2-9af2-d87753ecde71", "FL", false, "user4@servicemarketplace.com", "33755" },
                    { "b7567de0-04b9-4213-8ef9-bb85a37430a9", 0, 1, "2800 Palm Dr", "Clearwater", "06cdd88f-c702-4fcb-8a76-d963d7ceb531", "user30@servicemarketplace.com", false, "First28", "Last28", true, null, "USER30@SERVICEMARKETPLACE.COM", "USER30@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550028", false, "ee3571c8-f63f-4767-8779-c3b81a34d94f", "FL", false, "user30@servicemarketplace.com", "33755" },
                    { "bedd86e9-b01b-4b62-8ad7-eb0373202d52", 0, 1, "600 N Garden Ave", "Clearwater", "4520c4e0-b6e5-47cd-b846-be77146010e6", "user8@servicemarketplace.com", false, "First6", "Last6", true, null, "USER8@SERVICEMARKETPLACE.COM", "USER8@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550006", false, "6c340194-2a8a-4197-a6ab-ef545af74990", "FL", false, "user8@servicemarketplace.com", "33755" },
                    { "c654f5ef-8786-46bc-a33b-1c7ed11bbe5e", 0, 1, "4800 Palmetto St", "Clearwater", "a72f70da-7208-4b2d-8f8d-bc5acc53cde5", "user50@servicemarketplace.com", false, "First48", "Last48", true, null, "USER50@SERVICEMARKETPLACE.COM", "USER50@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550048", false, "75ee400b-04ef-47ef-8bfb-cfa9354b3d4a", "FL", false, "user50@servicemarketplace.com", "33755" },
                    { "ce4ed9b0-3266-444e-a4de-f6db81f1270c", 0, 1, "4000 Pinellas St", "Clearwater", "6b2a9d7e-83db-42ce-9970-63274ce1fe83", "user42@servicemarketplace.com", false, "First40", "Last40", true, null, "USER42@SERVICEMARKETPLACE.COM", "USER42@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550040", false, "c5b273d0-56db-4232-8e63-b5bcdb18fd5c", "FL", false, "user42@servicemarketplace.com", "33755" },
                    { "d3084200-2e45-4288-b748-0f171cec2154", 0, 1, "1400 N Martin Luther King Jr Ave", "Clearwater", "abb62faf-42ef-4ab2-aa4f-97fa7d0be077", "user16@servicemarketplace.com", false, "First14", "Last14", true, null, "USER16@SERVICEMARKETPLACE.COM", "USER16@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550014", false, "e4f8693e-f78d-48ff-9c53-a57ae7f9a341", "FL", false, "user16@servicemarketplace.com", "33755" },
                    { "d32cb07a-9a5f-41ef-b6ee-7b4626e8f8aa", 0, 1, "2300 N McMullen Booth Rd", "Clearwater", "afec4958-8f6c-4b98-822a-b9c83f35f32c", "user25@servicemarketplace.com", false, "First23", "Last23", true, null, "USER25@SERVICEMARKETPLACE.COM", "USER25@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550023", false, "da09c09e-e9e1-46ae-b748-f1a989b50e21", "FL", false, "user25@servicemarketplace.com", "33755" },
                    { "d50363bf-e181-427a-aaa8-5bc6bd57525b", 0, 1, "1300 Cleveland St", "Clearwater", "4eafbb6f-55ca-4507-8cf5-d07821dc1ca2", "user15@servicemarketplace.com", false, "First13", "Last13", true, null, "USER15@SERVICEMARKETPLACE.COM", "USER15@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550013", false, "4cfc48f2-a083-4153-a6c2-c7614156e165", "FL", false, "user15@servicemarketplace.com", "33755" },
                    { "d563bbd8-8b2a-4cd1-a023-42243d6d5005", 0, 1, "4200 N Garden Ave", "Clearwater", "68408aa7-97ce-47fa-b4e2-edf7ab12eb9b", "user44@servicemarketplace.com", false, "First42", "Last42", true, null, "USER44@SERVICEMARKETPLACE.COM", "USER44@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550042", false, "b5e0c688-5f41-46cd-b0c5-ab7eda6cea31", "FL", false, "user44@servicemarketplace.com", "33755" },
                    { "ded37907-2834-4d78-b789-99ffe887256f", 0, 1, "3200 Magnolia Dr", "Clearwater", "da80a00b-fa5d-42e8-a935-2b93537ec852", "user34@servicemarketplace.com", false, "First32", "Last32", true, null, "USER34@SERVICEMARKETPLACE.COM", "USER34@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550032", false, "369a72fd-02d5-408a-9af7-5854c06984ae", "FL", false, "user34@servicemarketplace.com", "33755" },
                    { "e257e491-ad96-4c03-9121-1ab77178545d", 0, 1, "2900 Grove St", "Clearwater", "ec27e188-2070-4d37-b5f8-7d14bf4598c1", "user31@servicemarketplace.com", false, "First29", "Last29", true, null, "USER31@SERVICEMARKETPLACE.COM", "USER31@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550029", false, "3d697131-0ab9-44ca-b7a2-67d94a4a823b", "FL", false, "user31@servicemarketplace.com", "33755" },
                    { "ec3935a8-3b4c-43b1-9762-047daf3d3c3b", 0, 1, "100 N Osceola Ave", "Clearwater", "9fd20b28-951c-462e-a8d8-c3ed71700bc6", "user3@servicemarketplace.com", false, "First1", "Last1", true, null, "USER3@SERVICEMARKETPLACE.COM", "USER3@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550001", false, "528bc945-420d-469c-b369-120032a23bb0", "FL", false, "user3@servicemarketplace.com", "33755" },
                    { "f00871f6-d67f-43e0-b680-1961ea2458f7", 0, 1, "5000 Greenbriar Blvd", "Clearwater", "4a3db486-5d73-4b89-8743-d81060857781", "user52@servicemarketplace.com", false, "First50", "Last50", true, null, "USER52@SERVICEMARKETPLACE.COM", "USER52@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550050", false, "83d9d20a-2880-402b-a9ef-4540eaee8cb5", "FL", false, "user52@servicemarketplace.com", "33755" },
                    { "f03ebda8-3c9b-4261-a363-d73cf7dcbf54", 0, 1, "1500 Douglas Ave", "Clearwater", "9564f79a-4b73-456a-af24-490d726ee047", "user17@servicemarketplace.com", false, "First15", "Last15", true, null, "USER17@SERVICEMARKETPLACE.COM", "USER17@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550015", false, "6a5c0519-535d-4735-b4bb-deb9086f348a", "FL", false, "user17@servicemarketplace.com", "33755" },
                    { "f3f73c04-f73a-44f3-bc0d-d3e6b4b60739", 0, 1, "700 N Myrtle Ave", "Clearwater", "95b424fa-3c27-4b84-9a41-039b0c137672", "user9@servicemarketplace.com", false, "First7", "Last7", true, null, "USER9@SERVICEMARKETPLACE.COM", "USER9@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550007", false, "51b5cfa0-a0f1-4f7e-9b06-7c32bc0d3117", "FL", false, "user9@servicemarketplace.com", "33755" },
                    { "fcd94e2f-c059-4ab0-9ba0-3e535c2b8617", 0, 1, "3500 Oak St", "Clearwater", "859e9553-c239-4aee-abd7-cd8fa473daa4", "user37@servicemarketplace.com", false, "First35", "Last35", true, null, "USER37@SERVICEMARKETPLACE.COM", "USER37@SERVICEMARKETPLACE.COM", "AQAAAAIAAYagAAAAEGFUa3HVeP4+S2/E32pkeZZMOUYO7iHDiB798julo60qLP4Z2DG7ihCHMSMijgCR7g==", "7275550035", false, "9e272dc8-a5ee-47b0-b728-88ed0b7cf140", "FL", false, "user37@servicemarketplace.com", "33755" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "Id", "Address_City", "Address_Coordinate", "Address_State", "Address_Street", "Address_Zipcode", "Description", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Clearwater", "", "FL", "100 N Osceola Ave", "33755", "Description for Sunshine Lawn Care", "Sunshine Lawn Care", "7275550001" },
                    { 2, "Clearwater", "", "FL", "200 N Fort Harrison Ave", "33755", "Description for Ocean Breeze Spa", "Ocean Breeze Spa", "7275550002" },
                    { 3, "Clearwater", "", "FL", "300 N Betty Ln", "33755", "Description for Gulf Coast Plumbing", "Gulf Coast Plumbing", "7275550003" },
                    { 4, "Clearwater", "", "FL", "400 N Highland Ave", "33755", "Description for Clearwater Auto Repair", "Clearwater Auto Repair", "7275550004" },
                    { 5, "Clearwater", "", "FL", "500 Eldridge St", "33755", "Description for Beachside Cafe", "Beachside Cafe", "7275550005" },
                    { 6, "Clearwater", "", "FL", "600 N Garden Ave", "33755", "Description for Harborview Dentistry", "Harborview Dentistry", "7275550006" },
                    { 7, "Clearwater", "", "FL", "700 N Myrtle Ave", "33755", "Description for Bayfront Accounting", "Bayfront Accounting", "7275550007" },
                    { 8, "Clearwater", "", "FL", "800 N Washington Ave", "33755", "Description for Seaside Yoga Studio", "Seaside Yoga Studio", "7275550008" },
                    { 9, "Clearwater", "", "FL", "900 Drew St", "33755", "Description for Tropical Landscaping", "Tropical Landscaping", "7275550009" },
                    { 10, "Clearwater", "", "FL", "1000 Palmetto St", "33755", "Description for Clearwater Electric", "Clearwater Electric", "7275550010" },
                    { 11, "Clearwater", "", "FL", "1100 Druid Rd", "33755", "Description for Island Pet Grooming", "Island Pet Grooming", "7275550011" },
                    { 12, "Clearwater", "", "FL", "1200 Jeffords St", "33755", "Description for Sunset Realty", "Sunset Realty", "7275550012" },
                    { 13, "Clearwater", "", "FL", "1300 Cleveland St", "33755", "Description for Palm Tree Services", "Palm Tree Services", "7275550013" },
                    { 14, "Clearwater", "", "FL", "1400 N Martin Luther King Jr Ave", "33755", "Description for Paradise Painting", "Paradise Painting", "7275550014" },
                    { 15, "Clearwater", "", "FL", "1500 Douglas Ave", "33755", "Description for Coastal Roofing", "Coastal Roofing", "7275550015" },
                    { 16, "Clearwater", "", "FL", "1600 Sunset Point Rd", "33755", "Description for Sandy Shores Marina", "Sandy Shores Marina", "7275550016" },
                    { 17, "Clearwater", "", "FL", "1700 N Keene Rd", "33755", "Description for Coral Reef Cleaning", "Coral Reef Cleaning", "7275550017" },
                    { 18, "Clearwater", "", "FL", "1800 N Lincoln Ave", "33755", "Description for Sunset Salon", "Sunset Salon", "7275550018" },
                    { 19, "Clearwater", "", "FL", "1900 S Martin Luther King Jr Ave", "33755", "Description for Tampa Bay Tech Support", "Tampa Bay Tech Support", "7275550019" },
                    { 20, "Clearwater", "", "FL", "2000 Glenwood Ave", "33755", "Description for Bay Area Fitness", "Bay Area Fitness", "7275550020" },
                    { 21, "Clearwater", "", "FL", "2100 Cherry St", "33755", "Description for Suncoast Pest Control", "Suncoast Pest Control", "7275550021" },
                    { 22, "Clearwater", "", "FL", "2200 Brentwood Dr", "33755", "Description for Beachside Bakery", "Beachside Bakery", "7275550022" },
                    { 23, "Clearwater", "", "FL", "2300 N McMullen Booth Rd", "33755", "Description for Bay Breeze HVAC", "Bay Breeze HVAC", "7275550023" },
                    { 24, "Clearwater", "", "FL", "2400 N Bayshore Blvd", "33755", "Description for Coastal Legal Services", "Coastal Legal Services", "7275550024" },
                    { 25, "Clearwater", "", "FL", "2500 N Lake Dr", "33755", "Description for Gulfview Tutoring", "Gulfview Tutoring", "7275550025" },
                    { 26, "Clearwater", "", "FL", "2600 N Missouri Ave", "33755", "Description for Sunshine Printing", "Sunshine Printing", "7275550026" },
                    { 27, "Clearwater", "", "FL", "2700 Overbrook Ave", "33755", "Description for Clearwater Chiropractic", "Clearwater Chiropractic", "7275550027" },
                    { 28, "Clearwater", "", "FL", "2800 Palm Dr", "33755", "Description for Sunset Landscaping", "Sunset Landscaping", "7275550028" },
                    { 29, "Clearwater", "", "FL", "2900 Grove St", "33755", "Description for Sunshine Automotive", "Sunshine Automotive", "7275550029" },
                    { 30, "Clearwater", "", "FL", "3000 Robin Hood Ln", "33755", "Description for Oceanfront Legal Services", "Oceanfront Legal Services", "7275550030" },
                    { 31, "Clearwater", "", "FL", "3100 N Osceola Ave", "33755", "Description for Beachside Bicycles", "Beachside Bicycles", "7275550031" },
                    { 32, "Clearwater", "", "FL", "3200 Magnolia Dr", "33755", "Description for Bay Area Movers", "Bay Area Movers", "7275550032" },
                    { 33, "Clearwater", "", "FL", "3300 Evergreen Ave", "33755", "Description for Sunshine Web Design", "Sunshine Web Design", "7275550033" },
                    { 34, "Clearwater", "", "FL", "3400 Fairmont St", "33755", "Description for Clearwater Financial Planning", "Clearwater Financial Planning", "7275550034" },
                    { 35, "Clearwater", "", "FL", "3500 Oak St", "33755", "Description for Tampa Bay Event Planning", "Tampa Bay Event Planning", "7275550035" },
                    { 36, "Clearwater", "", "FL", "3600 Sunset Dr", "33755", "Description for Coastal Veterinary Clinic", "Coastal Veterinary Clinic", "7275550036" },
                    { 37, "Clearwater", "", "FL", "3700 Lakeview Rd", "33755", "Description for Sunshine Insurance", "Sunshine Insurance", "7275550037" },
                    { 38, "Clearwater", "", "FL", "3800 Morningside Dr", "33755", "Description for Gulf Coast Home Repair", "Gulf Coast Home Repair", "7275550038" },
                    { 39, "Clearwater", "", "FL", "3900 N Osceola Ave", "33755", "Description for Sunset Photography", "Sunset Photography", "7275550039" },
                    { 40, "Clearwater", "", "FL", "4000 Pinellas St", "33755", "Description for Clearwater Window Cleaning", "Clearwater Window Cleaning", "7275550040" },
                    { 41, "Clearwater", "", "FL", "4100 Highland Dr", "33755", "Description for Beachside Florist", "Beachside Florist", "7275550041" },
                    { 42, "Clearwater", "", "FL", "4200 N Garden Ave", "33755", "Description for Sunshine Travel Agency", "Sunshine Travel Agency", "7275550042" },
                    { 43, "Clearwater", "", "FL", "4300 N Keene Rd", "33755", "Description for Bay Area Catering", "Bay Area Catering", "7275550043" },
                    { 44, "Clearwater", "", "FL", "4400 Edgewood Ave", "33755", "Description for Sunshine Daycare", "Sunshine Daycare", "7275550044" },
                    { 45, "Clearwater", "", "FL", "4500 Belcher Rd", "33755", "Description for Clearwater Dry Cleaning", "Clearwater Dry Cleaning", "7275550045" },
                    { 46, "Clearwater", "", "FL", "4600 Flagler Dr", "33755", "Description for Gulf Coast Fitness", "Gulf Coast Fitness", "7275550046" },
                    { 47, "Clearwater", "", "FL", "4700 Admiral Dr", "33755", "Description for Sunshine Tutoring", "Sunshine Tutoring", "7275550047" },
                    { 48, "Clearwater", "", "FL", "4800 Palmetto St", "33755", "Description for Clearwater Real Estate", "Clearwater Real Estate", "7275550048" },
                    { 49, "Clearwater", "", "FL", "4900 Sunset Point Rd", "33755", "Description for Tampa Bay Music Lessons", "Tampa Bay Music Lessons", "7275550049" },
                    { 50, "Clearwater", "", "FL", "5000 Greenbriar Blvd", "33755", "Description for Sunshine IT Services", "Sunshine IT Services", "7275550050" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BusinessId", "Description", "Duration", "Price", "Rating", "ServiceName" },
                values: new object[,]
                {
                    { 1, 1, "Description for Lawn Mowing", new TimeSpan(0, 1, 0, 0, 0), 55.0, 2.0, "Lawn Mowing" },
                    { 2, 2, "Description for Massage Therapy", new TimeSpan(0, 1, 0, 0, 0), 60.0, 3.0, "Massage Therapy" },
                    { 3, 3, "Description for Pipe Repair", new TimeSpan(0, 1, 0, 0, 0), 65.0, 4.0, "Pipe Repair" },
                    { 4, 4, "Description for Oil Change", new TimeSpan(0, 1, 0, 0, 0), 70.0, 5.0, "Oil Change" },
                    { 5, 5, "Description for Coffee and Pastries", new TimeSpan(0, 1, 0, 0, 0), 75.0, 1.0, "Coffee and Pastries" },
                    { 6, 6, "Description for Dental Cleaning", new TimeSpan(0, 1, 0, 0, 0), 80.0, 2.0, "Dental Cleaning" },
                    { 7, 7, "Description for Tax Preparation", new TimeSpan(0, 1, 0, 0, 0), 85.0, 3.0, "Tax Preparation" },
                    { 8, 8, "Description for Yoga Classes", new TimeSpan(0, 1, 0, 0, 0), 90.0, 4.0, "Yoga Classes" },
                    { 9, 9, "Description for Garden Maintenance", new TimeSpan(0, 1, 0, 0, 0), 95.0, 5.0, "Garden Maintenance" },
                    { 10, 10, "Description for Electrical Repair", new TimeSpan(0, 1, 0, 0, 0), 100.0, 1.0, "Electrical Repair" },
                    { 11, 11, "Description for Pet Grooming", new TimeSpan(0, 1, 0, 0, 0), 105.0, 2.0, "Pet Grooming" },
                    { 12, 12, "Description for Real Estate Services", new TimeSpan(0, 1, 0, 0, 0), 110.0, 3.0, "Real Estate Services" },
                    { 13, 13, "Description for Painting Services", new TimeSpan(0, 1, 0, 0, 0), 115.0, 4.0, "Painting Services" },
                    { 14, 14, "Description for Roof Repair", new TimeSpan(0, 1, 0, 0, 0), 120.0, 5.0, "Roof Repair" },
                    { 15, 15, "Description for Boat Docking", new TimeSpan(0, 1, 0, 0, 0), 125.0, 1.0, "Boat Docking" },
                    { 16, 16, "Description for House Cleaning", new TimeSpan(0, 1, 0, 0, 0), 130.0, 2.0, "House Cleaning" },
                    { 17, 17, "Description for Hair Styling", new TimeSpan(0, 1, 0, 0, 0), 135.0, 3.0, "Hair Styling" },
                    { 18, 18, "Description for IT Support", new TimeSpan(0, 1, 0, 0, 0), 140.0, 4.0, "IT Support" },
                    { 19, 19, "Description for Personal Training", new TimeSpan(0, 1, 0, 0, 0), 145.0, 5.0, "Personal Training" },
                    { 20, 20, "Description for Pest Control", new TimeSpan(0, 1, 0, 0, 0), 150.0, 1.0, "Pest Control" },
                    { 21, 21, "Description for Bakery Services", new TimeSpan(0, 1, 0, 0, 0), 155.0, 2.0, "Bakery Services" },
                    { 22, 22, "Description for HVAC Repair", new TimeSpan(0, 1, 0, 0, 0), 160.0, 3.0, "HVAC Repair" },
                    { 23, 23, "Description for Legal Consultation", new TimeSpan(0, 1, 0, 0, 0), 165.0, 4.0, "Legal Consultation" },
                    { 24, 24, "Description for Tutoring Services", new TimeSpan(0, 1, 0, 0, 0), 170.0, 5.0, "Tutoring Services" },
                    { 25, 25, "Description for Printing Services", new TimeSpan(0, 1, 0, 0, 0), 175.0, 1.0, "Printing Services" },
                    { 26, 26, "Description for Chiropractic Adjustment", new TimeSpan(0, 1, 0, 0, 0), 180.0, 2.0, "Chiropractic Adjustment" },
                    { 27, 27, "Description for Landscaping", new TimeSpan(0, 1, 0, 0, 0), 185.0, 3.0, "Landscaping" },
                    { 28, 28, "Description for Auto Repair", new TimeSpan(0, 1, 0, 0, 0), 190.0, 4.0, "Auto Repair" },
                    { 29, 29, "Description for Legal Services", new TimeSpan(0, 1, 0, 0, 0), 195.0, 5.0, "Legal Services" },
                    { 30, 30, "Description for Bicycle Repair", new TimeSpan(0, 1, 0, 0, 0), 200.0, 1.0, "Bicycle Repair" },
                    { 31, 31, "Description for Moving Services", new TimeSpan(0, 1, 0, 0, 0), 205.0, 2.0, "Moving Services" },
                    { 32, 32, "Description for Web Design", new TimeSpan(0, 1, 0, 0, 0), 210.0, 3.0, "Web Design" },
                    { 33, 33, "Description for Financial Planning", new TimeSpan(0, 1, 0, 0, 0), 215.0, 4.0, "Financial Planning" },
                    { 34, 34, "Description for Event Planning", new TimeSpan(0, 1, 0, 0, 0), 220.0, 5.0, "Event Planning" },
                    { 35, 35, "Description for Veterinary Services", new TimeSpan(0, 1, 0, 0, 0), 225.0, 1.0, "Veterinary Services" },
                    { 36, 36, "Description for Insurance Services", new TimeSpan(0, 1, 0, 0, 0), 230.0, 2.0, "Insurance Services" },
                    { 37, 37, "Description for Home Repair", new TimeSpan(0, 1, 0, 0, 0), 235.0, 3.0, "Home Repair" },
                    { 38, 38, "Description for Photography", new TimeSpan(0, 1, 0, 0, 0), 240.0, 4.0, "Photography" },
                    { 39, 39, "Description for Window Cleaning", new TimeSpan(0, 1, 0, 0, 0), 245.0, 5.0, "Window Cleaning" },
                    { 40, 40, "Description for Florist Services", new TimeSpan(0, 1, 0, 0, 0), 250.0, 1.0, "Florist Services" },
                    { 41, 41, "Description for Travel Planning", new TimeSpan(0, 1, 0, 0, 0), 255.0, 2.0, "Travel Planning" },
                    { 42, 42, "Description for Catering", new TimeSpan(0, 1, 0, 0, 0), 260.0, 3.0, "Catering" },
                    { 43, 43, "Description for Childcare", new TimeSpan(0, 1, 0, 0, 0), 265.0, 4.0, "Childcare" },
                    { 44, 44, "Description for Dry Cleaning", new TimeSpan(0, 1, 0, 0, 0), 270.0, 5.0, "Dry Cleaning" },
                    { 45, 45, "Description for Fitness Training", new TimeSpan(0, 1, 0, 0, 0), 275.0, 1.0, "Fitness Training" },
                    { 46, 46, "Description for Academic Tutoring", new TimeSpan(0, 1, 0, 0, 0), 280.0, 2.0, "Academic Tutoring" },
                    { 47, 47, "Description for Real Estate Consulting", new TimeSpan(0, 1, 0, 0, 0), 285.0, 3.0, "Real Estate Consulting" },
                    { 48, 48, "Description for Music Lessons", new TimeSpan(0, 1, 0, 0, 0), 290.0, 4.0, "Music Lessons" },
                    { 49, 49, "Description for IT Consulting", new TimeSpan(0, 1, 0, 0, 0), 295.0, 5.0, "IT Consulting" },
                    { 50, 50, "Description for Bicycle Repair", new TimeSpan(0, 1, 0, 0, 0), 300.0, 1.0, "Bicycle Repair" }
                });

            migrationBuilder.InsertData(
                table: "BusinessUsers",
                columns: new[] { "Id", "BusinessId", "IsAdmin", "UserId" },
                values: new object[,]
                {
                    { 1, 1, true, "ec3935a8-3b4c-43b1-9762-047daf3d3c3b" },
                    { 2, 2, true, "ae14a643-e7b5-468e-99dd-4a3c21b3e733" },
                    { 3, 3, true, "a0f8a2c5-ea95-4bea-9771-2978d8b482b2" },
                    { 4, 4, true, "2daae73f-67b6-432b-8be4-81b4a63050da" },
                    { 5, 5, true, "9968dd99-8b8f-4e12-a2f1-1ff4e89ad892" },
                    { 6, 6, true, "bedd86e9-b01b-4b62-8ad7-eb0373202d52" },
                    { 7, 7, true, "f3f73c04-f73a-44f3-bc0d-d3e6b4b60739" },
                    { 8, 8, true, "7462a972-6397-4a38-8ccb-92cc83ea99ad" },
                    { 9, 9, true, "25544a0b-7943-4ae2-900a-0c7813e48bef" },
                    { 10, 10, true, "52d49244-516c-478b-9420-33a25f081faf" },
                    { 11, 11, true, "439beb41-15f2-4d52-aa29-f0916c3ddce8" },
                    { 12, 12, true, "28a84cdb-2a65-4585-b8cb-7b153c26c599" },
                    { 13, 13, true, "d50363bf-e181-427a-aaa8-5bc6bd57525b" },
                    { 14, 14, true, "d3084200-2e45-4288-b748-0f171cec2154" },
                    { 15, 15, true, "f03ebda8-3c9b-4261-a363-d73cf7dcbf54" },
                    { 16, 16, true, "5604c0ca-3810-4f01-8933-8428ddfeff0a" },
                    { 17, 17, true, "8232fdf2-97c3-4fed-a1ef-523b173a573b" },
                    { 18, 18, true, "23784f5f-a390-4428-b6e7-c85b2c455701" },
                    { 19, 19, true, "8bd58ff3-bdba-4c0a-8c4e-9f38b89cd15a" },
                    { 20, 20, true, "4bb98165-51a1-4651-bc81-1c51865144e5" },
                    { 21, 21, true, "56c29cfc-e2b5-4167-b929-36a25eed778d" },
                    { 22, 22, true, "5d954119-7249-47d0-8cb4-7f3dd23d05a4" },
                    { 23, 23, true, "d32cb07a-9a5f-41ef-b6ee-7b4626e8f8aa" },
                    { 24, 24, true, "6c8dcb1e-5362-4567-ac7a-233d1e375994" },
                    { 25, 25, true, "4ca0f081-27c9-4ab7-938d-a2433a876f7f" },
                    { 26, 26, true, "a1390974-c55f-45ff-9515-f50b7234fc60" },
                    { 27, 27, true, "536d31be-56af-4a35-9e8e-03d5682236ac" },
                    { 28, 28, true, "b7567de0-04b9-4213-8ef9-bb85a37430a9" },
                    { 29, 29, true, "e257e491-ad96-4c03-9121-1ab77178545d" },
                    { 30, 30, true, "4affd071-5d78-477e-99ef-b7262557a1ef" },
                    { 31, 31, true, "aa8570b8-22d1-4a97-a219-c70c31f76cce" },
                    { 32, 32, true, "ded37907-2834-4d78-b789-99ffe887256f" },
                    { 33, 33, true, "7a715aec-b75f-4056-87d9-64c544b1c16d" },
                    { 34, 34, true, "3077005a-8b54-4c69-a286-8e6017f6de45" },
                    { 35, 35, true, "fcd94e2f-c059-4ab0-9ba0-3e535c2b8617" },
                    { 36, 36, true, "128e1ea9-166e-47d0-91e5-f80913c72cd2" },
                    { 37, 37, true, "4844e7a1-93f9-4ece-86a5-43fd4056d482" },
                    { 38, 38, true, "aa0a14c5-9e3b-4922-a563-10832328c11e" },
                    { 39, 39, true, "239111c2-b752-4666-b783-1ba66d8ceeaa" },
                    { 40, 40, true, "ce4ed9b0-3266-444e-a4de-f6db81f1270c" },
                    { 41, 41, true, "7ff3f0f3-44b0-45e5-9206-0d5141b303dc" },
                    { 42, 42, true, "d563bbd8-8b2a-4cd1-a023-42243d6d5005" },
                    { 43, 43, true, "950debab-5465-4ce3-b8bd-bfbcc21bed52" },
                    { 44, 44, true, "a2584660-c993-43ab-9221-335cefc214d0" },
                    { 45, 45, true, "7daae948-89a2-4865-be60-40631241beed" },
                    { 46, 46, true, "573a7747-0216-4a4e-a71e-6d0b11ae1d04" },
                    { 47, 47, true, "0be46e40-a432-490a-b0a9-7d66480a6949" },
                    { 48, 48, true, "c654f5ef-8786-46bc-a33b-1c7ed11bbe5e" },
                    { 49, 49, true, "26b3d11f-be4b-4f1d-834f-17335bbfc945" },
                    { 50, 50, true, "f00871f6-d67f-43e0-b680-1961ea2458f7" }
                });

            migrationBuilder.InsertData(
                table: "TimeSlot",
                columns: new[] { "Id", "EndTime", "ServiceId", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 6, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2002), 1, new DateTime(2024, 8, 6, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2002) },
                    { 2, new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2060), 1, new DateTime(2024, 8, 7, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2060) },
                    { 3, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2064), 1, new DateTime(2024, 8, 8, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2064) },
                    { 4, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2069), 1, new DateTime(2024, 8, 9, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2069) },
                    { 5, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2073), 1, new DateTime(2024, 8, 10, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2073) },
                    { 6, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2078), 1, new DateTime(2024, 8, 11, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2078) },
                    { 7, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2083), 1, new DateTime(2024, 8, 12, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2083) },
                    { 8, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2087), 1, new DateTime(2024, 8, 13, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2087) },
                    { 9, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2091), 1, new DateTime(2024, 8, 14, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2091) },
                    { 10, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2096), 1, new DateTime(2024, 8, 15, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(2096) },
                    { 11, new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2127), 2, new DateTime(2024, 8, 6, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2127) },
                    { 12, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2131), 2, new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2131) },
                    { 13, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2135), 2, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2135) },
                    { 14, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2139), 2, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2139) },
                    { 15, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2143), 2, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2143) },
                    { 16, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2147), 2, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2147) },
                    { 17, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2151), 2, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2151) },
                    { 18, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2156), 2, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2156) },
                    { 19, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2160), 2, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2160) },
                    { 20, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2164), 2, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(2164) },
                    { 21, new DateTime(2024, 8, 6, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2228), 3, new DateTime(2024, 8, 6, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2228) },
                    { 22, new DateTime(2024, 8, 7, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2232), 3, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2232) },
                    { 23, new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2237), 3, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2237) },
                    { 24, new DateTime(2024, 8, 9, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2241), 3, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2241) },
                    { 25, new DateTime(2024, 8, 10, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2245), 3, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2245) },
                    { 26, new DateTime(2024, 8, 11, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2249), 3, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2249) },
                    { 27, new DateTime(2024, 8, 12, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2254), 3, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2254) },
                    { 28, new DateTime(2024, 8, 13, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2258), 3, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2258) },
                    { 29, new DateTime(2024, 8, 14, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2262), 3, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2262) },
                    { 30, new DateTime(2024, 8, 15, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2266), 3, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(2266) },
                    { 31, new DateTime(2024, 8, 6, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2293), 4, new DateTime(2024, 8, 6, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2293) },
                    { 32, new DateTime(2024, 8, 7, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2297), 4, new DateTime(2024, 8, 7, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2297) },
                    { 33, new DateTime(2024, 8, 8, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2301), 4, new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2301) },
                    { 34, new DateTime(2024, 8, 9, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2307), 4, new DateTime(2024, 8, 9, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2307) },
                    { 35, new DateTime(2024, 8, 10, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2311), 4, new DateTime(2024, 8, 10, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2311) },
                    { 36, new DateTime(2024, 8, 11, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2315), 4, new DateTime(2024, 8, 11, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2315) },
                    { 37, new DateTime(2024, 8, 12, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2319), 4, new DateTime(2024, 8, 12, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2319) },
                    { 38, new DateTime(2024, 8, 13, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2323), 4, new DateTime(2024, 8, 13, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2323) },
                    { 39, new DateTime(2024, 8, 14, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2327), 4, new DateTime(2024, 8, 14, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2327) },
                    { 40, new DateTime(2024, 8, 15, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2331), 4, new DateTime(2024, 8, 15, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(2331) },
                    { 41, new DateTime(2024, 8, 6, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2359), 5, new DateTime(2024, 8, 6, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2359) },
                    { 42, new DateTime(2024, 8, 7, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2364), 5, new DateTime(2024, 8, 7, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2364) },
                    { 43, new DateTime(2024, 8, 8, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2368), 5, new DateTime(2024, 8, 8, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2368) },
                    { 44, new DateTime(2024, 8, 9, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2372), 5, new DateTime(2024, 8, 9, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2372) },
                    { 45, new DateTime(2024, 8, 10, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2376), 5, new DateTime(2024, 8, 10, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2376) },
                    { 46, new DateTime(2024, 8, 11, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2380), 5, new DateTime(2024, 8, 11, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2380) },
                    { 47, new DateTime(2024, 8, 12, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2384), 5, new DateTime(2024, 8, 12, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2384) },
                    { 48, new DateTime(2024, 8, 13, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2388), 5, new DateTime(2024, 8, 13, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2388) },
                    { 49, new DateTime(2024, 8, 14, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2392), 5, new DateTime(2024, 8, 14, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2392) },
                    { 50, new DateTime(2024, 8, 15, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2396), 5, new DateTime(2024, 8, 15, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(2396) },
                    { 51, new DateTime(2024, 8, 6, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2423), 6, new DateTime(2024, 8, 6, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2423) },
                    { 52, new DateTime(2024, 8, 7, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2427), 6, new DateTime(2024, 8, 7, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2427) },
                    { 53, new DateTime(2024, 8, 8, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2431), 6, new DateTime(2024, 8, 8, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2431) },
                    { 54, new DateTime(2024, 8, 9, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2435), 6, new DateTime(2024, 8, 9, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2435) },
                    { 55, new DateTime(2024, 8, 10, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2439), 6, new DateTime(2024, 8, 10, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2439) },
                    { 56, new DateTime(2024, 8, 11, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2443), 6, new DateTime(2024, 8, 11, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2443) },
                    { 57, new DateTime(2024, 8, 12, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2448), 6, new DateTime(2024, 8, 12, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2448) },
                    { 58, new DateTime(2024, 8, 13, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2452), 6, new DateTime(2024, 8, 13, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2452) },
                    { 59, new DateTime(2024, 8, 14, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2456), 6, new DateTime(2024, 8, 14, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2456) },
                    { 60, new DateTime(2024, 8, 15, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2460), 6, new DateTime(2024, 8, 15, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(2460) },
                    { 61, new DateTime(2024, 8, 6, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2509), 7, new DateTime(2024, 8, 6, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2509) },
                    { 62, new DateTime(2024, 8, 7, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2513), 7, new DateTime(2024, 8, 7, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2513) },
                    { 63, new DateTime(2024, 8, 8, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2518), 7, new DateTime(2024, 8, 8, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2518) },
                    { 64, new DateTime(2024, 8, 9, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2522), 7, new DateTime(2024, 8, 9, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2522) },
                    { 65, new DateTime(2024, 8, 10, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2526), 7, new DateTime(2024, 8, 10, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2526) },
                    { 66, new DateTime(2024, 8, 11, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2531), 7, new DateTime(2024, 8, 11, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2531) },
                    { 67, new DateTime(2024, 8, 12, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2535), 7, new DateTime(2024, 8, 12, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2535) },
                    { 68, new DateTime(2024, 8, 13, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2539), 7, new DateTime(2024, 8, 13, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2539) },
                    { 69, new DateTime(2024, 8, 14, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2543), 7, new DateTime(2024, 8, 14, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2543) },
                    { 70, new DateTime(2024, 8, 15, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2548), 7, new DateTime(2024, 8, 15, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(2548) },
                    { 71, new DateTime(2024, 8, 6, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2575), 8, new DateTime(2024, 8, 6, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2575) },
                    { 72, new DateTime(2024, 8, 7, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2580), 8, new DateTime(2024, 8, 7, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2580) },
                    { 73, new DateTime(2024, 8, 8, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2584), 8, new DateTime(2024, 8, 8, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2584) },
                    { 74, new DateTime(2024, 8, 9, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2588), 8, new DateTime(2024, 8, 9, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2588) },
                    { 75, new DateTime(2024, 8, 10, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2592), 8, new DateTime(2024, 8, 10, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2592) },
                    { 76, new DateTime(2024, 8, 11, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2596), 8, new DateTime(2024, 8, 11, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2596) },
                    { 77, new DateTime(2024, 8, 12, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2600), 8, new DateTime(2024, 8, 12, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2600) },
                    { 78, new DateTime(2024, 8, 13, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2604), 8, new DateTime(2024, 8, 13, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2604) },
                    { 79, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2608), 8, new DateTime(2024, 8, 14, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2608) },
                    { 80, new DateTime(2024, 8, 15, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2612), 8, new DateTime(2024, 8, 15, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(2612) },
                    { 81, new DateTime(2024, 8, 6, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2639), 9, new DateTime(2024, 8, 6, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2639) },
                    { 82, new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2644), 9, new DateTime(2024, 8, 7, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2644) },
                    { 83, new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2648), 9, new DateTime(2024, 8, 8, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2648) },
                    { 84, new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2652), 9, new DateTime(2024, 8, 9, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2652) },
                    { 85, new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2656), 9, new DateTime(2024, 8, 10, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2656) },
                    { 86, new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2660), 9, new DateTime(2024, 8, 11, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2660) },
                    { 87, new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2664), 9, new DateTime(2024, 8, 12, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2664) },
                    { 88, new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2668), 9, new DateTime(2024, 8, 13, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2668) },
                    { 89, new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2672), 9, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2672) },
                    { 90, new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2676), 9, new DateTime(2024, 8, 15, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(2676) },
                    { 91, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2728), 10, new DateTime(2024, 8, 6, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2728) },
                    { 92, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2732), 10, new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2732) },
                    { 93, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2736), 10, new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2736) },
                    { 94, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2741), 10, new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2741) },
                    { 95, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2745), 10, new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2745) },
                    { 96, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2749), 10, new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2749) },
                    { 97, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2753), 10, new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2753) },
                    { 98, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2757), 10, new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2757) },
                    { 99, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2761), 10, new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2761) },
                    { 100, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2765), 10, new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(2765) },
                    { 101, new DateTime(2024, 8, 7, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2791), 11, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2791) },
                    { 102, new DateTime(2024, 8, 8, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2796), 11, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2796) },
                    { 103, new DateTime(2024, 8, 9, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2800), 11, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2800) },
                    { 104, new DateTime(2024, 8, 10, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2804), 11, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2804) },
                    { 105, new DateTime(2024, 8, 11, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2808), 11, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2808) },
                    { 106, new DateTime(2024, 8, 12, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2813), 11, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2813) },
                    { 107, new DateTime(2024, 8, 13, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2817), 11, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2817) },
                    { 108, new DateTime(2024, 8, 14, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2821), 11, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2821) },
                    { 109, new DateTime(2024, 8, 15, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2825), 11, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2825) },
                    { 110, new DateTime(2024, 8, 16, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2829), 11, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(2829) },
                    { 111, new DateTime(2024, 8, 7, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2855), 12, new DateTime(2024, 8, 7, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2855) },
                    { 112, new DateTime(2024, 8, 8, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2859), 12, new DateTime(2024, 8, 8, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2859) },
                    { 113, new DateTime(2024, 8, 9, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2863), 12, new DateTime(2024, 8, 9, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2863) },
                    { 114, new DateTime(2024, 8, 10, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2867), 12, new DateTime(2024, 8, 10, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2867) },
                    { 115, new DateTime(2024, 8, 11, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2871), 12, new DateTime(2024, 8, 11, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2871) },
                    { 116, new DateTime(2024, 8, 12, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2875), 12, new DateTime(2024, 8, 12, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2875) },
                    { 117, new DateTime(2024, 8, 13, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2879), 12, new DateTime(2024, 8, 13, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2879) },
                    { 118, new DateTime(2024, 8, 14, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2884), 12, new DateTime(2024, 8, 14, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2884) },
                    { 119, new DateTime(2024, 8, 15, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2888), 12, new DateTime(2024, 8, 15, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2888) },
                    { 120, new DateTime(2024, 8, 16, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2892), 12, new DateTime(2024, 8, 16, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(2892) },
                    { 121, new DateTime(2024, 8, 7, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2915), 13, new DateTime(2024, 8, 7, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2915) },
                    { 122, new DateTime(2024, 8, 8, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2919), 13, new DateTime(2024, 8, 8, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2919) },
                    { 123, new DateTime(2024, 8, 9, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2924), 13, new DateTime(2024, 8, 9, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2924) },
                    { 124, new DateTime(2024, 8, 10, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2928), 13, new DateTime(2024, 8, 10, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2928) },
                    { 125, new DateTime(2024, 8, 11, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2932), 13, new DateTime(2024, 8, 11, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2932) },
                    { 126, new DateTime(2024, 8, 12, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2936), 13, new DateTime(2024, 8, 12, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2936) },
                    { 127, new DateTime(2024, 8, 13, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2940), 13, new DateTime(2024, 8, 13, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2940) },
                    { 128, new DateTime(2024, 8, 14, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2944), 13, new DateTime(2024, 8, 14, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2944) },
                    { 129, new DateTime(2024, 8, 15, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2948), 13, new DateTime(2024, 8, 15, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2948) },
                    { 130, new DateTime(2024, 8, 16, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(2976), 13, new DateTime(2024, 8, 16, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(2976) },
                    { 131, new DateTime(2024, 8, 7, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3003), 14, new DateTime(2024, 8, 7, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3003) },
                    { 132, new DateTime(2024, 8, 8, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3007), 14, new DateTime(2024, 8, 8, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3007) },
                    { 133, new DateTime(2024, 8, 9, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3011), 14, new DateTime(2024, 8, 9, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3011) },
                    { 134, new DateTime(2024, 8, 10, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3015), 14, new DateTime(2024, 8, 10, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3015) },
                    { 135, new DateTime(2024, 8, 11, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3020), 14, new DateTime(2024, 8, 11, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3020) },
                    { 136, new DateTime(2024, 8, 12, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3024), 14, new DateTime(2024, 8, 12, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3024) },
                    { 137, new DateTime(2024, 8, 13, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3028), 14, new DateTime(2024, 8, 13, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3028) },
                    { 138, new DateTime(2024, 8, 14, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3032), 14, new DateTime(2024, 8, 14, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3032) },
                    { 139, new DateTime(2024, 8, 15, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3036), 14, new DateTime(2024, 8, 15, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3036) },
                    { 140, new DateTime(2024, 8, 16, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3040), 14, new DateTime(2024, 8, 16, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(3040) },
                    { 141, new DateTime(2024, 8, 7, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3065), 15, new DateTime(2024, 8, 7, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3065) },
                    { 142, new DateTime(2024, 8, 8, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3069), 15, new DateTime(2024, 8, 8, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3069) },
                    { 143, new DateTime(2024, 8, 9, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3073), 15, new DateTime(2024, 8, 9, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3073) },
                    { 144, new DateTime(2024, 8, 10, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3077), 15, new DateTime(2024, 8, 10, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3077) },
                    { 145, new DateTime(2024, 8, 11, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3081), 15, new DateTime(2024, 8, 11, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3081) },
                    { 146, new DateTime(2024, 8, 12, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3085), 15, new DateTime(2024, 8, 12, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3085) },
                    { 147, new DateTime(2024, 8, 13, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3090), 15, new DateTime(2024, 8, 13, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3090) },
                    { 148, new DateTime(2024, 8, 14, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3094), 15, new DateTime(2024, 8, 14, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3094) },
                    { 149, new DateTime(2024, 8, 15, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3098), 15, new DateTime(2024, 8, 15, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3098) },
                    { 150, new DateTime(2024, 8, 16, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3102), 15, new DateTime(2024, 8, 16, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(3102) },
                    { 151, new DateTime(2024, 8, 7, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3127), 16, new DateTime(2024, 8, 7, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3127) },
                    { 152, new DateTime(2024, 8, 8, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3132), 16, new DateTime(2024, 8, 8, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3132) },
                    { 153, new DateTime(2024, 8, 9, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3136), 16, new DateTime(2024, 8, 9, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3136) },
                    { 154, new DateTime(2024, 8, 10, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3140), 16, new DateTime(2024, 8, 10, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3140) },
                    { 155, new DateTime(2024, 8, 11, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3144), 16, new DateTime(2024, 8, 11, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3144) },
                    { 156, new DateTime(2024, 8, 12, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3148), 16, new DateTime(2024, 8, 12, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3148) },
                    { 157, new DateTime(2024, 8, 13, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3152), 16, new DateTime(2024, 8, 13, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3152) },
                    { 158, new DateTime(2024, 8, 14, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3156), 16, new DateTime(2024, 8, 14, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3156) },
                    { 159, new DateTime(2024, 8, 15, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3160), 16, new DateTime(2024, 8, 15, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3160) },
                    { 160, new DateTime(2024, 8, 16, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3164), 16, new DateTime(2024, 8, 16, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(3164) },
                    { 161, new DateTime(2024, 8, 7, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3212), 17, new DateTime(2024, 8, 7, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3212) },
                    { 162, new DateTime(2024, 8, 8, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3217), 17, new DateTime(2024, 8, 8, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3217) },
                    { 163, new DateTime(2024, 8, 9, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3221), 17, new DateTime(2024, 8, 9, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3221) },
                    { 164, new DateTime(2024, 8, 10, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3225), 17, new DateTime(2024, 8, 10, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3225) },
                    { 165, new DateTime(2024, 8, 11, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3230), 17, new DateTime(2024, 8, 11, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3230) },
                    { 166, new DateTime(2024, 8, 12, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3234), 17, new DateTime(2024, 8, 12, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3234) },
                    { 167, new DateTime(2024, 8, 13, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3238), 17, new DateTime(2024, 8, 13, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3238) },
                    { 168, new DateTime(2024, 8, 14, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3242), 17, new DateTime(2024, 8, 14, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3242) },
                    { 169, new DateTime(2024, 8, 15, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3246), 17, new DateTime(2024, 8, 15, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3246) },
                    { 170, new DateTime(2024, 8, 16, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3250), 17, new DateTime(2024, 8, 16, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(3250) },
                    { 171, new DateTime(2024, 8, 7, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3277), 18, new DateTime(2024, 8, 7, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3277) },
                    { 172, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3282), 18, new DateTime(2024, 8, 8, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3282) },
                    { 173, new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3286), 18, new DateTime(2024, 8, 9, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3286) },
                    { 174, new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3290), 18, new DateTime(2024, 8, 10, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3290) },
                    { 175, new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3294), 18, new DateTime(2024, 8, 11, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3294) },
                    { 176, new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3298), 18, new DateTime(2024, 8, 12, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3298) },
                    { 177, new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3302), 18, new DateTime(2024, 8, 13, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3302) },
                    { 178, new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3306), 18, new DateTime(2024, 8, 14, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3306) },
                    { 179, new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3310), 18, new DateTime(2024, 8, 15, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3310) },
                    { 180, new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3314), 18, new DateTime(2024, 8, 16, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(3314) },
                    { 181, new DateTime(2024, 8, 7, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3340), 19, new DateTime(2024, 8, 7, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3340) },
                    { 182, new DateTime(2024, 8, 8, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3344), 19, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3344) },
                    { 183, new DateTime(2024, 8, 9, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3348), 19, new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3348) },
                    { 184, new DateTime(2024, 8, 10, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3352), 19, new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3352) },
                    { 185, new DateTime(2024, 8, 11, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3356), 19, new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3356) },
                    { 186, new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3360), 19, new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3360) },
                    { 187, new DateTime(2024, 8, 13, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3365), 19, new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3365) },
                    { 188, new DateTime(2024, 8, 14, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3369), 19, new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3369) },
                    { 189, new DateTime(2024, 8, 15, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3373), 19, new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3373) },
                    { 190, new DateTime(2024, 8, 16, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3377), 19, new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(3377) },
                    { 191, new DateTime(2024, 8, 7, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3403), 20, new DateTime(2024, 8, 7, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3403) },
                    { 192, new DateTime(2024, 8, 8, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3408), 20, new DateTime(2024, 8, 8, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3408) },
                    { 193, new DateTime(2024, 8, 9, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3412), 20, new DateTime(2024, 8, 9, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3412) },
                    { 194, new DateTime(2024, 8, 10, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3416), 20, new DateTime(2024, 8, 10, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3416) },
                    { 195, new DateTime(2024, 8, 11, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3420), 20, new DateTime(2024, 8, 11, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3420) },
                    { 196, new DateTime(2024, 8, 12, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3424), 20, new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3424) },
                    { 197, new DateTime(2024, 8, 13, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3428), 20, new DateTime(2024, 8, 13, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3428) },
                    { 198, new DateTime(2024, 8, 14, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3432), 20, new DateTime(2024, 8, 14, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3432) },
                    { 199, new DateTime(2024, 8, 15, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3436), 20, new DateTime(2024, 8, 15, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3436) },
                    { 200, new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3440), 20, new DateTime(2024, 8, 16, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(3440) },
                    { 201, new DateTime(2024, 8, 7, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3489), 21, new DateTime(2024, 8, 7, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3489) },
                    { 202, new DateTime(2024, 8, 8, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3494), 21, new DateTime(2024, 8, 8, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3494) },
                    { 203, new DateTime(2024, 8, 9, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3498), 21, new DateTime(2024, 8, 9, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3498) },
                    { 204, new DateTime(2024, 8, 10, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3502), 21, new DateTime(2024, 8, 10, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3502) },
                    { 205, new DateTime(2024, 8, 11, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3507), 21, new DateTime(2024, 8, 11, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3507) },
                    { 206, new DateTime(2024, 8, 12, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3511), 21, new DateTime(2024, 8, 12, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3511) },
                    { 207, new DateTime(2024, 8, 13, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3515), 21, new DateTime(2024, 8, 13, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3515) },
                    { 208, new DateTime(2024, 8, 14, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3519), 21, new DateTime(2024, 8, 14, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3519) },
                    { 209, new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3524), 21, new DateTime(2024, 8, 15, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3524) },
                    { 210, new DateTime(2024, 8, 16, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3528), 21, new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(3528) },
                    { 211, new DateTime(2024, 8, 7, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3554), 22, new DateTime(2024, 8, 7, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3554) },
                    { 212, new DateTime(2024, 8, 8, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3559), 22, new DateTime(2024, 8, 8, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3559) },
                    { 213, new DateTime(2024, 8, 9, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3563), 22, new DateTime(2024, 8, 9, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3563) },
                    { 214, new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3567), 22, new DateTime(2024, 8, 10, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3567) },
                    { 215, new DateTime(2024, 8, 11, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3571), 22, new DateTime(2024, 8, 11, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3571) },
                    { 216, new DateTime(2024, 8, 12, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3575), 22, new DateTime(2024, 8, 12, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3575) },
                    { 217, new DateTime(2024, 8, 13, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3579), 22, new DateTime(2024, 8, 13, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3579) },
                    { 218, new DateTime(2024, 8, 14, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3583), 22, new DateTime(2024, 8, 14, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3583) },
                    { 219, new DateTime(2024, 8, 15, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3587), 22, new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3587) },
                    { 220, new DateTime(2024, 8, 16, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3591), 22, new DateTime(2024, 8, 16, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(3591) },
                    { 221, new DateTime(2024, 8, 7, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3615), 23, new DateTime(2024, 8, 7, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3615) },
                    { 222, new DateTime(2024, 8, 8, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3619), 23, new DateTime(2024, 8, 8, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3619) },
                    { 223, new DateTime(2024, 8, 9, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3623), 23, new DateTime(2024, 8, 9, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3623) },
                    { 224, new DateTime(2024, 8, 10, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3627), 23, new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3627) },
                    { 225, new DateTime(2024, 8, 11, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3631), 23, new DateTime(2024, 8, 11, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3631) },
                    { 226, new DateTime(2024, 8, 12, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3635), 23, new DateTime(2024, 8, 12, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3635) },
                    { 227, new DateTime(2024, 8, 13, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3639), 23, new DateTime(2024, 8, 13, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3639) },
                    { 228, new DateTime(2024, 8, 14, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3643), 23, new DateTime(2024, 8, 14, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3643) },
                    { 229, new DateTime(2024, 8, 15, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3647), 23, new DateTime(2024, 8, 15, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3647) },
                    { 230, new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3651), 23, new DateTime(2024, 8, 16, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(3651) },
                    { 231, new DateTime(2024, 8, 7, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3679), 24, new DateTime(2024, 8, 7, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3679) },
                    { 232, new DateTime(2024, 8, 8, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3683), 24, new DateTime(2024, 8, 8, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3683) },
                    { 233, new DateTime(2024, 8, 9, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3687), 24, new DateTime(2024, 8, 9, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3687) },
                    { 234, new DateTime(2024, 8, 10, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3691), 24, new DateTime(2024, 8, 10, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3691) },
                    { 235, new DateTime(2024, 8, 11, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3695), 24, new DateTime(2024, 8, 11, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3695) },
                    { 236, new DateTime(2024, 8, 12, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3699), 24, new DateTime(2024, 8, 12, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3699) },
                    { 237, new DateTime(2024, 8, 13, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3703), 24, new DateTime(2024, 8, 13, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3703) },
                    { 238, new DateTime(2024, 8, 14, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3707), 24, new DateTime(2024, 8, 14, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3707) },
                    { 239, new DateTime(2024, 8, 15, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3711), 24, new DateTime(2024, 8, 15, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3711) },
                    { 240, new DateTime(2024, 8, 16, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3715), 24, new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(3715) },
                    { 241, new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3738), 25, new DateTime(2024, 8, 7, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3738) },
                    { 242, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3743), 25, new DateTime(2024, 8, 8, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3743) },
                    { 243, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3747), 25, new DateTime(2024, 8, 9, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3747) },
                    { 244, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3751), 25, new DateTime(2024, 8, 10, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3751) },
                    { 245, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3755), 25, new DateTime(2024, 8, 11, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3755) },
                    { 246, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3759), 25, new DateTime(2024, 8, 12, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3759) },
                    { 247, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3778), 25, new DateTime(2024, 8, 13, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3778) },
                    { 248, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3783), 25, new DateTime(2024, 8, 14, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3783) },
                    { 249, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3787), 25, new DateTime(2024, 8, 15, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3787) },
                    { 250, new DateTime(2024, 8, 16, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3791), 25, new DateTime(2024, 8, 16, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(3791) },
                    { 251, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3817), 26, new DateTime(2024, 8, 7, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3817) },
                    { 252, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3821), 26, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3821) },
                    { 253, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3825), 26, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3825) },
                    { 254, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3830), 26, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3830) },
                    { 255, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3834), 26, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3834) },
                    { 256, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3838), 26, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3838) },
                    { 257, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3842), 26, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3842) },
                    { 258, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3848), 26, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3848) },
                    { 259, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3852), 26, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3852) },
                    { 260, new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3856), 26, new DateTime(2024, 8, 16, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(3856) },
                    { 261, new DateTime(2024, 8, 7, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3880), 27, new DateTime(2024, 8, 7, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3880) },
                    { 262, new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3884), 27, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3884) },
                    { 263, new DateTime(2024, 8, 9, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3888), 27, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3888) },
                    { 264, new DateTime(2024, 8, 10, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3892), 27, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3892) },
                    { 265, new DateTime(2024, 8, 11, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3896), 27, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3896) },
                    { 266, new DateTime(2024, 8, 12, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3900), 27, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3900) },
                    { 267, new DateTime(2024, 8, 13, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3934), 27, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3934) },
                    { 268, new DateTime(2024, 8, 14, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3938), 27, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3938) },
                    { 269, new DateTime(2024, 8, 15, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3942), 27, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3942) },
                    { 270, new DateTime(2024, 8, 16, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3947), 27, new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(3947) },
                    { 271, new DateTime(2024, 8, 7, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3973), 28, new DateTime(2024, 8, 7, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3973) },
                    { 272, new DateTime(2024, 8, 8, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3978), 28, new DateTime(2024, 8, 8, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3978) },
                    { 273, new DateTime(2024, 8, 9, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3982), 28, new DateTime(2024, 8, 9, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3982) },
                    { 274, new DateTime(2024, 8, 10, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3986), 28, new DateTime(2024, 8, 10, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3986) },
                    { 275, new DateTime(2024, 8, 11, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3990), 28, new DateTime(2024, 8, 11, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3990) },
                    { 276, new DateTime(2024, 8, 12, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3994), 28, new DateTime(2024, 8, 12, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3994) },
                    { 277, new DateTime(2024, 8, 13, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(3998), 28, new DateTime(2024, 8, 13, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(3998) },
                    { 278, new DateTime(2024, 8, 14, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4002), 28, new DateTime(2024, 8, 14, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(4002) },
                    { 279, new DateTime(2024, 8, 15, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4006), 28, new DateTime(2024, 8, 15, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(4006) },
                    { 280, new DateTime(2024, 8, 16, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4010), 28, new DateTime(2024, 8, 16, 17, 0, 0, 0, DateTimeKind.Local).AddTicks(4010) },
                    { 281, new DateTime(2024, 8, 7, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4034), 29, new DateTime(2024, 8, 7, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4034) },
                    { 282, new DateTime(2024, 8, 8, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4039), 29, new DateTime(2024, 8, 8, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4039) },
                    { 283, new DateTime(2024, 8, 9, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4043), 29, new DateTime(2024, 8, 9, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4043) },
                    { 284, new DateTime(2024, 8, 10, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4047), 29, new DateTime(2024, 8, 10, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4047) },
                    { 285, new DateTime(2024, 8, 11, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4051), 29, new DateTime(2024, 8, 11, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4051) },
                    { 286, new DateTime(2024, 8, 12, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4055), 29, new DateTime(2024, 8, 12, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4055) },
                    { 287, new DateTime(2024, 8, 13, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4059), 29, new DateTime(2024, 8, 13, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4059) },
                    { 288, new DateTime(2024, 8, 14, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4063), 29, new DateTime(2024, 8, 14, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4063) },
                    { 289, new DateTime(2024, 8, 15, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4067), 29, new DateTime(2024, 8, 15, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4067) },
                    { 290, new DateTime(2024, 8, 16, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4071), 29, new DateTime(2024, 8, 16, 18, 0, 0, 0, DateTimeKind.Local).AddTicks(4071) },
                    { 291, new DateTime(2024, 8, 7, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4097), 30, new DateTime(2024, 8, 7, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4097) },
                    { 292, new DateTime(2024, 8, 8, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4102), 30, new DateTime(2024, 8, 8, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4102) },
                    { 293, new DateTime(2024, 8, 9, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4106), 30, new DateTime(2024, 8, 9, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4106) },
                    { 294, new DateTime(2024, 8, 10, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4110), 30, new DateTime(2024, 8, 10, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4110) },
                    { 295, new DateTime(2024, 8, 11, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4114), 30, new DateTime(2024, 8, 11, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4114) },
                    { 296, new DateTime(2024, 8, 12, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4118), 30, new DateTime(2024, 8, 12, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4118) },
                    { 297, new DateTime(2024, 8, 13, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4122), 30, new DateTime(2024, 8, 13, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4122) },
                    { 298, new DateTime(2024, 8, 14, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4126), 30, new DateTime(2024, 8, 14, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4126) },
                    { 299, new DateTime(2024, 8, 15, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4130), 30, new DateTime(2024, 8, 15, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4130) },
                    { 300, new DateTime(2024, 8, 16, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4134), 30, new DateTime(2024, 8, 16, 19, 0, 0, 0, DateTimeKind.Local).AddTicks(4134) },
                    { 301, new DateTime(2024, 8, 7, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4159), 31, new DateTime(2024, 8, 7, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4159) },
                    { 302, new DateTime(2024, 8, 8, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4163), 31, new DateTime(2024, 8, 8, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4163) },
                    { 303, new DateTime(2024, 8, 9, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4168), 31, new DateTime(2024, 8, 9, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4168) },
                    { 304, new DateTime(2024, 8, 10, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4172), 31, new DateTime(2024, 8, 10, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4172) },
                    { 305, new DateTime(2024, 8, 11, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4176), 31, new DateTime(2024, 8, 11, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4176) },
                    { 306, new DateTime(2024, 8, 12, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4210), 31, new DateTime(2024, 8, 12, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4210) },
                    { 307, new DateTime(2024, 8, 13, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4215), 31, new DateTime(2024, 8, 13, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4215) },
                    { 308, new DateTime(2024, 8, 14, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4219), 31, new DateTime(2024, 8, 14, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4219) },
                    { 309, new DateTime(2024, 8, 15, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4224), 31, new DateTime(2024, 8, 15, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4224) },
                    { 310, new DateTime(2024, 8, 16, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4228), 31, new DateTime(2024, 8, 16, 20, 0, 0, 0, DateTimeKind.Local).AddTicks(4228) },
                    { 311, new DateTime(2024, 8, 7, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4253), 32, new DateTime(2024, 8, 7, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4253) },
                    { 312, new DateTime(2024, 8, 8, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4258), 32, new DateTime(2024, 8, 8, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4258) },
                    { 313, new DateTime(2024, 8, 9, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4262), 32, new DateTime(2024, 8, 9, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4262) },
                    { 314, new DateTime(2024, 8, 10, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4266), 32, new DateTime(2024, 8, 10, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4266) },
                    { 315, new DateTime(2024, 8, 11, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4271), 32, new DateTime(2024, 8, 11, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4271) },
                    { 316, new DateTime(2024, 8, 12, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4275), 32, new DateTime(2024, 8, 12, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4275) },
                    { 317, new DateTime(2024, 8, 13, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4279), 32, new DateTime(2024, 8, 13, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4279) },
                    { 318, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4283), 32, new DateTime(2024, 8, 14, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4283) },
                    { 319, new DateTime(2024, 8, 15, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4287), 32, new DateTime(2024, 8, 15, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4287) },
                    { 320, new DateTime(2024, 8, 16, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4291), 32, new DateTime(2024, 8, 16, 21, 0, 0, 0, DateTimeKind.Local).AddTicks(4291) },
                    { 321, new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4319), 33, new DateTime(2024, 8, 7, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4319) },
                    { 322, new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4323), 33, new DateTime(2024, 8, 8, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4323) },
                    { 323, new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4327), 33, new DateTime(2024, 8, 9, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4327) },
                    { 324, new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4331), 33, new DateTime(2024, 8, 10, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4331) },
                    { 325, new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4335), 33, new DateTime(2024, 8, 11, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4335) },
                    { 326, new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4339), 33, new DateTime(2024, 8, 12, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4339) },
                    { 327, new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4343), 33, new DateTime(2024, 8, 13, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4343) },
                    { 328, new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4347), 33, new DateTime(2024, 8, 14, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4347) },
                    { 329, new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4352), 33, new DateTime(2024, 8, 15, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4352) },
                    { 330, new DateTime(2024, 8, 16, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4356), 33, new DateTime(2024, 8, 16, 22, 0, 0, 0, DateTimeKind.Local).AddTicks(4356) },
                    { 331, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4380), 34, new DateTime(2024, 8, 7, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4380) },
                    { 332, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4384), 34, new DateTime(2024, 8, 8, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4384) },
                    { 333, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4388), 34, new DateTime(2024, 8, 9, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4388) },
                    { 334, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4393), 34, new DateTime(2024, 8, 10, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4393) },
                    { 335, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4397), 34, new DateTime(2024, 8, 11, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4397) },
                    { 336, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4401), 34, new DateTime(2024, 8, 12, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4401) },
                    { 337, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4405), 34, new DateTime(2024, 8, 13, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4405) },
                    { 338, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4409), 34, new DateTime(2024, 8, 14, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4409) },
                    { 339, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4413), 34, new DateTime(2024, 8, 15, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4413) },
                    { 340, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4417), 34, new DateTime(2024, 8, 16, 23, 0, 0, 0, DateTimeKind.Local).AddTicks(4417) },
                    { 341, new DateTime(2024, 8, 8, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4466), 35, new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4466) },
                    { 342, new DateTime(2024, 8, 9, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4470), 35, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4470) },
                    { 343, new DateTime(2024, 8, 10, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4474), 35, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4474) },
                    { 344, new DateTime(2024, 8, 11, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4479), 35, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4479) },
                    { 345, new DateTime(2024, 8, 12, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4483), 35, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4483) },
                    { 346, new DateTime(2024, 8, 13, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4487), 35, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4487) },
                    { 347, new DateTime(2024, 8, 14, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4491), 35, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4491) },
                    { 348, new DateTime(2024, 8, 15, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4495), 35, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4495) },
                    { 349, new DateTime(2024, 8, 16, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4500), 35, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4500) },
                    { 350, new DateTime(2024, 8, 17, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4504), 35, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local).AddTicks(4504) },
                    { 351, new DateTime(2024, 8, 8, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4529), 36, new DateTime(2024, 8, 8, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4529) },
                    { 352, new DateTime(2024, 8, 9, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4533), 36, new DateTime(2024, 8, 9, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4533) },
                    { 353, new DateTime(2024, 8, 10, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4537), 36, new DateTime(2024, 8, 10, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4537) },
                    { 354, new DateTime(2024, 8, 11, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4542), 36, new DateTime(2024, 8, 11, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4542) },
                    { 355, new DateTime(2024, 8, 12, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4546), 36, new DateTime(2024, 8, 12, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4546) },
                    { 356, new DateTime(2024, 8, 13, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4550), 36, new DateTime(2024, 8, 13, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4550) },
                    { 357, new DateTime(2024, 8, 14, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4554), 36, new DateTime(2024, 8, 14, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4554) },
                    { 358, new DateTime(2024, 8, 15, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4558), 36, new DateTime(2024, 8, 15, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4558) },
                    { 359, new DateTime(2024, 8, 16, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4562), 36, new DateTime(2024, 8, 16, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4562) },
                    { 360, new DateTime(2024, 8, 17, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4566), 36, new DateTime(2024, 8, 17, 1, 0, 0, 0, DateTimeKind.Local).AddTicks(4566) },
                    { 361, new DateTime(2024, 8, 8, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4590), 37, new DateTime(2024, 8, 8, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4590) },
                    { 362, new DateTime(2024, 8, 9, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4594), 37, new DateTime(2024, 8, 9, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4594) },
                    { 363, new DateTime(2024, 8, 10, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4598), 37, new DateTime(2024, 8, 10, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4598) },
                    { 364, new DateTime(2024, 8, 11, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4602), 37, new DateTime(2024, 8, 11, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4602) },
                    { 365, new DateTime(2024, 8, 12, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4606), 37, new DateTime(2024, 8, 12, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4606) },
                    { 366, new DateTime(2024, 8, 13, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4610), 37, new DateTime(2024, 8, 13, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4610) },
                    { 367, new DateTime(2024, 8, 14, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4614), 37, new DateTime(2024, 8, 14, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4614) },
                    { 368, new DateTime(2024, 8, 15, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4619), 37, new DateTime(2024, 8, 15, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4619) },
                    { 369, new DateTime(2024, 8, 16, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4623), 37, new DateTime(2024, 8, 16, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4623) },
                    { 370, new DateTime(2024, 8, 17, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4627), 37, new DateTime(2024, 8, 17, 2, 0, 0, 0, DateTimeKind.Local).AddTicks(4627) },
                    { 371, new DateTime(2024, 8, 8, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4736), 38, new DateTime(2024, 8, 8, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4736) },
                    { 372, new DateTime(2024, 8, 9, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4747), 38, new DateTime(2024, 8, 9, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4747) },
                    { 373, new DateTime(2024, 8, 10, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4752), 38, new DateTime(2024, 8, 10, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4752) },
                    { 374, new DateTime(2024, 8, 11, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4756), 38, new DateTime(2024, 8, 11, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4756) },
                    { 375, new DateTime(2024, 8, 12, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4760), 38, new DateTime(2024, 8, 12, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4760) },
                    { 376, new DateTime(2024, 8, 13, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4764), 38, new DateTime(2024, 8, 13, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4764) },
                    { 377, new DateTime(2024, 8, 14, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4769), 38, new DateTime(2024, 8, 14, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4769) },
                    { 378, new DateTime(2024, 8, 15, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4773), 38, new DateTime(2024, 8, 15, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4773) },
                    { 379, new DateTime(2024, 8, 16, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4777), 38, new DateTime(2024, 8, 16, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4777) },
                    { 380, new DateTime(2024, 8, 17, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4781), 38, new DateTime(2024, 8, 17, 3, 0, 0, 0, DateTimeKind.Local).AddTicks(4781) },
                    { 381, new DateTime(2024, 8, 8, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4837), 39, new DateTime(2024, 8, 8, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4837) },
                    { 382, new DateTime(2024, 8, 9, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4841), 39, new DateTime(2024, 8, 9, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4841) },
                    { 383, new DateTime(2024, 8, 10, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4846), 39, new DateTime(2024, 8, 10, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4846) },
                    { 384, new DateTime(2024, 8, 11, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4850), 39, new DateTime(2024, 8, 11, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4850) },
                    { 385, new DateTime(2024, 8, 12, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4854), 39, new DateTime(2024, 8, 12, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4854) },
                    { 386, new DateTime(2024, 8, 13, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4858), 39, new DateTime(2024, 8, 13, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4858) },
                    { 387, new DateTime(2024, 8, 14, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4863), 39, new DateTime(2024, 8, 14, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4863) },
                    { 388, new DateTime(2024, 8, 15, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4867), 39, new DateTime(2024, 8, 15, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4867) },
                    { 389, new DateTime(2024, 8, 16, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4871), 39, new DateTime(2024, 8, 16, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4871) },
                    { 390, new DateTime(2024, 8, 17, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4875), 39, new DateTime(2024, 8, 17, 4, 0, 0, 0, DateTimeKind.Local).AddTicks(4875) },
                    { 391, new DateTime(2024, 8, 8, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4902), 40, new DateTime(2024, 8, 8, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4902) },
                    { 392, new DateTime(2024, 8, 9, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4906), 40, new DateTime(2024, 8, 9, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4906) },
                    { 393, new DateTime(2024, 8, 10, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4910), 40, new DateTime(2024, 8, 10, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4910) },
                    { 394, new DateTime(2024, 8, 11, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4914), 40, new DateTime(2024, 8, 11, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4914) },
                    { 395, new DateTime(2024, 8, 12, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4918), 40, new DateTime(2024, 8, 12, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4918) },
                    { 396, new DateTime(2024, 8, 13, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4922), 40, new DateTime(2024, 8, 13, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4922) },
                    { 397, new DateTime(2024, 8, 14, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4926), 40, new DateTime(2024, 8, 14, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4926) },
                    { 398, new DateTime(2024, 8, 15, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4930), 40, new DateTime(2024, 8, 15, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4930) },
                    { 399, new DateTime(2024, 8, 16, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4934), 40, new DateTime(2024, 8, 16, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4934) },
                    { 400, new DateTime(2024, 8, 17, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4938), 40, new DateTime(2024, 8, 17, 5, 0, 0, 0, DateTimeKind.Local).AddTicks(4938) },
                    { 401, new DateTime(2024, 8, 8, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4962), 41, new DateTime(2024, 8, 8, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4962) },
                    { 402, new DateTime(2024, 8, 9, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4966), 41, new DateTime(2024, 8, 9, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4966) },
                    { 403, new DateTime(2024, 8, 10, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4970), 41, new DateTime(2024, 8, 10, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4970) },
                    { 404, new DateTime(2024, 8, 11, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4974), 41, new DateTime(2024, 8, 11, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4974) },
                    { 405, new DateTime(2024, 8, 12, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4978), 41, new DateTime(2024, 8, 12, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4978) },
                    { 406, new DateTime(2024, 8, 13, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4982), 41, new DateTime(2024, 8, 13, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4982) },
                    { 407, new DateTime(2024, 8, 14, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4986), 41, new DateTime(2024, 8, 14, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4986) },
                    { 408, new DateTime(2024, 8, 15, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4991), 41, new DateTime(2024, 8, 15, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4991) },
                    { 409, new DateTime(2024, 8, 16, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4995), 41, new DateTime(2024, 8, 16, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4995) },
                    { 410, new DateTime(2024, 8, 17, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(4999), 41, new DateTime(2024, 8, 17, 6, 0, 0, 0, DateTimeKind.Local).AddTicks(4999) },
                    { 411, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5024), 42, new DateTime(2024, 8, 8, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5024) },
                    { 412, new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5028), 42, new DateTime(2024, 8, 9, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5028) },
                    { 413, new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5032), 42, new DateTime(2024, 8, 10, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5032) },
                    { 414, new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5037), 42, new DateTime(2024, 8, 11, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5037) },
                    { 415, new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5041), 42, new DateTime(2024, 8, 12, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5041) },
                    { 416, new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5045), 42, new DateTime(2024, 8, 13, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5045) },
                    { 417, new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5049), 42, new DateTime(2024, 8, 14, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5049) },
                    { 418, new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5053), 42, new DateTime(2024, 8, 15, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5053) },
                    { 419, new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5057), 42, new DateTime(2024, 8, 16, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5057) },
                    { 420, new DateTime(2024, 8, 17, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5061), 42, new DateTime(2024, 8, 17, 7, 0, 0, 0, DateTimeKind.Local).AddTicks(5061) },
                    { 421, new DateTime(2024, 8, 8, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5109), 43, new DateTime(2024, 8, 8, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5109) },
                    { 422, new DateTime(2024, 8, 9, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5114), 43, new DateTime(2024, 8, 9, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5114) },
                    { 423, new DateTime(2024, 8, 10, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5118), 43, new DateTime(2024, 8, 10, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5118) },
                    { 424, new DateTime(2024, 8, 11, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5122), 43, new DateTime(2024, 8, 11, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5122) },
                    { 425, new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5126), 43, new DateTime(2024, 8, 12, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5126) },
                    { 426, new DateTime(2024, 8, 13, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5131), 43, new DateTime(2024, 8, 13, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5131) },
                    { 427, new DateTime(2024, 8, 14, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5135), 43, new DateTime(2024, 8, 14, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5135) },
                    { 428, new DateTime(2024, 8, 15, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5139), 43, new DateTime(2024, 8, 15, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5139) },
                    { 429, new DateTime(2024, 8, 16, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5143), 43, new DateTime(2024, 8, 16, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5143) },
                    { 430, new DateTime(2024, 8, 17, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5147), 43, new DateTime(2024, 8, 17, 8, 0, 0, 0, DateTimeKind.Local).AddTicks(5147) },
                    { 431, new DateTime(2024, 8, 8, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5173), 44, new DateTime(2024, 8, 8, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5173) },
                    { 432, new DateTime(2024, 8, 9, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5177), 44, new DateTime(2024, 8, 9, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5177) },
                    { 433, new DateTime(2024, 8, 10, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5181), 44, new DateTime(2024, 8, 10, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5181) },
                    { 434, new DateTime(2024, 8, 11, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5185), 44, new DateTime(2024, 8, 11, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5185) },
                    { 435, new DateTime(2024, 8, 12, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5190), 44, new DateTime(2024, 8, 12, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5190) },
                    { 436, new DateTime(2024, 8, 13, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5194), 44, new DateTime(2024, 8, 13, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5194) },
                    { 437, new DateTime(2024, 8, 14, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5198), 44, new DateTime(2024, 8, 14, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5198) },
                    { 438, new DateTime(2024, 8, 15, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5202), 44, new DateTime(2024, 8, 15, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5202) },
                    { 439, new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5206), 44, new DateTime(2024, 8, 16, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5206) },
                    { 440, new DateTime(2024, 8, 17, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5210), 44, new DateTime(2024, 8, 17, 9, 0, 0, 0, DateTimeKind.Local).AddTicks(5210) },
                    { 441, new DateTime(2024, 8, 8, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5233), 45, new DateTime(2024, 8, 8, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5233) },
                    { 442, new DateTime(2024, 8, 9, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5238), 45, new DateTime(2024, 8, 9, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5238) },
                    { 443, new DateTime(2024, 8, 10, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5242), 45, new DateTime(2024, 8, 10, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5242) },
                    { 444, new DateTime(2024, 8, 11, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5246), 45, new DateTime(2024, 8, 11, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5246) },
                    { 445, new DateTime(2024, 8, 12, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5250), 45, new DateTime(2024, 8, 12, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5250) },
                    { 446, new DateTime(2024, 8, 13, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5254), 45, new DateTime(2024, 8, 13, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5254) },
                    { 447, new DateTime(2024, 8, 14, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5258), 45, new DateTime(2024, 8, 14, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5258) },
                    { 448, new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5262), 45, new DateTime(2024, 8, 15, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5262) },
                    { 449, new DateTime(2024, 8, 16, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5266), 45, new DateTime(2024, 8, 16, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5266) },
                    { 450, new DateTime(2024, 8, 17, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5270), 45, new DateTime(2024, 8, 17, 10, 0, 0, 0, DateTimeKind.Local).AddTicks(5270) },
                    { 451, new DateTime(2024, 8, 8, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5295), 46, new DateTime(2024, 8, 8, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5295) },
                    { 452, new DateTime(2024, 8, 9, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5300), 46, new DateTime(2024, 8, 9, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5300) },
                    { 453, new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5304), 46, new DateTime(2024, 8, 10, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5304) },
                    { 454, new DateTime(2024, 8, 11, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5308), 46, new DateTime(2024, 8, 11, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5308) },
                    { 455, new DateTime(2024, 8, 12, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5312), 46, new DateTime(2024, 8, 12, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5312) },
                    { 456, new DateTime(2024, 8, 13, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5316), 46, new DateTime(2024, 8, 13, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5316) },
                    { 457, new DateTime(2024, 8, 14, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5320), 46, new DateTime(2024, 8, 14, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5320) },
                    { 458, new DateTime(2024, 8, 15, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5324), 46, new DateTime(2024, 8, 15, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5324) },
                    { 459, new DateTime(2024, 8, 16, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5329), 46, new DateTime(2024, 8, 16, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5329) },
                    { 460, new DateTime(2024, 8, 17, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5333), 46, new DateTime(2024, 8, 17, 11, 0, 0, 0, DateTimeKind.Local).AddTicks(5333) },
                    { 461, new DateTime(2024, 8, 8, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5356), 47, new DateTime(2024, 8, 8, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5356) },
                    { 462, new DateTime(2024, 8, 9, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5361), 47, new DateTime(2024, 8, 9, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5361) },
                    { 463, new DateTime(2024, 8, 10, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5365), 47, new DateTime(2024, 8, 10, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5365) },
                    { 464, new DateTime(2024, 8, 11, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5369), 47, new DateTime(2024, 8, 11, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5369) },
                    { 465, new DateTime(2024, 8, 12, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5395), 47, new DateTime(2024, 8, 12, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5395) },
                    { 466, new DateTime(2024, 8, 13, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5400), 47, new DateTime(2024, 8, 13, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5400) },
                    { 467, new DateTime(2024, 8, 14, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5404), 47, new DateTime(2024, 8, 14, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5404) },
                    { 468, new DateTime(2024, 8, 15, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5408), 47, new DateTime(2024, 8, 15, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5408) },
                    { 469, new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5413), 47, new DateTime(2024, 8, 16, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5413) },
                    { 470, new DateTime(2024, 8, 17, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5417), 47, new DateTime(2024, 8, 17, 12, 0, 0, 0, DateTimeKind.Local).AddTicks(5417) },
                    { 471, new DateTime(2024, 8, 8, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5442), 48, new DateTime(2024, 8, 8, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5442) },
                    { 472, new DateTime(2024, 8, 9, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5446), 48, new DateTime(2024, 8, 9, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5446) },
                    { 473, new DateTime(2024, 8, 10, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5450), 48, new DateTime(2024, 8, 10, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5450) },
                    { 474, new DateTime(2024, 8, 11, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5455), 48, new DateTime(2024, 8, 11, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5455) },
                    { 475, new DateTime(2024, 8, 12, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5459), 48, new DateTime(2024, 8, 12, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5459) },
                    { 476, new DateTime(2024, 8, 13, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5463), 48, new DateTime(2024, 8, 13, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5463) },
                    { 477, new DateTime(2024, 8, 14, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5467), 48, new DateTime(2024, 8, 14, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5467) },
                    { 478, new DateTime(2024, 8, 15, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5471), 48, new DateTime(2024, 8, 15, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5471) },
                    { 479, new DateTime(2024, 8, 16, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5475), 48, new DateTime(2024, 8, 16, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5475) },
                    { 480, new DateTime(2024, 8, 17, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5479), 48, new DateTime(2024, 8, 17, 13, 0, 0, 0, DateTimeKind.Local).AddTicks(5479) },
                    { 481, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5502), 49, new DateTime(2024, 8, 8, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5502) },
                    { 482, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5506), 49, new DateTime(2024, 8, 9, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5506) },
                    { 483, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5510), 49, new DateTime(2024, 8, 10, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5510) },
                    { 484, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5514), 49, new DateTime(2024, 8, 11, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5514) },
                    { 485, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5518), 49, new DateTime(2024, 8, 12, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5518) },
                    { 486, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5523), 49, new DateTime(2024, 8, 13, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5523) },
                    { 487, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5527), 49, new DateTime(2024, 8, 14, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5527) },
                    { 488, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5531), 49, new DateTime(2024, 8, 15, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5531) },
                    { 489, new DateTime(2024, 8, 16, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5535), 49, new DateTime(2024, 8, 16, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5535) },
                    { 490, new DateTime(2024, 8, 17, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5539), 49, new DateTime(2024, 8, 17, 14, 0, 0, 0, DateTimeKind.Local).AddTicks(5539) },
                    { 491, new DateTime(2024, 8, 8, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5563), 50, new DateTime(2024, 8, 8, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5563) },
                    { 492, new DateTime(2024, 8, 9, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5568), 50, new DateTime(2024, 8, 9, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5568) },
                    { 493, new DateTime(2024, 8, 10, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5572), 50, new DateTime(2024, 8, 10, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5572) },
                    { 494, new DateTime(2024, 8, 11, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5576), 50, new DateTime(2024, 8, 11, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5576) },
                    { 495, new DateTime(2024, 8, 12, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5580), 50, new DateTime(2024, 8, 12, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5580) },
                    { 496, new DateTime(2024, 8, 13, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5584), 50, new DateTime(2024, 8, 13, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5584) },
                    { 497, new DateTime(2024, 8, 14, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5589), 50, new DateTime(2024, 8, 14, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5589) },
                    { 498, new DateTime(2024, 8, 15, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5593), 50, new DateTime(2024, 8, 15, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5593) },
                    { 499, new DateTime(2024, 8, 16, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5597), 50, new DateTime(2024, 8, 16, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5597) },
                    { 500, new DateTime(2024, 8, 17, 16, 0, 0, 0, DateTimeKind.Local).AddTicks(5601), 50, new DateTime(2024, 8, 17, 15, 0, 0, 0, DateTimeKind.Local).AddTicks(5601) }
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
                name: "IX_Bookings_TimeSlotId",
                table: "Bookings",
                column: "TimeSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUsers_BusinessId",
                table: "BusinessUsers",
                column: "BusinessId");

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
                name: "TimeSlot");

            migrationBuilder.DropTable(
                name: "Businesses");

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
