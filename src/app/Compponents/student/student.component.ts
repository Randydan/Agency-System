import { AsyncPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Observable, generate } from 'rxjs';
import { StudentService } from '../../services/student.service';
import { Students } from '../../Types/student';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent implements OnInit{

  students: Students[] = []
  ngOnInit(): void {
    this.studentService.getstudents().subscribe({
      next:(student)=>{
        this.students = student
      }
    })
  }
  studentService = inject(StudentService);
  }
