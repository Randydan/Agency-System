import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-classroom',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './classroom.component.html',
  styleUrl: './classroom.component.css'
})
export class ClassroomComponent {

  classroomobj: Classroom;

  constructor(){
    this.classroomobj = new Classroom();
  }
}
export class Classroom{
  Name: string;
  Description: string;
  Location: string 

  constructor(){
    this.Description ='';
    this.Name ='';
    this.Location='';
  }
}