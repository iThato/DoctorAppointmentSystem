import { Time } from '@angular/common';
import { Doctor } from '../doctors/doctor.model';

export class Appointment {
        Id : number
        PatientFirstName : string
        PatientLastName : string  
        Email : string
        CellNumber : string 
        DoctorId : number
        AvailableTime : Time
        
}
