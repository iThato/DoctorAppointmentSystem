import { Component, OnInit } from '@angular/core';
import { AppointmentService } from '../../appointment.service';
import { BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-delete-modal',
  templateUrl: './delete-modal.component.html',
  styleUrls: ['./delete-modal.component.css']
})
export class DeleteModalComponent implements OnInit {

  Id : number;

  constructor(private  service: AppointmentService,
    private toastr: ToastrService,
    private bsModalService: BsModalService) { }

  ngOnInit() {
  }

  cancelAppointment() {
    this.service.deleteAppointment(this.Id).subscribe(res => {
      this.onClose();
    });
  }

  onClose() {
    this.bsModalService.hide(1);
    document.body.classList.remove("modal-open");
    this.service.refreshList();
  }

}
