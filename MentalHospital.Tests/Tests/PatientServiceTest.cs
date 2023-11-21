using MentalHospital.BLL.Tests.Data.Entities;
using MentalHospital.BLL.Tests.Data.Models;


namespace MentalHospital.BLL.Tests
{
    public class CrudOperationTests_PatientService
    {
        private readonly PatientService patientService;
        private readonly Mock<IPatientRepository> mockPatientRepository;

        public CrudOperationTests_PatientService()
        {
            var mockMapper = new Mock<IMapper>();
            mockPatientRepository = new Mock<IPatientRepository>();

            mockMapper.Setup(mp => mp.Map<PatientModel>(It.IsAny<Patient>())).Returns(PatientModelData.InitPatientModel());
            mockMapper.Setup(mp => mp.Map<IEnumerable<PatientModel>>(It.IsAny<IEnumerable<Patient>>())).Returns(PatientModelData.InitPatientCollection());
            mockMapper.Setup(mp => mp.Map<Patient>(It.IsAny<PatientModel>())).Returns(PatientEntityData.InitPatientEntity());

            patientService = new PatientService(mockPatientRepository.Object, mockMapper.Object);
        }

        [Fact]
        public async Task Creaate_InputPatientModel_ReturnExpectedModel()
        {
            var patientModel = PatientModelData.InitPatientModel();
            mockPatientRepository.Setup(rep => rep.Create(It.IsAny<Patient>()))
                .ReturnsAsync(PatientEntityData.InitPatientEntity());

            var result = await patientService.Create(patientModel);

            mockPatientRepository.Verify(rep => rep.Create(It.IsAny<Patient>()));
            result.Name.ShouldBeEquivalentTo(patientModel.Name);
        }

        [Fact]
        public async Task Delete_InputPatientModel_ReturnExpectedModel()
        {
            mockPatientRepository.Setup(rep => rep.Delete(It.IsAny<string>()))
                .ReturnsAsync(PatientEntityData.InitPatientEntity());

            var result = await patientService.Delete("AnyID");

            mockPatientRepository.Verify(rep => rep.Delete(It.IsAny<string>()));
            result.Name.ShouldBeEquivalentTo(PatientModelData.InitPatientModel().Name);
        }

        [Fact]
        public async Task Get_InputSomeString_ReturnExpectedModel()
        {
            mockPatientRepository.Setup(rep => rep.Get(It.IsAny<string>()))
                .ReturnsAsync(PatientEntityData.InitPatientEntity());

            var result = await patientService.Get("AnyID");

            mockPatientRepository.Verify(rep => rep.Get(It.IsAny<string>()));
            result.Name.ShouldBeEquivalentTo(PatientModelData.InitPatientModel().Name);
        }

        [Fact]
        public async Task GetAll_CommonInvoking_NotEmptyList()
        {
            var patientModel = PatientModelData.InitPatientModel();
            mockPatientRepository.Setup(rep => rep.GetAll())
                .ReturnsAsync(PatientEntityData.InitPatientCollection());

            var result = await patientService.GetAll();

            mockPatientRepository.Verify(rep => rep.GetAll());
            result.FirstOrDefault(p => p.Name == patientModel.Name).ShouldNotBeNull();
        }

        [Fact]
        public async Task Update_InputPatientModel_ReturnExpectedModel()
        {
            var patientModel = PatientModelData.InitPatientModel();
            mockPatientRepository.Setup(rep => rep.Update(It.IsAny<Patient>()))
                .ReturnsAsync(PatientEntityData.InitPatientEntity());

            var result = await patientService.Update(patientModel);

            mockPatientRepository.Verify(rep => rep.Update(It.IsAny<Patient>()));
            result.Name.ShouldBeEquivalentTo(patientModel.Name);
        }
    }
}