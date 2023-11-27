using AutoMapper;
using MentalHospital.API.ViewModels;
using MentalHospital.BLL.Models;

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
