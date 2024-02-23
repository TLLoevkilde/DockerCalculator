﻿// <auto-generated />
using DockerCalculator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DockerCalculator.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240223123105_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DockerCalculator.CalculationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Number1")
                        .HasColumnType("double");

                    b.Property<double>("Number2")
                        .HasColumnType("double");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Result")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("CalculationLogs");
                });
#pragma warning restore 612, 618
        }
    }
}