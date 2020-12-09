﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMotownFestival.DAL;

namespace RMotownFestival.DAL.Migrations
{
    [DbContext(typeof(MotownDbContext))]
    [Migration("20201209101549_AddSchedule")]
    partial class AddSchedule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("RMotownFestival.DAL.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Wardruna",
                            Website = "http://www.wardruna.com/"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Heilung",
                            Website = "http://www.heilung.com/"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Faun",
                            Website = "http://www.faun.com/"
                        });
                });

            modelBuilder.Entity("RMotownFestival.DAL.Models.ScheduleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("StageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("StageId");

                    b.ToTable("ScheduleItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            StageId = 1,
                            Time = new DateTime(2021, 7, 1, 20, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            StageId = 2,
                            Time = new DateTime(2021, 7, 1, 21, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            StageId = 3,
                            Time = new DateTime(2021, 7, 1, 22, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 1,
                            StageId = 4,
                            Time = new DateTime(2021, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 2,
                            StageId = 1,
                            Time = new DateTime(2021, 7, 1, 23, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("RMotownFestival.DAL.Models.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is stage red",
                            Name = "Stage Red"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is stage green",
                            Name = "Stage Green"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is stage blue",
                            Name = "Stage Blue"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is stage white",
                            Name = "Stage White"
                        });
                });

            modelBuilder.Entity("RMotownFestival.DAL.Models.ScheduleItem", b =>
                {
                    b.HasOne("RMotownFestival.DAL.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RMotownFestival.DAL.Models.Stage", "Stage")
                        .WithMany()
                        .HasForeignKey("StageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Stage");
                });
#pragma warning restore 612, 618
        }
    }
}
