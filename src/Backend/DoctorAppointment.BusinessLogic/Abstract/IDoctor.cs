using DoctorAppointment.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.BusinessLogic.Abstract
{
    public interface IDoctor
    {
        IEnumerable<Doctor> GetAllDoctor();

        Doctor GetDoctorByID(int id);

        void AddDoctor(Doctor doctor);

        void UpdateDoctor(Doctor doctor);

        void DeleteDoctor(int id);

        void Save();
    }
}
