using DoctorAppointment.BusinessLogic.Abstract;
using DoctorAppointment.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.Testing.DoctorTesting
{
    public class DoctorHerlperService : IDoctor
    {
        private readonly List<Doctor> _doctors;
        public DoctorHerlperService()
        {

            _doctors = new List<Doctor>()
            {
                new Doctor() { Id = 1, DoctorName = "KG", DoctorAvalableTime = TimeSpan.Parse("07:35") },
                new Doctor() { Id = 2, DoctorName = "Ike", DoctorAvalableTime = TimeSpan.Parse("09:35") },
                new Doctor() { Id = 3, DoctorName = "Thato", DoctorAvalableTime = TimeSpan.Parse("12:00") }
            };
        }

        public IEnumerable<Doctor> GetAllDoctor()
        {
            return _doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctorByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
