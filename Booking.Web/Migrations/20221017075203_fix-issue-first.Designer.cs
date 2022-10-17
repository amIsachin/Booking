﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Booking.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221017075203_fix-issue-first")]
    partial class fixissuefirst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Entities.SystemEntities.DriverDropedRiderSystemEntity", b =>
                {
                    b.Property<long>("Droped_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<long>("DriverID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DriverSystemEntityDriver_ID")
                        .HasColumnType("bigint");

                    b.Property<long>("RiderID")
                        .HasColumnType("bigint");

                    b.Property<long?>("RiderSystemEntityRider_ID")
                        .HasColumnType("bigint");

                    b.HasKey("Droped_ID");

                    b.HasIndex("DriverSystemEntityDriver_ID");

                    b.HasIndex("RiderSystemEntityRider_ID");

                    b.ToTable("Droped");
                });

            modelBuilder.Entity("Domain.Entities.SystemEntities.DriverSystemEntity", b =>
                {
                    b.Property<long>("Driver_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrivingLicence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Driver_ID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Domain.Entities.SystemEntities.RiderSystemEntity", b =>
                {
                    b.Property<long>("Rider_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rider_ID");

                    b.ToTable("Riders");
                });

            modelBuilder.Entity("Domain.Entities.SystemEntities.DriverDropedRiderSystemEntity", b =>
                {
                    b.HasOne("Domain.Entities.SystemEntities.DriverSystemEntity", "DriverSystemEntity")
                        .WithMany("DriverDropedRiderSystemEntity")
                        .HasForeignKey("DriverSystemEntityDriver_ID");

                    b.HasOne("Domain.Entities.SystemEntities.RiderSystemEntity", "RiderSystemEntity")
                        .WithMany("DriverDropedRiderSystemEntity")
                        .HasForeignKey("RiderSystemEntityRider_ID");

                    b.Navigation("DriverSystemEntity");

                    b.Navigation("RiderSystemEntity");
                });

            modelBuilder.Entity("Domain.Entities.SystemEntities.DriverSystemEntity", b =>
                {
                    b.Navigation("DriverDropedRiderSystemEntity");
                });

            modelBuilder.Entity("Domain.Entities.SystemEntities.RiderSystemEntity", b =>
                {
                    b.Navigation("DriverDropedRiderSystemEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
