using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHospital.BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        Task<T> Get(string id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T model);
        Task<T> Update(T model);
        Task<T> Delete(string id);

    }
}
