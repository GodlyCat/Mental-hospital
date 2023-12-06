using MentalHospital.BLL.Models;

namespace MentalHospital.BLL.Interfaces
{
    public interface IPatientService
    {
        Task<PatientModel> Get(Guid id);
        Task<IEnumerable<PatientModel>> GetAll();
        Task<PatientModel> Create(PatientModel model);
        Task<PatientModel> Update(PatientModel model);
        Task<PatientModel> Delete(Guid id);

    }
}
