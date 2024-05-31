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
import { UpdateAdministratorFormComponent } from './Update-Forms/update-administrator-form/update-administrator-form.component';
import { UpdateClassroomFormComponent } from './Update-Forms/update-classroom-form/update-classroom-form.component';
import { UpdateCourseFormComponent } from './Update-Forms/update-course-form/update-course-form.component';
import { UpdateLecturerFormComponent } from './Update-Forms/update-lecturer-form/update-lecturer-form.component';
import { UpdateDepartmentFormComponent } from './Update-Forms/update-department-form/update-department-form.component';
import { UpdateOfficeFormComponent } from './Update-Forms/update-office-form/update-office-form.component';
import { UpdateStudentFormComponent } from './Update-Forms/update-student-form/update-student-form.component';

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
                },
                {

                    path:'update-administrator-form/:id',
                    component:UpdateAdministratorFormComponent,
            
                        },
            
                        {
                            path:'update-classroom-form/:id',
                            component:UpdateClassroomFormComponent,
                        },
            
                        {
                            path:'update-course-form/:id',
                            component:UpdateCourseFormComponent,
                        },
            
                        {
                            path:'update-department-form/:id',
                            component:UpdateDepartmentFormComponent,
                        },
            
                        {
                            path:'update-lecturer-form/:id',
                            component:UpdateLecturerFormComponent,
                        },
            
                        {
                            path:'update-office-form/:id',
                            component:UpdateOfficeFormComponent,
                        },
            
                        {
                            path:'update-student-form/:id',
                            component:UpdateStudentFormComponent,
                        },
];