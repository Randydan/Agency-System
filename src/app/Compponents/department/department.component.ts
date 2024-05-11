import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-department',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent {

  departmentobj: Department;

  constructor(){
    this.departmentobj = new Department();
  }
}

export class Department{
  Name: string; 
  Description: string; 
  Courses: string; 
  Students: string; 
  Lecturers: string; 

  constructor(){
    this.Name ='';
    this.Description = '';
    this.Courses ='';
    this.Students ='';
    this.Lecturers='';
  }
  
}
