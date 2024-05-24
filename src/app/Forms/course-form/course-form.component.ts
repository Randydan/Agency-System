import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { CourseService } from '../../services/course.service';

@Component({
  selector: 'app-course-form',
  standalone: true,
  imports: [ReactiveFormsModule, RouterLink, JsonPipe],
  templateUrl: './course-form.component.html',
  styleUrl: './course-form.component.css'
})
export class CourseFormComponent implements OnInit {
  form!: FormGroup;
  
  courseService= inject(CourseService);

  constructor(private fb:FormBuilder){

  }
  
  onSubmit(){
    this.courseService.addcourse(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);

      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {

    this.form = this.fb.group({
      name: [], 
      description: [], 
      code: [],
      department: []
    });
  }

}
