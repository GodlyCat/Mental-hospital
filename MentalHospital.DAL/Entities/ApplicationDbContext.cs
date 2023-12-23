namespace MentalHospital.DAL.Entities;

public class ApplicationDbContext : DbContext
{
	public DbSet<Doctor> Doctors { get; set; }

	public DbSet<Patient> Patients { get; set; }

	public DbSet<Session> Sessions { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}
}