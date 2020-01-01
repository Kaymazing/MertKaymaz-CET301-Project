﻿// <auto-generated />
using System;
using MertKaymaz_301Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MertKaymaz_301Project.Migrations
{
    [DbContext(typeof(AlaKurumsalDatabase))]
    partial class AlaKurumsalDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MertKaymaz_301Project.Data.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DropPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HirePoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsSold")
                        .HasColumnType("bit");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.HasIndex("VehicleId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("HasCriminalRecord")
                        .HasColumnType("bit");

                    b.Property<bool?>("HasLicence")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LicenceEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40,
                            Mail = "ozkan.kaymaz@alakurumsal.com",
                            Name = "Ozkan",
                            Password = "f2238d2b7e51aebac6cdcbdebf1fc98bdd9c2091ad4abdfd099a1dfcf5f7a4e9",
                            PhoneNo = "532273",
                            Surname = "Kaymaz"
                        },
                        new
                        {
                            Id = 2,
                            Age = 36,
                            Mail = "kenan.ilten@alakurumsal.com",
                            Name = "Kenan",
                            Password = "2f7b85e6f1127fb0dfc021d3329da20a40898ead1545e0b930048c6c0af2cc74",
                            PhoneNo = "532631",
                            Surname = "İlten"
                        });
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingNo")
                        .HasColumnType("int");

                    b.Property<bool?>("HasInstallment")
                        .HasColumnType("bit");

                    b.Property<int?>("InstallmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AvailableDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsCrashed")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsPreOwned")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRentable")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnertId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnertId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Booking", b =>
                {
                    b.HasOne("MertKaymaz_301Project.Data.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("MertKaymaz_301Project.Data.Payment", null)
                        .WithOne("Booking")
                        .HasForeignKey("MertKaymaz_301Project.Data.Booking", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MertKaymaz_301Project.Data.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");
                });

            modelBuilder.Entity("MertKaymaz_301Project.Data.Vehicle", b =>
                {
                    b.HasOne("MertKaymaz_301Project.Data.Owner", "Ownert")
                        .WithMany()
                        .HasForeignKey("OwnertId");
                });
#pragma warning restore 612, 618
        }
    }
}
