﻿// <auto-generated />
using System;
using BackendApi.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackendApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240922150515_AddDescriptionToPayment")]
    partial class AddDescriptionToPayment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BackendApi.Models.LogsOfPaymentCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("Customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Customerid");

                    b.ToTable("PaymentLog");
                });

            modelBuilder.Entity("BackendApi.models.ApprovalPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PaymentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApprovalPayment");
                });

            modelBuilder.Entity("BackendApi.models.Customer", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("id"));

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<int?>("Spend")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BackendApi.models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentIntentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("BackendApi.models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("BackendApi.models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9448),
                            Description = "Latest model with cutting-edge technology.",
                            IsAvailable = true,
                            Name = "Smartphone",
                            Price = 699
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9482),
                            Description = "High performance laptop for professionals.",
                            IsAvailable = true,
                            Name = "Laptop",
                            Price = 1299
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9484),
                            Description = "Noise-cancelling over-ear headphones.",
                            IsAvailable = true,
                            Name = "Headphones",
                            Price = 199
                        },
                        new
                        {
                            Id = 4,
                            DateTime = new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9487),
                            Description = "Smartwatch with health tracking features.",
                            IsAvailable = false,
                            Name = "Smartwatch",
                            Price = 249
                        },
                        new
                        {
                            Id = 5,
                            DateTime = new DateTime(2024, 9, 22, 17, 5, 15, 455, DateTimeKind.Local).AddTicks(9489),
                            Description = "Portable tablet with high-resolution display.",
                            IsAvailable = true,
                            Name = "Tablet",
                            Price = 499
                        });
                });

            modelBuilder.Entity("BackendApi.models.Sponsors", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("BackendApi.Models.LogsOfPaymentCustomer", b =>
                {
                    b.HasOne("BackendApi.models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Customerid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}