﻿// <auto-generated />
using System;
using HotelBookingManager.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelBookingManager.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241115134452_RenameRoomTypeProperty")]
    partial class RenameRoomTypeProperty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("RoomID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.HasKey("InvoiceID");

                    b.HasIndex("BookingID")
                        .IsUnique();

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("ExtraBedAmount")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Booking", b =>
                {
                    b.HasOne("HotelBookingManager.Repository.Entities.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelBookingManager.Repository.Entities.Room", "Room")
                        .WithMany("Bookings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Invoice", b =>
                {
                    b.HasOne("HotelBookingManager.Repository.Entities.Booking", "Booking")
                        .WithOne("Invoice")
                        .HasForeignKey("HotelBookingManager.Repository.Entities.Invoice", "BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Booking", b =>
                {
                    b.Navigation("Invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("HotelBookingManager.Repository.Entities.Room", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
