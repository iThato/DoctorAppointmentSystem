import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { DoctorListComponent } from './doctors/doctor-list/doctor-list.component';
import { AppointmentListComponent } from './appointments/appointment-list/appointment-list.component';
import { DeleteModalComponent } from './appointments/modals/delete-modal/delete-modal.component';
import { AddModalComponent } from './appointments/modals/add-modal/add-modal.component';
import {  ModalModule } from 'ngx-bootstrap/modal';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModuleModule } from './app-routing.module';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 

@NgModule({
  declarations: [
    AppComponent,
    DoctorListComponent,
    AppointmentListComponent,
    DeleteModalComponent,
    AddModalComponent
  ],
  entryComponents: [
    AddModalComponent,
    DeleteModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModuleModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      timeOut: 5000,
      positionClass: 'toast-bottom-center',
      preventDuplicates: false
    }),
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
