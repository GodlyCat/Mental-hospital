namespace MentalHospital.DAL.Repositories;

public class SessionRepository(ApplicationDbContext context) : GenericRepository<Session>(context), ISessionRepository
{
	public override Task<Session?> Get(Guid id)
	{
		return Set
			.Include(s => s.Doctor)
			.Include(s => s.Patient)
			.FirstOrDefaultAsync(s => s.Id == id);
	}

	public override async Task<IEnumerable<Session>> GetAll()
	{
		return await Set
			.Include(s => s.Doctor)
			.Include(s => s.Patient)
			.ToListAsync();
	}
}