﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SSM_WebApplication.Models;

namespace SSM_WebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201203214403_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SSM_WebApplication.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Adresse1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresse2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ICE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tel1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Distributor", b =>
                {
                    b.Property<int>("DistributorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistributorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistributorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<int>("PumpId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DistributorId");

                    b.HasIndex("FuelId");

                    b.HasIndex("PumpId");

                    b.ToTable("Distributors");

                    b.HasData(
                        new
                        {
                            DistributorId = 1,
                            AddDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 1",
                            DistributorName = "d1",
                            FuelId = 2,
                            PumpId = 1,
                            Status = true
                        },
                        new
                        {
                            DistributorId = 2,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 2",
                            DistributorName = "d2",
                            FuelId = 2,
                            PumpId = 1,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 3,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 3",
                            DistributorName = "d3",
                            FuelId = 1,
                            PumpId = 2,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 4,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 4",
                            DistributorName = "d4",
                            FuelId = 3,
                            PumpId = 2,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 5,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 5",
                            DistributorName = "d5",
                            FuelId = 1,
                            PumpId = 3,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 6,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 6",
                            DistributorName = "d6",
                            FuelId = 3,
                            PumpId = 3,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 7,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 7",
                            DistributorName = "d7",
                            FuelId = 2,
                            PumpId = 4,
                            Status = false
                        },
                        new
                        {
                            DistributorId = 8,
                            AddDate = new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DistributorDescription = "Pistolet 8",
                            DistributorName = "d8",
                            FuelId = 1,
                            PumpId = 4,
                            Status = false
                        });
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresse1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresse2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tel1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Fuel", b =>
                {
                    b.Property<int>("FuelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("FuelId");

                    b.ToTable("Fuels");

                    b.HasData(
                        new
                        {
                            FuelId = 1,
                            AddDate = new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelName = "Gasoil",
                            ShortDescription = "d1",
                            Status = true
                        },
                        new
                        {
                            FuelId = 2,
                            AddDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelName = "Super Sans Plombe",
                            ShortDescription = "d2",
                            Status = true
                        },
                        new
                        {
                            FuelId = 3,
                            AddDate = new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FuelName = "Excellium",
                            ShortDescription = "d3",
                            Status = false
                        });
                });

            modelBuilder.Entity("SSM_WebApplication.Models.FuelPrice", b =>
                {
                    b.Property<int>("FuelPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("FuelPriceId");

                    b.HasIndex("FuelId");

                    b.ToTable("FuelPrices");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.JobTitle", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("JobId");

                    b.ToTable("JobTitles");

                    b.HasData(
                        new
                        {
                            JobId = 1,
                            AddDate = new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobName = "J1",
                            ShortDescription = "Job 1",
                            Status = false
                        },
                        new
                        {
                            JobId = 2,
                            AddDate = new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobName = "J2",
                            ShortDescription = "Job 2",
                            Status = false
                        },
                        new
                        {
                            JobId = 3,
                            AddDate = new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JobName = "J3",
                            ShortDescription = "Job 3",
                            Status = false
                        });
                });

            modelBuilder.Entity("SSM_WebApplication.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            PaymentTypeId = 1,
                            AddDate = new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentTypeName = "p1",
                            ShortDescription = "payment 1",
                            Status = false
                        });
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Pump", b =>
                {
                    b.Property<int>("PumpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PumpDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PumpName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PumpId");

                    b.ToTable("Pumps");

                    b.HasData(
                        new
                        {
                            PumpId = 1,
                            PumpDescription = "Pompe 1",
                            PumpName = "P1"
                        },
                        new
                        {
                            PumpId = 2,
                            PumpDescription = "Pompe 2",
                            PumpName = "P2"
                        },
                        new
                        {
                            PumpId = 3,
                            PumpDescription = "Pompe 3",
                            PumpName = "P3"
                        },
                        new
                        {
                            PumpId = 4,
                            PumpDescription = "Pompe 4",
                            PumpName = "P4"
                        });
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Distributor", b =>
                {
                    b.HasOne("SSM_WebApplication.Models.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSM_WebApplication.Models.Pump", "Pump")
                        .WithMany("Distributors")
                        .HasForeignKey("PumpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fuel");

                    b.Navigation("Pump");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Employee", b =>
                {
                    b.HasOne("SSM_WebApplication.Models.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.FuelPrice", b =>
                {
                    b.HasOne("SSM_WebApplication.Models.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fuel");
                });

            modelBuilder.Entity("SSM_WebApplication.Models.Pump", b =>
                {
                    b.Navigation("Distributors");
                });
#pragma warning restore 612, 618
        }
    }
}
