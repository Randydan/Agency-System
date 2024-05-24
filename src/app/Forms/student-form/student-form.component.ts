import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
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

  constructor(private fb: FormBuilder){

  }

  onSubmit(){
    this.studentService.addstudent(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
      }
    })
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      name: [],  
      gender: [], 
      dob: [],
      address: [], 
      email: [], 
      phone: [], 
      status: [], 
      nationality: [], 
      department: [],  
      matricle: []
    })
  }

}
