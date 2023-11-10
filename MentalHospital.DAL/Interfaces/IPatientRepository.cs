using MentalHospital.DAL.Entities;

namespace MentalHospital.DAL.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient> Get(string id);
        Task<IEnumerable<Patient>> GetAll();
        Task<Patient> Create(Patient entity);
        Task<Patient> Update(Patient entity);
        Task<Patient> Delete(string id);

    }
}
