namespace MentalHospital.BLL.Extensions;

public static class BusinessLayerDIExtension
{
	public static void AddBusinessLayer(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IPatientService, PatientService>();
		services.AddDataAccess(config);
	}
}