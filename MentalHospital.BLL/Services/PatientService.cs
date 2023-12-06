namespace MentalHospital.BLL.Services;

public class PatientService : IPatientService
{
	private readonly IPatientRepository _repository;
	private readonly IMapper _mapper;

	public PatientService(IPatientRepository repository, IMapper maper)
	{
		_repository = repository;
		_mapper = maper;
	}
        

	public async Task<PatientModel> Create(PatientModel model)
	{
		var entity = await _repository.Create(_mapper.Map<Patient>(model));
		return _mapper.Map<PatientModel>(entity);
	}

	public async Task<PatientModel> Delete(Guid id)
	{
		var entity = await _repository.Delete(id);
		return _mapper.Map<PatientModel>(entity);
	}

	public async Task<PatientModel> Get(Guid id)
	{
		var entity = await _repository.Get(id);
		return _mapper.Map<PatientModel>(entity);
	}

	public async Task<IEnumerable<PatientModel>> GetAll()
	{
		var entities = await _repository.GetAll();
		return _mapper.Map<IEnumerable<PatientModel>>(entities);
	}

	public async Task<PatientModel> Update(PatientModel model)
	{
		var entity = await _repository.Update(_mapper.Map<Patient>(model));
		return _mapper.Map<PatientModel>(entity);
	}
}