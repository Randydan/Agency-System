import { AsyncPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DepartmentService } from '../../services/department.service';
import { Departments } from '../../Types/department';
import { RouterLink } from '@angular/router';
import { response } from 'express';

@Component({
  selector: 'app-department',
  standalone: true,
  imports: [FormsModule, AsyncPipe, RouterLink],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent implements OnInit{
  departments: Departments[] = []

  ngOnInit(): void {
  this.getDepartments();
  }

  delete(id:number){
    this.departmentService.deletedeparment(id).subscribe({
      next:(response)=>{
        console.log(response);
        this.getDepartments();
      }
    })
  }

  get(id:number){
    this.departmentService.getdepartmentmethod(id).subscribe({
      next:(response)=>{
        console.log(response);
      },
      error:err=>{
        console.log(err);
      }
    })
  }

  private getDepartments(): void{
    this.departmentService.getdepartments().subscribe({
      next:(department)=>{
        this.departments = department;
      }
    })
  }

  departmentService = inject(DepartmentService);
  }

