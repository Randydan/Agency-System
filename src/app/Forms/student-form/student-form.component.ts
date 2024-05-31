import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { StudentService } from '../../services/student.service';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './student-form.component.html',
  styleUrl: './student-form.component.css'
})
export class StudentFormComponent implements OnInit{

  form!: FormGroup;

  studentService=inject(StudentService);

  constructor(private fb: FormBuilder, private router:Router){

  }

  onSubmit(){
    this.studentService.addstudent(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.router.navigateByUrl('/student')
      }
    })
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      name: ['', Validators.required],  
      gender: ['', Validators.required], 
      dob: ['', Validators.required],
      address: ['', Validators.required], 
      email: ['', Validators.email], 
      phone: ['', Validators.required], 
      status: ['', Validators.required], 
      nationality: ['', Validators.required], 
      department: ['', Validators.required],  
      matricle: ['', Validators.required]
    })
  }

}
