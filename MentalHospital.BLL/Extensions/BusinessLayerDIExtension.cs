using MentalHospital.BLL.Interfaces;
using MentalHospital.BLL.Models;
using MentalHospital.BLL.Services;
using MentalHospital.DAL.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MentalHospital.BLL.Extensions
{
    public static class BusinessLayerDIExtension
    {
        public static void AddBusinessLayer(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IService<PatientModel>, PatientService>();
            services.AddDataAccess(config);
        }
    }
}
