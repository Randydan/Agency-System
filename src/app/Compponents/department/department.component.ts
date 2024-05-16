import { AsyncPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DepartmentService } from '../../services/department.service';
import { Departments } from '../../Types/department';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-department',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent implements OnInit{
  departments: Departments[] = []

  ngOnInit(): void {
    this.departmentService.getdepartments().subscribe({
      next:(department)=>{
        this.departments = department;
      }
    })
  }
  departmentService = inject(DepartmentService);
  }

