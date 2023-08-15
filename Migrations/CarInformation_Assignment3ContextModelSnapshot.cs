﻿// <auto-generated />
using CarInformation_Assignment3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarInformation_Assignment3.Migrations
{
    [DbContext(typeof(CarInformation_Assignment3Context))]
    partial class CarInformation_Assignment3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarInformation_Assignment3.Models.CarInfo", b =>
                {
                    b.Property<int>("carNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("carNumber"));

                    b.Property<string>("carMade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("carModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manufacturedYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maxSpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("carNumber");

                    b.ToTable("CarInfo");
                });
#pragma warning restore 612, 618
        }
    }
}