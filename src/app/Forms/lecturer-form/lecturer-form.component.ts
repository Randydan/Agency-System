import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { LecturerService } from '../../services/lecturer.service';

@Component({
  selector: 'app-lecturer-form',
  standalone: true,
  imports: [RouterLink, ReactiveFormsModule, JsonPipe],
  templateUrl: './lecturer-form.component.html',
  styleUrl: './lecturer-form.component.css'
})
export class LecturerFormComponent implements OnInit {

  form!: FormGroup; 

  lecturerService = inject(LecturerService);

  constructor(private fb:FormBuilder){

  }

  onSubmit(){
    this.lecturerService.addlecturer(this.form.value).subscribe({
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
      name: ['', Validators.required],  
      gender: ['', Validators.required],
      dob: ['', Validators.required], 
      address: ['', Validators.required],
      email: ['', Validators.email],
      phone: ['', Validators.required],  
      status: ['', Validators.required],
      course: ['', Validators.required],
      salary: ['', Validators.required],
    })
  }

}
