using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.DomainModel.Models
{
    public class Doctor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string DoctorName { get; set; }

        [Required]
        public TimeSpan DoctorAvalableTime { get; set; }

    }
}
