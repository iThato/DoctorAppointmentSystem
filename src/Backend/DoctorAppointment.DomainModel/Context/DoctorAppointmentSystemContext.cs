using System;
using DoctorAppointment.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DoctorAppointment.DomainModel.Context
{
    public partial class DoctorAppointmentSystemContext : DbContext
    {
        public DoctorAppointmentSystemContext()
        {
        }

        public DoctorAppointmentSystemContext(DbContextOptions<DoctorAppointmentSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DVTL7YCNJR2;Database=DoctorAppointmentSystem;Trusted_Connection=True;");
            }
        }
    }
}
