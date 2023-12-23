namespace MentalHospital.BLL.Services;

public class SessionService : GenericService<SessionModel, Session>, ISessionService
{
	public SessionService(ISessionRepository repository, IMapper mapper) : base(repository, mapper)
	{
	}
}