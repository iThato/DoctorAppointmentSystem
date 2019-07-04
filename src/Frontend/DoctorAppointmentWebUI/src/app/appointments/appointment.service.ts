import { Injectable } from '@angular/core';
import { Appointment } from './appointment.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  appointment : Appointment;
  appointmentList : Appointment[];

  readonly baseUrl = "https://localhost:44335/api/Appointments"; 

  constructor(private httpClient : HttpClient) { }

  getAppointmentById(id : number){
    return this.httpClient.get(this.baseUrl + '/GetAppointmentById/'+ id);
  }

  MakeAppointment(appointment : Appointment){
    console.log(appointment.Id);
    return this.httpClient.post(this.baseUrl + '/MakeAppointment', appointment);
  }

  updateAppointment(appointment : Appointment){
    console.log(appointment);
    return this.httpClient.put(this.baseUrl + '/UpdateAppointment', appointment);
  }

  deleteAppointment(Id : number){
    console.log(Id);
    return this.httpClient.delete(this.baseUrl + '/CancelAppointment/'+ Id);
  } 

  refreshList(){
    var l =this.httpClient.get(this.baseUrl + '/GetAllAppointments')
    .toPromise()
    .then(respond => this.appointmentList = respond as Appointment[]);
    console.log(l);
  }

}
