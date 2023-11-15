using Xunit;
using Moq;
using AutoMapper;
using Shouldly;
using MentalHospital.BLL.Mapper;
using MentalHospital.BLL.Models;
using MentalHospital.BLL.Services;
using MentalHospital.DAL.Interfaces;
using MentalHospital.DAL.Entities;
using MentalHospital.Tests.InitialMethods;


namespace MentalHospital.Tests
{
    public class CrudOperationTests_PatientService
    {
        private Mock<IMapper> mockMapper;
        private IMapper mapper;
        private PatientService patientService;
        private readonly PatientModel patientModel = PatientInitial.InitialPatientModel();
        private readonly Patient patientEntity = PatientInitial.InitialPatientEntity();
        private Mock<IPatientRepository> mockPatientRepository = new Mock<IPatientRepository>();

        public CrudOperationTests_PatientService()
        {
            mockMapper = new Mock<IMapper>();
            mockMapper.Setup(mp => mp.Map<PatientModel>(It.IsAny<Patient>())).Returns(patientModel);
            mockMapper.Setup(mp => mp.Map<Patient>(It.IsAny<PatientModel>())).Returns(patientEntity);
            mapper = mockMapper.Object;
            mockPatientRepository.Setup(rep => rep.Create(It.IsAny<Patient>()))
                .ReturnsAsync(patientEntity);
            mockPatientRepository.Setup(rep => rep.Delete(It.IsAny<string>()))
                .ReturnsAsync(patientEntity);
            mockPatientRepository.Setup(rep => rep.Get(It.IsAny<string>()))
                .ReturnsAsync(patientEntity);
            mockPatientRepository.Setup(rep => rep.GetAll())
                .ReturnsAsync(new List<Patient>(){
                    patientEntity
                });
            mockPatientRepository.Setup(rep => rep.Update(It.IsAny<Patient>()))
                .ReturnsAsync(patientEntity);
            patientService = new PatientService(mockPatientRepository.Object, mapper);
        }

        [Fact]
        public async void Creaate_InputPatientModel_RepoMethodCalled()
        {
            var result = await patientService.Create(patientModel);

            mockPatientRepository.Verify(rep => rep.Create(It.IsAny<Patient>()));
        }

        [Fact]
        public async void Delete_InputPatientModel_RepoMethodCalled()
        {
            var result = await patientService.Delete("AnyID");

            mockPatientRepository.Verify(rep => rep.Delete(It.IsAny<string>()));
        }

        [Fact]
        public async void Get_InputSomeString_RepoMethodCalled()
        {
            var result = await patientService.Get("AnyID");

            mockPatientRepository.Verify(rep => rep.Get(It.IsAny<string>()));
        }

        [Fact]
        public async void GetAll_CommonInvoking_RepoMethodCalled()
        {
            var result = await patientService.GetAll();

            mockPatientRepository.Verify(rep => rep.GetAll());
        }

        [Fact]
        public async void Update_InputPatientModel_RepoMethodCalled()
        {
            var result = await patientService.Update(patientModel);

            mockPatientRepository.Verify(rep => rep.Update(It.IsAny<Patient>()));
        }
    }
}