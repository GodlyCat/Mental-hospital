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
        private Mock<IPatientRepository> MockPatientRep = new Mock<IPatientRepository>();

        private readonly string notAssignedMsg = "Method returned value is not assingable with expected type";
        private readonly string isNullMsg = "Method returns null value";

        [Fact]
        public void CreaateReturnValue()
        {
            //Arrange
            var pModel = InitialPatientModel();
            MockPatientRep.Setup(pRep => pRep.Create(It.IsAny<Patient>()))
                .Returns<Task<Patient>>(patient => patient);
            var pService = new PatientService(MockPatientRep.Object, mapper);

            //Act
            var result = pService.Create(pModel);

            //Assert
            result.ShouldNotBeNull(isNullMsg);
            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
            
        }

        [Fact]
        public void DeleteReturnValue()
        {
            //Arrange
            var pEntity = InitialPatientEntity();
            MockPatientRep.Setup(rep => rep.Delete(It.IsAny<string>()))
                .ReturnsAsync(pEntity);
            var pService = new PatientService(MockPatientRep.Object, mapper);

            //Act
            var result = pService.Delete("AnyID");

            //Assert
            result.ShouldNotBeNull(isNullMsg);
            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
        }

        [Fact]
        public void GetReturnValue()
        {
            //Arrange
            var pEntity = InitialPatientEntity();
            MockPatientRep.Setup(rep => rep.Get(It.IsAny<string>()))
                .ReturnsAsync(pEntity);
            var pService = new PatientService(MockPatientRep.Object, mapper);

            //Act
            var result = pService.Get("AnyID");

            //Assert
            result.ShouldNotBeNull(isNullMsg);
            result.ShouldBeAssignableTo<Task<PatientModel>>(notAssignedMsg);
        }

        [Fact]
        public void GetAllReturnValue()
        {
            //Arrange
            var pEntity = InitialPatientEntity();
            MockPatientRep.Setup(rep => rep.GetAll())
                .ReturnsAsync(new List<Patient>(){
                    pEntity
                });
            var pService = new PatientService(MockPatientRep.Object, mapper);

            //Act
            var result = pService.GetAll();

            //Assert
            result.ShouldNotBeNull(isNullMsg);
            result.ShouldBeAssignableTo<Task<IEnumerable<PatientModel>>>(notAssignedMsg);
        }

        [Fact]
        public void UpdateReturnValue()
        {
            //Arrange
            var pModel = InitialPatientModel();
            MockPatientRep.Setup(rep => rep.Update(It.IsAny<Patient>()))
                .Returns<Task<Patient>>(patient => patient);
            var pService = new PatientService(MockPatientRep.Object, mapper);

            //Act
            var result = pService.Update(pModel);

            //Assert
            result.ShouldNotBeNull(isNullMsg);
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