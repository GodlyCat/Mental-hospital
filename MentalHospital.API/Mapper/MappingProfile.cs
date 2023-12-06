namespace MentalHospital.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<PatientModel, PatientViewModel>().ReverseMap();
        }
    }
}
