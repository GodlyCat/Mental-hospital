namespace MentalHospital.BLL.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile() 
	{
		CreateMap<Patient, PatientModel>().ReverseMap();

		CreateMap<Doctor, DoctorModel>().ReverseMap();

		CreateMap<Session, SessionModel>().ReverseMap();
	}
}