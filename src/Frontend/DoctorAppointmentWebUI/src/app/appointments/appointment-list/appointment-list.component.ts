import { Component, OnInit } from '@angular/core';
import { BsModalService, BsModalRef } from "ngx-bootstrap/modal";
import { AppointmentService } from '../appointment.service';
import { Appointment } from '../appointment.model';
import { AddModalComponent } from '../modals/add-modal/add-modal.component';
import { DeleteModalComponent } from '../modals/delete-modal/delete-modal.component';

@Component({
  selector: 'app-appointment-list',
  templateUrl: './appointment-list.component.html',
  styleUrls: ['./appointment-list.component.css']
})
export class AppointmentListComponent implements OnInit {

  bsModalRef : BsModalRef;
  constructor(private service : AppointmentService,
    private bsModalService : BsModalService) { }

  ngOnInit() {
    this.service.refreshList();
  }

  openInsertUpdateModal() {
    this.bsModalService.config.ignoreBackdropClick = true;
    this.bsModalRef = this.bsModalService.show(AddModalComponent);
    this.bsModalRef.content.modalTitle = 'Add New Appointment';
    this.setCloseBtnText();
  }

  onDelete(Id: number) {
    this.bsModalService.config.ignoreBackdropClick = true;
    this.bsModalRef = this.bsModalService.show(DeleteModalComponent);
    this.bsModalRef.content.Id = Id;
  }

  setCloseBtnText(){
    this.bsModalRef.content.closeBtnName = 'Close';
  }

}
