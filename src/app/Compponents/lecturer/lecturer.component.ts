import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-lecturer',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './lecturer.component.html',
  styleUrl: './lecturer.component.css'
})
export class LecturerComponent {

  lecturerobj: Lecturer;
  constructor(){
    this.lecturerobj = new Lecturer();
  }
}

export class Lecturer{

  Name: string;  
  Gender: string;
  Dob: string; 
  Address: string ;
  Email: string ;
  Phone: number;  
  Status: string ;
  Course: string ;
  Salary: number;
  
  constructor(){
    this.Name ='';
    this.Gender='';
    this.Dob ='';
    this.Address='';
    this.Email='';
    this.Phone= 0;
    this.Status='';
    this.Course='';
    this.Salary= 0;
  }
}
