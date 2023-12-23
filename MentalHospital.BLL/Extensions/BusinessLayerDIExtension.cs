namespace MentalHospital.BLL.Extensions;

public static class BusinessLayerDIExtension
{
	public static void AddBusinessLayer(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IDoctorService, DoctorService>();

		services.AddScoped<IPatientService, PatientService>();

		services.AddScoped<ISessionService, SessionService>();

		services.AddDataAccess(config);
	}
}