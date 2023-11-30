using Microsoft.AspNetCore.Mvc;
using MentalHospital.BLL.Interfaces;
using AutoMapper;
using MentalHospital.API.ViewModels;
using MentalHospital.BLL.Models;

namespace MentalHospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;

        public PatientController(IMapper mapper, IPatientService patientService)
        {
            _mapper = mapper;
            _patientService = patientService;
        }

        [HttpGet("{id}")]
        public async Task<PatientViewModel> Get(string id)
        {
            return _mapper.Map<PatientViewModel>(await _patientService.Get(id));
        }

        [HttpGet]
        public async Task<IEnumerable<PatientViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<PatientViewModel>>(await _patientService.GetAll());
        }

        [HttpPost]
        public async Task<PatientViewModel> Create(PatientViewModel model)
        {
            return _mapper.Map<PatientViewModel>(
                await _patientService.Create(_mapper.Map<PatientModel>(model)));
        }

        [HttpPut]
        public async Task<PatientViewModel> Update(PatientViewModel model)
        {
            return _mapper.Map<PatientViewModel>(
                await _patientService.Update(_mapper.Map<PatientModel>(model)));
        }

        [HttpDelete]
        public async Task<PatientViewModel> Delete(string id)
        {
            return _mapper.Map<PatientViewModel>(await _patientService.Delete(id));
        }
    }
}
