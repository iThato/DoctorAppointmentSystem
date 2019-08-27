import { Component, OnInit } from '@angular/core';
import { DoctorService } from '../doctor.service';
import { Doctor } from '../doctor.model';
import { Router } from '@angular/router';
import { AppointmentService } from 'src/app/appointments/appointment.service';
import { BsModalService, BsModalRef } from "ngx-bootstrap/modal";
import { AddModalComponent } from 'src/app/appointments/modals/add-modal/add-modal.component';



@Component({
  selector: 'app-doctor-list',
  templateUrl: './doctor-list.component.html',
  styleUrls: ['./doctor-list.component.css']
})
export class DoctorListComponent implements OnInit {

  bsModalRef : BsModalRef;

  constructor(private service : DoctorService,
    private _router: Router,
    private _appointmentService : AppointmentService,
    private bsModalService : BsModalService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  makeAppointment() {
    this._router.navigate(['/appointment']);
  }

  viewAppointment() {
    this.bsModalService.config.ignoreBackdropClick = false;
    this.bsModalRef = this.bsModalService.show(AddModalComponent);
    this.bsModalRef.content.modalTitle = 'Add New Appointment';
    this.setCloseBtnText();
  }

  setCloseBtnText(){
    this.bsModalRef.content.closeBtnName = 'Close';
  }


}