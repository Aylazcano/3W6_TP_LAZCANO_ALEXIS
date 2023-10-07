using JuliePro.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace JuliePro.Models
{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {
        }

        // Ajout de DbSet pour les entités
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Objective> Objectives { get; set; }

        // Seed
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        
            // Alternative (courte)
            builder.Entity<Speciality>().HasData(
                new Speciality() { Id = 1, Name = "Perte de poids" },
                new Speciality() { Id = 2, Name = "Course" },
                new Speciality() { Id = 3, Name = "Halthérophilie" },
                new Speciality() { Id = 4, Name = "Réhabilitation" }
                );

            builder.Entity<Trainer>().HasData(
                new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" },
                new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" },
                new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" },
                new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" },
                new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" },
                new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" },
                new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" }
                );

            builder.Entity<Customer>().HasData(
                new Customer() { Id = 1, FirstName = "Valérie", LastName = "Turgeon", Email = "valtur@goodmail.com", TrainerId = 1 },
                new Customer() { Id = 2, FirstName = "Alexis", LastName = "Lazcano", Email = "alelaz@goodmail.com", TrainerId = 1 },
                new Customer() { Id = 3, FirstName = "Emilia", LastName = "Silva", Email = "EmiSil@goodmail.com", TrainerId = 1 }
                );

            builder.Entity<Objective>().HasData(
                new Objective()
                {
                    Id = 1,
                    Name = "Cardio",
                    LostWeightKg = 5.0,
                    DistanceKm = 30.0,
                    CustomerId = 1, // Premier client
                    AchievedDate = DateTime.Now.AddMonths(-6) // Objectif complété
                },
                new Objective()
                {
                    Id = 2,
                    Name = "Force",
                    LostWeightKg = 3.0,
                    DistanceKm = 35.0,
                    CustomerId = 1, // Premier client
                    AchievedDate = null // Objectif courant
                },
                new Objective()
                {
                    Id = 3,
                    Name = "Natation",
                    LostWeightKg = 4.0,
                    DistanceKm = 40.0,
                    CustomerId = 2, // Deuxième client
                    AchievedDate = null // Objectif courant
                },
                new Objective()
                {
                    Id = 4,
                    Name = "Performance",
                    LostWeightKg = 6.0,
                    DistanceKm = 45.0,
                    CustomerId = 2, // Deuxième client
                    AchievedDate = null // Objectif courant
                },
                new Objective()
                {
                    Id = 5,
                    Name = "Maigrir",
                    LostWeightKg = 8.0,
                    DistanceKm = 45.0,
                    CustomerId = 3, // Troisième client
                    AchievedDate = DateTime.Now.AddMonths(-3) // Objectif complété
                },
                new Objective()
                {
                    Id = 6,
                    Name = "Tonus",
                    LostWeightKg = 7.0,
                    DistanceKm = 20.0,
                    CustomerId = 3, // Troisième client
                    AchievedDate = DateTime.Now.AddMonths(-2) // Objectif complété
                }
            );


            //// Alternative (longue)
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });


            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
            //builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

        }
    }
}