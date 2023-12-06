namespace MentalHospital.DAL.Interfaces
{
    public interface IPatientRepository
    {
        Task<Patient> Get(Guid id);
        Task<IEnumerable<Patient>> GetAll();
        Task<Patient> Create(Patient entity);
        Task<Patient> Update(Patient entity);
        Task<Patient> Delete(Guid id);

    }
}
