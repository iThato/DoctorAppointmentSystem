using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.Persistence.IGenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(object id);
        void Add(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
