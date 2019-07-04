import { Component, OnInit } from '@angular/core';
import { DoctorService } from '../doctor.service';
import { Doctor } from '../doctor.model';
import { Router } from '@angular/router';
import { AppointmentService } from 'src/app/appointments/appointment.service';



@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.css']
})
export class DoctorListComponent implements OnInit {

  constructor(private service : DoctorService,
    private _router: Router,
    private _appointmentService : AppointmentService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  makeAppointment() {
    this._router.navigate(['/appointment']);
  }

}