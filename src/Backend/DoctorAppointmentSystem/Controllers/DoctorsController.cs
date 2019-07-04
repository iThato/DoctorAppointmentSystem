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
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctor _doctor;

        public DoctorsController(IDoctor doctor)
        {
            this._doctor = doctor;
        }

        // GET: api/Doctors
        [HttpGet("GetAllDoctors")]
        public ActionResult<IEnumerable<Doctor>> Get()
        {
            var doctors = _doctor.GetAllDoctor();
            return Ok(doctors);
        }

        // GET: api/Doctor/5
        [HttpGet("GetDoctorById/{doctorId}")]
        public ActionResult<Appointment> Get(int doctorId)
        {
            var doctor = _doctor.GetDoctorByID(doctorId);
            return Ok(doctor);
        }

        // cancel
    }
}