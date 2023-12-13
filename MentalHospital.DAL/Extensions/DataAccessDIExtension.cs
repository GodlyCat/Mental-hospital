namespace MentalHospital.DAL.Extensions;

public static class DataAccessDIExtension
{
	public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
	{
		services.AddDbContext<ApplicationDbContext>(options =>
		{
			options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
		});

		services.AddScoped<IPatientRepository, PatientRepository>();

		services.AddScoped<IDoctorRepository, DoctorRepository>();
	}
}