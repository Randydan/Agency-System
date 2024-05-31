import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { StudentService } from '../../services/student.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './update-student-form.component.html',
  styleUrl: './update-student-form.component.css'
})
export class UpdateStudentFormComponent implements OnInit{

  form!: FormGroup;
  Id=0;
  studentService=inject(StudentService);


  constructor(private fb: FormBuilder, 
    private activateRouter: ActivatedRoute,
    private route:Router
  ){

  }

  onSubmit(){

    this.form.value.Id = this.Id;
    this.studentService.updatestudent(this.Id, this.form.value).subscribe({
      next:(value)=>{
        console.log(value);
        this.route.navigateByUrl('/student')
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
        this.studentService.getstudentsmethod(routeId).subscribe({
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
      gender: [], 
      dob: [],
      address: [], 
      email: ['', Validators.email], 
      phone: [], 
      status: [], 
      nationality: [], 
      department: [],  
      matricle: []
    })
  }

}
