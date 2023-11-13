using Xunit;
using Moq;
using AutoMapper;
using MentalHospital.BLL.Mapper;
using MentalHospital.BLL.Models;
using MentalHospital.BLL.Services;
using MentalHospital.DAL.Interfaces;
using MentalHospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentalHospital.Tests
{
    public class Tests
    {
        private readonly IMapper mapper = new Mapper(new MapperConfiguration(
            cfg => cfg.AddProfile<MappingProfile>()));
        private Mock<IPatientRepository> MockPatientRep = new Mock<IPatientRepository>();

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
            Assert.IsAssignableFrom<Task<PatientModel>>(result); 
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
            Assert.IsAssignableFrom<Task<PatientModel>>(result);
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
            Assert.IsAssignableFrom<Task<PatientModel>>(result);
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
            Assert.IsAssignableFrom<Task<IEnumerable<PatientModel>>>(result);
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
            Assert.IsAssignableFrom<Task<PatientModel>>(result);
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