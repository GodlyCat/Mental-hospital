﻿namespace MentalHospital.BLL.Interfaces
{
    interface IService<T> where T : class
    {
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Create(T model);
        Task<T> Update(T model);
        Task<T> Delete(Guid id);
    }
}
