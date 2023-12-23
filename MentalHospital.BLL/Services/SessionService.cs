namespace MentalHospital.BLL.Services;

public class SessionService : GenericService<SessionModel, Session>, ISessionService
{
	public SessionService(IGenericRepository<Session> repository, IMapper mapper) : base(repository, mapper)
	{
	}
}