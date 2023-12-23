namespace MentalHospital.BLL.Services;

public class DoctorService : GenericService<DoctorModel, Doctor>, IDoctorService
{
	public DoctorService(IDoctorRepository repository, IMapper mapper) : base(repository, mapper)
	{
	}
}