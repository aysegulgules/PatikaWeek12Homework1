using Microsoft.EntityFrameworkCore;
using PatikaWeek12Homework1.Models;

namespace PatikaWeek12Homework1.Context
{
    public class PatikaFirstDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-748G4HT2;database=PatikaCodeFirstDb1;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
