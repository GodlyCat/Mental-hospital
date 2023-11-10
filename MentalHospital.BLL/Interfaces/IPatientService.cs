using MentalHospital.BLL.Models;

namespace MentalHospital.BLL.Interfaces
{
    public interface IPatientService
    {
        Task<PatientModel> Get(string id);
        Task<IEnumerable<PatientModel>> GetAll();
        Task<PatientModel> Create(PatientModel model);
        Task<PatientModel> Update(PatientModel model);
        Task<PatientModel> Delete(string id);

    }
}
