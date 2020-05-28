using System;
using System.IO;
using DataRepo.Controllers.Domain;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DataRepo.Controllers.Configuration
{
    public class EFContext : DbContext
    {
        private readonly string connectionString;

        public EFContext(string connectionString)
        {
            this.connectionString = connectionString;

            this.Database.EnsureCreated();
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Users> Assets { get; set; }

    }
}
