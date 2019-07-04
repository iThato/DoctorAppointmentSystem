using DoctorAppointment.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorAppointment.BusinessLogic.Abstract
{
    public interface Apointment
    {
        IEnumerable<Appointment> GetAllAppointment();

        Appointment GetAppointmentByID(int id);

        void MakeAppointment(Appointment appointment);

        void UpdateAppointment(Appointment appointment);

        void CancelAppointment(int id);

        void Save();
    }
}
