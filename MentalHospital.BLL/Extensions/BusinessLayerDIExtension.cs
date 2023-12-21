namespace MentalHospital.BLL.Extensions;

public static class BusinessLayerDIExtension
{
	public static void AddBusinessLayer(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IGenericService<PatientModel>, PatientService>();
		services.AddDataAccess(config);
	}
}