using DoctorAppointment.BusinessLogic.Abstract;
using DoctorAppointment.DomainModel.Models;
using DoctorAppointment.Testing.DoctorTesting;
using DoctorAppointmentSystem.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DoctorAppointment.Testing.DoctorTesting
{
    public class DoctorTesting
    {
        IDoctor _doctorService;
        DoctorsController _doctorControl;

        public DoctorTesting()
        {
            _doctorService = new DoctorHerlperService();
            _doctorControl = new DoctorsController(_doctorService);
        }

        [Fact]
        public void GetAllLearnersPassTest()
        {
            // Act
            var okResult = _doctorControl.Get().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Doctor>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
