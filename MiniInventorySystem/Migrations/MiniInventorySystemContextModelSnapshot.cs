﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniInventorySystem.Models;

namespace MiniInventorySystem.Migrations
{
    [DbContext(typeof(MiniInventorySystemContext))]
    partial class MiniInventorySystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MiniInventorySystem.Models.Desktop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormFactor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RamSlots")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsbPorts")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Desktops");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d681a355-b25b-441d-9798-5291069cb2a4"),
                            Brand = "Dell",
                            Processor = "i7",
                            Quantity = 10,
                            RamSlots = 4,
                            UsbPorts = 3
                        });
                });

            modelBuilder.Entity("MiniInventorySystem.Models.Laptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("BatteryCapacity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ScreenSize")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Laptops");
                });
#pragma warning restore 612, 618
        }
    }
}
