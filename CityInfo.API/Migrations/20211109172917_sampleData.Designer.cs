﻿// <auto-generated />
using CityInfo.API.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CityInfo.API.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20211109172917_sampleData")]
    partial class sampleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CityInfo.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, Description = "The one with that big park.", Name = "New York City" },
                        new { Id = 2, Description = "The one with the cathedral that was never really finished.", Name = "Antwerp" },
                        new { Id = 3, Description = "The one with that big tower.", Name = "Paris" },
                        new { Id = 4, Description = "The one where everybody is moving to. Don't come here, it's a desert. It's ugly. Please, I beg you not to come here.", Name = "Boise" }
                    );
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointOfInterests");

                    b.HasData(
                        new { Id = 1, CityId = 1, Description = "The most visited urban park in th e United States.", Name = "Central Park" },
                        new { Id = 2, CityId = 1, Description = "A 102-story skyscraper located in Midtown Manhattan.", Name = "Empire State Building" },
                        new { Id = 3, CityId = 2, Description = "A Gothic style cathedral, conceived by architects Jan and Pierre", Name = "Cathedral of Our Lady" },
                        new { Id = 4, CityId = 2, Description = "The finest example of railway architecture in Belgium.", Name = "Antwerp Central Station" },
                        new { Id = 5, CityId = 3, Description = "A wrought iron lattice tower on the Champ de Mars.", Name = "Eiffel Tower" },
                        new { Id = 6, CityId = 3, Description = "The world's largest museum.", Name = "The Louvre" },
                        new { Id = 7, CityId = 4, Description = "Some say you can find ghosts inside.", Name = "Old Idaho State Penitentiary" },
                        new { Id = 8, CityId = 4, Description = "Located in the heart of downtown Boise. An interesting culture indeed.", Name = "The Basque Musuem & Cultural Center" }
                    );
                });

            modelBuilder.Entity("CityInfo.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.API.Entities.City", "City")
                        .WithMany("PointOfInterests")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
