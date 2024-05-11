import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-course',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent {

  courseobj: Course;
  constructor(){
  this.courseobj = new Course();
}
}

export class Course{
  Name: string; 
  Description: string; 
  Code: string;
  Department: string;
  
  constructor(){

    this.Name='';
    this.Description='';
    this.Code='';
    this.Department='';
  }
}

