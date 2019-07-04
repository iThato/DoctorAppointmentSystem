using DoctorAppointment.BusinessLogic.Abstract;
using DoctorAppointment.DomainModel.Models;
using DoctorAppointment.Persistence.GenericRepository;
using DoctorAppointment.Persistence.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.BusinessLogic.Implemtentation
{
    public class DoctorImplemetation : IDoctor
    {
        private IGenericRepository<Doctor> _repository;

        public DoctorImplemetation()
        {
            this._repository = new GenericRepository<Doctor>();
        }
        public DoctorImplemetation(IGenericRepository<Doctor> repository)
        {
            this._repository = repository;
        }
        public IEnumerable<Doctor> GetAllDoctor()
        {
            return _repository.GetAll();
        }

        public Doctor GetDoctorByID(int id)
        {
            return _repository.GetByID(id);
        }

        public void AddDoctor(Doctor doctor)
        {
            _repository.Add(doctor);
            _repository.Save();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _repository.Update(doctor);
            _repository.Save();
        }

        public void DeleteDoctor(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
