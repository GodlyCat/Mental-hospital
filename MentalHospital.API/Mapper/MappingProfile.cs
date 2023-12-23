namespace MentalHospital.API.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile() 
	{
		CreateMap<DoctorModel, DoctorViewModel>().ReverseMap();

		CreateMap<PatientModel, PatientViewModel>().ReverseMap();

		CreateMap<SessionModel, SessionViewModel>().ReverseMap();
	}
}