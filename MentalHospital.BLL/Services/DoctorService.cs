namespace MentalHospital.BLL.Services;

public class DoctorService : GenericService<DoctorModel, Doctor>, IDoctorService
{
	public DoctorService(IGenericRepository<Doctor> repository, IMapper maper) : base(repository, maper)
	{
	}
}