using DoctorAppointment.DomainModel.Models;
using DoctorAppointment.Persistence.GenericRepository;
using DoctorAppointment.Persistence.IGenericRepository;
using DoctorAppointment.BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.BusinessLogic.Implemtentation
{
    public class AppointmentImplemetation : Apointment
    {
        private IGenericRepository<Appointment> _repository;

        public AppointmentImplemetation()
        {
            this._repository = new GenericRepository<Appointment>();
        }
        public AppointmentImplemetation(IGenericRepository<Appointment> repository)
        {
            this._repository = repository;
        }
        public IEnumerable<Appointment> GetAllAppointment()
        {
            return _repository.GetAll();
        }

        public Appointment GetAppointmentByID(int id)
        {
            return _repository.GetByID(id);
        }

        public void MakeAppointment(Appointment appointment)
        {
            _repository.Add(appointment);
            _repository.Save();
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _repository.Update(appointment);
            _repository.Save();
        }

        public void CancelAppointment(int id)
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
