using MentalHospital.DAL.Entities;
using MentalHospital.DAL.interfaces;
using MentalHospital.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MentalHospital.DAL.Extensions
{
    public static class DataAccessDIExtension
    {
        public static void AdddataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(config.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IRepository<Patient>, PatientRepository>();
        }
    }
}
