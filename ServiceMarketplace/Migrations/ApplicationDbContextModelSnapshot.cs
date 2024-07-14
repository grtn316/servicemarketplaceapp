﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceMarketplace.Data;

#nullable disable

namespace ServiceMarketplace.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.20");

            modelBuilder.Entity("ServiceMarketplace.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BusinessID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("BusinessUserId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Cost")
                        .HasColumnType("REAL");

                    b.Property<string>("CustomerID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BusinessUserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Business", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.BusinessUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BusinessUsers");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.CustomerUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CustomerUsers");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Inquiry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusinessId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentInquiriesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Inquiries");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusinessID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Rating")
                        .HasColumnType("REAL");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusinessId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<float>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.ServiceAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ServiceAvailability");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(2023, 6, 1),
                            Summary = "Freezing",
                            TemperatureC = -5
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(2023, 6, 2),
                            Summary = "Bracing",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateOnly(2023, 6, 3),
                            Summary = "Chilly",
                            TemperatureC = 5
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateOnly(2023, 6, 4),
                            Summary = "Cool",
                            TemperatureC = 10
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateOnly(2023, 6, 5),
                            Summary = "Mild",
                            TemperatureC = 15
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateOnly(2023, 6, 6),
                            Summary = "Warm",
                            TemperatureC = 20
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateOnly(2023, 6, 7),
                            Summary = "Balmy",
                            TemperatureC = 25
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateOnly(2023, 6, 8),
                            Summary = "Hot",
                            TemperatureC = 30
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateOnly(2023, 6, 9),
                            Summary = "Sweltering",
                            TemperatureC = 35
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateOnly(2023, 6, 10),
                            Summary = "Scorching",
                            TemperatureC = 40
                        });
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Booking", b =>
                {
                    b.HasOne("ServiceMarketplace.Entities.BusinessUser", null)
                        .WithMany("Bookings")
                        .HasForeignKey("BusinessUserId");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Business", b =>
                {
                    b.OwnsOne("ServiceMarketplace.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<string>("BusinessId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("City")
                                .HasColumnType("TEXT");

                            b1.Property<string>("State")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Zipcode")
                                .HasColumnType("TEXT");

                            b1.HasKey("BusinessId");

                            b1.ToTable("Businesses");

                            b1.WithOwner()
                                .HasForeignKey("BusinessId");
                        });

                    b.OwnsOne("ServiceMarketplace.Entities.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<string>("BusinessId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("BusinessId");

                            b1.ToTable("Businesses");

                            b1.WithOwner()
                                .HasForeignKey("BusinessId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Review", b =>
                {
                    b.HasOne("ServiceMarketplace.Entities.Service", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.BusinessUser", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ServiceMarketplace.Entities.Service", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
