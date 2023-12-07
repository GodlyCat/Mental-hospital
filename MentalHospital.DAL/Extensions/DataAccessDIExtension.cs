namespace MentalHospital.DAL.Extensions;

public static class DataAccessDIExtension
{
	public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
	{
		services.AddDbContext<ApplicationDbContext>(options =>
		{
			options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
		});

		services.AddScoped<IPatientRepository, PatientRepository>();
	}
}