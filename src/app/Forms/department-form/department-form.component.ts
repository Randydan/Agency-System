import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { DepartmentService } from '../../services/department.service';

@Component({
  selector: 'app-department-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './department-form.component.html',
  styleUrl: './department-form.component.css'
})
export class DepartmentFormComponent implements OnInit{
  form!: FormGroup

  departmentService = inject(DepartmentService);

  constructor(private fb:FormBuilder){

  }

  onSubmit(){
    this.departmentService.addDepartment(this.form.value).subscribe({
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
      courses: [], 
      students: [], 
      lecturers: [] 
    })
  }

}
