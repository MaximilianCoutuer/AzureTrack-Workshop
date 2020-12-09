using Microsoft.EntityFrameworkCore;
using RMotownFestival.DAL.Models;
using System;

namespace RMotownFestival.DAL
{
    public class MotownDbContext : DbContext
    {
        public MotownDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<ScheduleItem> ScheduleItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, Name = "Wardruna", Website = new Uri("http://www.wardruna.com") },
                new Artist { Id = 2, Name = "Heilung", Website = new Uri("http://www.heilung.com") },
                new Artist { Id = 3, Name = "Faun", Website = new Uri("http://www.faun.com") }
            );

            modelBuilder.Entity<Stage>().HasData(
                new Stage { Id = 1, Name = "Stage Red", Description = "This is stage red" },
                new Stage { Id = 2, Name = "Stage Green", Description = "This is stage green" },
                new Stage { Id = 3, Name = "Stage Blue", Description = "This is stage blue" },
                new Stage { Id = 4, Name = "Stage White", Description = "This is stage white" }
            );

            modelBuilder.Entity<ScheduleItem>().HasData(
                new ScheduleItem { Id = 1, ArtistId = 1, StageId = 1, Time = new DateTime(2021, 07, 01, 20, 0, 0) },
                new ScheduleItem { Id = 2, ArtistId = 2, StageId = 2, Time = new DateTime(2021, 07, 01, 21, 0, 0) },
                new ScheduleItem { Id = 3, ArtistId = 3, StageId = 3, Time = new DateTime(2021, 07, 01, 22, 0, 0) },
                new ScheduleItem { Id = 4, ArtistId = 1, StageId = 4, Time = new DateTime(2021, 07, 01, 23, 0, 0) },
                new ScheduleItem { Id = 5, ArtistId = 2, StageId = 1, Time = new DateTime(2021, 07, 01, 23, 0, 0) }
            );
        }
    }
}
