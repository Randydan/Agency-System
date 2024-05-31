import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { DepartmentService } from '../../services/department.service';
import { response } from 'express';

@Component({
  selector: 'app-department-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './update-department-form.component.html',
  styleUrl: './update-department-form.component.css'
})
export class UpdateDepartmentFormComponent implements OnInit{
  form!: FormGroup
  Id = 0;
  departmentService = inject(DepartmentService);

  constructor(private fb:FormBuilder,
    private activateRouter: ActivatedRoute,
    private route:Router
  ){

  }

  onSubmit(){

    this.form.value.Id = this.Id;

    this.departmentService.updatedepartment(this.Id, this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.route.navigateByUrl('/department');

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
        let routeId = response ['id'];
        this.Id = routeId;

        if(!routeId) return;

    this.departmentService.getdepartmentmethod(routeId).subscribe({
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
      courses: [], 
      students: [], 
      lecturers: [] 
    })
  }

}
