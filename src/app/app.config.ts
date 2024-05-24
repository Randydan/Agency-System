import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { HttpClientModule, provideHttpClient, withFetch } from '@angular/common/http';
import { importProvidersFrom } from '@angular/core';
import { routes } from './app.routes';
import { provideClientHydration } from '@angular/platform-browser';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AdministratorComponent } from './Compponents/administrator/administrator.component';
import { ClassroomComponent } from './Compponents/classroom/classroom.component';
import { CourseComponent } from './Compponents/course/course.component';
import { DepartmentComponent } from './Compponents/department/department.component';
import { LecturerComponent } from './Compponents/lecturer/lecturer.component';
import { OfficeComponent } from './Compponents/office/office.component';
import { StudentComponent } from './Compponents/student/student.component';
import { provideToastr } from 'ngx-toastr';

  NgModule({
  declarations:[
    AdministratorComponent,
    ClassroomComponent,
    CourseComponent,
    DepartmentComponent,
    LecturerComponent,OfficeComponent,StudentComponent
  ],
  imports:[
    BrowserModule,
    HttpClientModule
  ]
})
export const appConfig: ApplicationConfig = {
  providers: [provideRouter(routes), 
    provideClientHydration(), 
    provideHttpClient(withFetch()),
    importProvidersFrom(HttpClientModule),
    provideHttpClient(),
    provideToastr(),
  ]
};
