using MentalHospital.BLL.Models;
using MentalHospital.DAL.Entities;

namespace MentalHospital.Tests.InitialMethods
{
    public static class PatientInitial
    {
        public static PatientModel InitialPatientModel()
        {
            var patient = new PatientModel()
            {
                Id = Guid.NewGuid().ToString(),
                ChamberNumber = 1,
                RegistredAt = DateTime.Now
            };

            return patient;
        }

        public static Patient InitialPatientEntity()
        {
            var patient = new Patient()
            {
                Id = Guid.NewGuid().ToString(),
                ChamberNumber = 1,
                RegistredAt = DateTime.Now
            };

            return patient;
        }
    }
}
