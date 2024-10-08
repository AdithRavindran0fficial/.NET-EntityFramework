﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task_4_EntityFramework.Data;

#nullable disable

namespace Task_4_EntityFramework.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20240919084007_changeschema")]
    partial class changeschema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Task_4_EntityFramework.Models.Employee", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Emp_Id"));

                    b.Property<string>("Employee_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Employee_Sal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Joining")
                        .HasColumnType("datetime2");

                    b.HasKey("Emp_Id");

                    b.ToTable("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
