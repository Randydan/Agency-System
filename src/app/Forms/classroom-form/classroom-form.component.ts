import { JsonPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { inject } from '@angular/core';
import { ClassroomService } from '../../services/classroom.service';

@Component({
  selector: 'app-classroom-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './classroom-form.component.html',
  styleUrl: './classroom-form.component.css'
})
export class ClassroomFormComponent implements OnInit{

  form!: FormGroup;

  classroomService = inject(ClassroomService);

  constructor(private fb: FormBuilder){

  }

  onSubmit(){
    this.classroomService.addclassroom(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);

      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {
    this.form= this.fb.group({
    name: [],
    description: [],
    location: []
    })
  }

}
