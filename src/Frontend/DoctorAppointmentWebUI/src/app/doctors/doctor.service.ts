import { Injectable } from '@angular/core';
import { Doctor } from './doctor.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {

  doctor : Doctor;
  doctorList : Doctor[];

  readonly baseUrl = "https://localhost:44335/api/Doctors";

  constructor(private httpClient : HttpClient) { }

  refreshList(){
    var l =this.httpClient.get(this.baseUrl + '/GetAllDoctors')
    .toPromise()
    .then(respond => this.doctorList = respond as Doctor[]);
    console.log(l);
  }
}
