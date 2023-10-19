using JuliePro.Models;
using JuliePro.Models.Data;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed
            builder.GenerateData();
        }

    }
}