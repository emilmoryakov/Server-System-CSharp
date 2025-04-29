using MagaPrimer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;

namespace MagaPrimer.Contexts
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationBuilder builder = new();

            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("LocalConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            var country = modelBuilder.Entity<Person>();

            country.HasKey(x => x.Id);
            country.Property(x => x.Name).IsRequired();
            country.Property(x => x.Surname).IsRequired();
            country.Property(x => x.Age).IsRequired();
        }
    }
}
