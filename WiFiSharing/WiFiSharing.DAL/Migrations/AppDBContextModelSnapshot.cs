﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WiFiSharing.DAL;

namespace WiFiSharing.DAL.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WiFiSharing.Common.Entities.Drone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CapacityInMinutes");

                    b.Property<int>("DroneRangeInMeters");

                    b.Property<bool>("IsBusy");

                    b.Property<string>("WiFiPassword");

                    b.Property<int>("WiFiRangeInMeters");

                    b.HasKey("Id");

                    b.ToTable("Drones");
                });

            modelBuilder.Entity("WiFiSharing.Common.Entities.Order", b =>
                {
                    b.Property<int>("DroneId");

                    b.Property<int>("UserId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Relevance");

                    b.Property<int>("Type");

                    b.HasKey("DroneId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WiFiSharing.Common.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("PassportCode");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WiFiSharing.Common.Entities.Order", b =>
                {
                    b.HasOne("WiFiSharing.Common.Entities.Drone", "Drone")
                        .WithMany("Orders")
                        .HasForeignKey("DroneId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WiFiSharing.Common.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
