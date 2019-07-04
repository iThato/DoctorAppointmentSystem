using DoctorAppointment.DomainModel.Context;
using DoctorAppointment.Persistence.IGenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorAppointment.Persistence.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DoctorAppointmentSystemContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new DoctorAppointmentSystemContext();
            table = _context.Set<T>();
        }

        public GenericRepository(DoctorAppointmentSystemContext _Context)
        {
            this._context = _Context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetByID(object id)
        {
            return table.Find(id);
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
