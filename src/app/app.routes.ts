import { Routes } from '@angular/router';
import { AdministratorComponent } from './Compponents/administrator/administrator.component';
import { ClassroomComponent } from './Compponents/classroom/classroom.component';
import { CourseComponent } from './Compponents/course/course.component';
import { DepartmentComponent } from './Compponents/department/department.component';
import { LecturerComponent } from './Compponents/lecturer/lecturer.component';
import { OfficeComponent } from './Compponents/office/office.component';
import { StudentComponent } from './Compponents/student/student.component';
import { AdministratorFormComponent } from './Forms/administrator-form/administrator-form.component';
import { ClassroomFormComponent } from './Forms/classroom-form/classroom-form.component';
import { CourseFormComponent } from './Forms/course-form/course-form.component';
import { DepartmentFormComponent } from './Forms/department-form/department-form.component';
import { LecturerFormComponent } from './Forms/lecturer-form/lecturer-form.component';
import { OfficeFormComponent } from './Forms/office-form/office-form.component';
import { StudentFormComponent } from './Forms/student-form/student-form.component';

export const routes: Routes = [
    {
        path:'administrator',
        component:AdministratorComponent,

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
            },

            {

            path:'administrator-form',
            component:AdministratorFormComponent,
    
                },
    
                {
                    path:'classroom-form',
                    component:ClassroomFormComponent,
                },
    
                {
                    path:'course-form',
                    component:CourseFormComponent,
                },
    
                {
                    path:'department-form',
                    component:DepartmentFormComponent,
                },
    
                {
                    path:'lecturer-form',
                    component:LecturerFormComponent,
                },
    
                {
                    path:'office-form',
                    component:OfficeFormComponent,
                },
    
                {
                    path:'student-form',
                    component:StudentFormComponent,
                }

];