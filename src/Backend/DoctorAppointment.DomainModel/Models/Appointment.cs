using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.DomainModel.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string PatientFirstName { get; set; }

        [Required]
        public string PatientLastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string CellNumber { get; set; }

        [Required]
        public int? DoctorId { get; set; }

        [Required]
        public TimeSpan AvailableTime { get; set; }

    }
}
