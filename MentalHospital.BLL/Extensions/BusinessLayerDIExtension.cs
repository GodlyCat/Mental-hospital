namespace MentalHospital.BLL.Extensions;

public static class BusinessLayerDIExtension
{
	public static void AddBusinessLayer(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IGenericService<PatientModel>, GenericService<PatientModel,Patient>>();
		services.AddDataAccess(config);
	}
}