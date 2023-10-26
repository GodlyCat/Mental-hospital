using Microsoft.EntityFrameworkCore;

namespace MentalHospital.DAL.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("connectionString");
        }
    }
}
