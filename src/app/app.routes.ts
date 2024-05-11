import { Routes } from '@angular/router';
import { LandingpageComponent } from './Compponents/landingpage/landingpage.component';
import { AdministratorComponent } from './Compponents/administrator/administrator.component';
import { ClassroomComponent } from './Compponents/classroom/classroom.component';
import { CourseComponent } from './Compponents/course/course.component';
import { DepartmentComponent } from './Compponents/department/department.component';
import { LecturerComponent } from './Compponents/lecturer/lecturer.component';
import { OfficeComponent } from './Compponents/office/office.component';
import { StudentComponent } from './Compponents/student/student.component';

export const routes: Routes = [
    {
        path: '', redirectTo:'administrator', pathMatch: 'full'
    },

    {
        path:'administrator',
        component:AdministratorComponent,
        children:[
            {
                path:'administrator',
                component:AdministratorComponent
            },

            {
                path:'classroom',
                component:ClassroomComponent,
            },

            {
                path:'course',
                component:CourseComponent,
            },

            {
                path:'department',
                component:DepartmentComponent,
            },

            {
                path:'lecturer',
                component:LecturerComponent,
            },

            {
                path:'office',
                component:OfficeComponent,
            },

            {
                path:'student',
                component:StudentComponent,
            }

        ]   
    },
];