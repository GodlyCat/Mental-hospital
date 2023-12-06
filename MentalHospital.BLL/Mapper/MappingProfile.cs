namespace MentalHospital.BLL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Patient, PatientModel>().ReverseMap();
        }
    }
}
