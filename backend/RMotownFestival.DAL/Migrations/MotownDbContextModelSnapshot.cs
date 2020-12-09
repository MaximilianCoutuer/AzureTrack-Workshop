﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMotownFestival.DAL;

namespace RMotownFestival.DAL.Migrations
{
    [DbContext(typeof(MotownDbContext))]
    partial class MotownDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}
