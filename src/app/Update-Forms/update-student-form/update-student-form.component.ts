import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { StudentService } from '../../services/student.service';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './update-student-form.component.html',
  styleUrl: './update-student-form.component.css'
})
export class UpdateStudentFormComponent implements OnInit{

  form!: FormGroup;

  studentService=inject(StudentService);

  constructor(private fb: FormBuilder, private activateRouter: ActivatedRoute){

  }

  onSubmit(){
    this.studentService.addstudent(this.form.value,).subscribe({
      next:(response)=>{
        console.log(response);
      }
    })
  }

  ngOnInit(): void {

    this.activateRouter.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        this.studentService.getstudentsmethod(response['id']).subscribe({
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
