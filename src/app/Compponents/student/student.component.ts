import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { generate } from 'rxjs';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent {
  studentobj:Student;
  constructor(){
    this.studentobj = new Student();
  }
}

export class Student{
  Name: string;  
  Gender: string; 
  DOB: string;
  Address: string; 
  Email: string; 
  Phone:number; 
  Status: string; 
  Nationality: string; 
  Department: string;  
  Matricle: string;
  
  constructor(){
    this.Name='';
    this.Gender='';
    this.DOB='';
    this.Address='';
    this.Email='';
    this.Phone= 0;
    this.Status='';
    this.Nationality='';
    this.Department='';
    this.Matricle='';
  }
}
