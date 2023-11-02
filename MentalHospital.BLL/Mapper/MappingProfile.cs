using AutoMapper;
using MentalHospital.DAL.Entities;
using MentalHospital.BLL.Models;

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
