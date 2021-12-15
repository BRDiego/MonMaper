﻿// <auto-generated />
using System;
using DBControl.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBControl.Migrations
{
    [DbContext(typeof(MonMaperContext))]
    partial class MonMaperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Model.Expenditure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Moment")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Expenditures");
                });

            modelBuilder.Entity("Model.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Moment")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Source")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Incomes");
                });
#pragma warning restore 612, 618
        }
    }
}
