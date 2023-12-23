namespace MentalHospital.BLL.Interfaces;

public interface IGenericService<T> where T : class
{
	Task<T> Get(Guid id);
	Task<IEnumerable<T>> GetAll();
	Task<T> Create(T model);
	Task<T> Update(T model);
	Task<T> Delete(Guid id);
}