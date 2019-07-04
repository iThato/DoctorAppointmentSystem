import { Component, OnInit } from '@angular/core';
import { BsModalRef, BsModalService, ModalModule } from 'ngx-bootstrap/modal';
import { AppointmentService } from '../../appointment.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-modal',
  templateUrl: './add-modal.component.html',
  styleUrls: ['./add-modal.component.css']
})
export class AddModalComponent implements OnInit {

  bsModalRef: BsModalRef;
  showModal: boolean = true;

  constructor(private service : AppointmentService,
    private  bsModalService : BsModalService,
    private _router: Router) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.resetForm();
    }

    this.service.appointment = {
      Id : null,
      PatientFirstName : null,
      PatientLastName : null,  
      Email : null,
      CellNumber : null,
      DoctorId : null,
      AvailableTime : null
    }
  }

  saveAppointment(form: NgForm) {
    if (form.value.Id == null) {
      this.makeAppointment(form);
    } 
  }

  makeAppointment(form: NgForm) {
    this.service.MakeAppointment(form.value).subscribe(res => {
      this.hideModalAndRefresh(form);
    });
  }

  updateAppointment(form: NgForm) {
    this.service.updateAppointment(form.value).subscribe(res => {
      this.hideModalAndRefresh(form);
    });
  }

  hideModalAndRefresh(form: NgForm) {
    this.resetForm(form);
    document.body.classList.remove("modal-open");
    this.service.refreshList();
    this.bsModalService.hide(1);
  }

  onClose() {
    this.bsModalService.hide(1);
    document.body.classList.remove("modal-open");
    this.service.refreshList();
    this._router.navigate(['/startUp']);
  }

}
