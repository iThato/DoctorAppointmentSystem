using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoctorAppointment.BusinessLogic.Abstract;
using DoctorAppointment.DomainModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly Apointment _appointment;

        public AppointmentsController(Apointment appointment)
        {
            this._appointment = appointment;
        }

        // GET: api/Appointments
        [HttpGet("GetAllAppointments")]
        public ActionResult<IEnumerable<Apointment>> Get()
        {
            var appointments = _appointment.GetAllAppointment();
            return Ok(appointments);
        }

        // GET: api/Appointment/5
        [HttpGet("GetAppointmentById/{appointmentId}")]
        public ActionResult<Apointment> Get(int appointmentId)
        {
            var appointment = _appointment.GetAppointmentByID(appointmentId);
            return Ok(appointment);
        }

        // POST: api/Appointment
        [HttpPost("MakeAppointment")]
        public ActionResult Post([FromBody] Appointment appointment)
        {
            _appointment.MakeAppointment(appointment);
            _appointment.Save();
            return Ok();
        }

        // DELETE: api/Appointment/5
        [HttpDelete("CancelAppointment/{appointmentId}")]
        public ActionResult Delete(int appointmentId)
        {
            _appointment.CancelAppointment(appointmentId);
            _appointment.Save();
            return Ok();
        }
    }
}