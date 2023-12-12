namespace MentalHospital.DAL.Repositories;

public class PatientRepository(ApplicationDbContext context) : GenericRepository<Patient>(context), IPatientRepository
{
	public override Task<Patient?> Get(Guid id)
	{
		return Set
			.Include(p => p.PersonalDoctor)
			.FirstOrDefaultAsync(p => p.Id == id);
	}

	public override async Task<IEnumerable<Patient>> GetAll()
	{
		return await Set
			.Include(p => p.PersonalDoctor)
			.ToListAsync();
	}
}