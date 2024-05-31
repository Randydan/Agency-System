import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { CourseService } from '../../services/course.service';

@Component({
  selector: 'app-course-form',
  standalone: true,
  imports: [ReactiveFormsModule, RouterLink, JsonPipe],
  templateUrl: './update-course-form.component.html',
  styleUrl: './update-course-form.component.css'
})
export class UpdateCourseFormComponent implements OnInit {
  form!: FormGroup;
  Id=0;
  courseService= inject(CourseService);

  constructor(private fb:FormBuilder,
    private activateRouter: ActivatedRoute,
    private route:Router
  ){

  }
  
  onSubmit(){

    this.form.value.Id = this.Id;

    this.courseService.updatecourse(this.Id, this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.route.navigateByUrl('/course');
      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {

    this.activateRouter.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        let routeId = response['id'];
        this.Id=routeId;
        if(!routeId) return;
        this.courseService.getcoursemethod(routeId).subscribe({
          next:(response)=>{
            this.form.patchValue(response);
          },

          error:err=>{
            console.log(err);
          }
        })
      },
      error:err=>{
        console.log(err);
      } 
    })

    this.form = this.fb.group({
      name: [], 
      description: [], 
      code: [],
      department: []
    });
  }

}
