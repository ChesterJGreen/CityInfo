using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park."
                },
                new City()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished."
                },
                new City()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower."
                });
            Model.Entity<PointOfInterest()
                .HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Central Park",
                    Description = "The most visited urban park in th e United States."
                },
                new PointOfInterest()
                { 
                    Id= 2,
                    CityId = 1,
                    Name = "Empire State Building",
                    Description = "A 102-story skyscraper located in Midtown Manhattan."
                },
                new PointOfInterest()
                //{
                //    Id = 3,
                //    CityId = 
                //}
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
