using JuliePro.Models;
using Microsoft.EntityFrameworkCore;


//namespace JuliePro.Models
//{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {
        }

        // Ajout de DbSet pour les entités
        public DbSet<Speciality> Specialities { get; set; }

        // Seed des spécialités
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

            //// Alternative (longue)
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            //builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });
        }
    }
//}

