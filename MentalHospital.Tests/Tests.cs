using Xunit;
using Moq;
using AutoMapper;
using Shouldly;
using MentalHospital.BLL.Mapper;
using MentalHospital.BLL.Models;
using MentalHospital.BLL.Services;
using MentalHospital.DAL.Interfaces;
using MentalHospital.DAL.Entities;


namespace MentalHospital.Tests
{
    public class Tests
    {
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
        private Mock<IPatientRepository> stubPatientRepository = new Mock<IPatientRepository>();
        private readonly string notAssignedMsg = "Method returned value is not assingable with expected type";

        [Fact]
        public void Creaate_InputPatientModel_ReturnSameType()
        {
            var patientModel = InitialPatientModel();
            stubPatientRepository.Setup(rep => rep.Create(It.IsAny<Patient>()))
                .Returns<Task<Patient>>(patient => patient);
            var patientService = new PatientService(stubPatientRepository.Object, mapper);

            var result = patientService.Create(patientModel);

            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
            
        }

        [Fact]
        public void Delete_InputPatientModel_ReturnSameType()
        {
            var patientEntity = InitialPatientEntity();
            stubPatientRepository.Setup(rep => rep.Delete(It.IsAny<string>()))
                .ReturnsAsync(patientEntity);
            var patientService = new PatientService(stubPatientRepository.Object, mapper);

            var result = patientService.Delete("AnyID");

            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
        }

        [Fact]
        public void Get_InputSomeString_ReturnPatientModel()
        {
            var patientEntity = InitialPatientEntity();
            stubPatientRepository.Setup(rep => rep.Get(It.IsAny<string>()))
                .ReturnsAsync(patientEntity);
            var patientService = new PatientService(stubPatientRepository.Object, mapper);

            var result = patientService.Get("AnyID");

            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
        }

        [Fact]
        public void GetAll_CommonInvoking_ReturnPatientModelCollection()
        {
            var patientEntity = InitialPatientEntity();
            stubPatientRepository.Setup(rep => rep.GetAll())
                .ReturnsAsync(new List<Patient>(){
                    patientEntity
                });
            var patientService = new PatientService(stubPatientRepository.Object, mapper);

            var result = patientService.GetAll();

            result.ShouldBeAssignableTo<Task<IEnumerable<PatientModel>>>(notAssignedMsg);
        }

        [Fact]
        public void Update_InputPatientModel_ReturnSameType()
        {
            var patientModel = InitialPatientModel();
            stubPatientRepository.Setup(rep => rep.Update(It.IsAny<Patient>()))
                .Returns<Task<Patient>>(patient => patient);
            var patientService = new PatientService(stubPatientRepository.Object, mapper);

            var result = patientService.Update(patientModel);

            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
        }

        private PatientModel InitialPatientModel()
        {
            var patient = new PatientModel()
            {
                Id = Guid.NewGuid().ToString(),
                ChamberNumber = 1,
                RegistredAt = DateTime.Now
            };

            return patient;
        }

        private Patient InitialPatientEntity()
        {
            var patient = new Patient()
            {
                Id = Guid.NewGuid().ToString(),
                ChamberNumber = 1,
                RegistredAt = DateTime.Now
            };

            return patient;
        }
    }
}