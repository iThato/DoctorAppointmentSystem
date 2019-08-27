import { AppointmentListComponent } from './appointments/appointment-list/appointment-list.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DoctorListComponent } from './doctors/doctor-list/doctor-list.component';
import { AddModalComponent } from './appointments/modals/add-modal/add-modal.component';


// configuring Routes.
const appRoutes: Routes = [

    { path: 'startUp',
    component : DoctorListComponent
   },

  { 
    path: 'add',
    component : AddModalComponent
  }, 
  
    { path: 'appointment',
     component : AppointmentListComponent
    },

    { path: '', redirectTo : '/startUp', pathMatch: 'full' },
  
  ];

@NgModule({
    imports: [RouterModule.forRoot(appRoutes),],
    exports: [RouterModule]
  })
  export class AppRoutingModuleModule { }