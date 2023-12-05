using Microsoft.EntityFrameworkCore;

namespace MentalHospital.DAL.Entities
{
    public class ApplicationDbContext : DbContext
    {
	    public DbSet<Doctor> Doctors { get; set; }

		public DbSet<Patient> Patients { get; set; }

        public DbSet<DoctorPatient> DoctorPatients { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
