import { AsyncPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Observable, generate } from 'rxjs';
import { StudentService } from '../../services/student.service';
import { Students } from '../../Types/student';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-student',
  standalone: true,
  imports: [FormsModule, AsyncPipe, RouterLink],
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent implements OnInit{

  students: Students[] = [];

  ngOnInit(): void {
    this.getStudents();
  }

  private getStudents():void{
    this.studentService.getstudents().subscribe({
      next:(student)=>{
        this.students = student
      }
    })
  }

  delete(id:number){
    this.studentService.deletestudent(id).subscribe({
      next:(response)=>{
        console.log(response);
        this.getStudents();
      }
    })
  }

  get(id:number){
    this.studentService.getstudentsmethod(id).subscribe({
      next:(response)=>{
        console.log(response);
        
      }
    })
  }

  studentService = inject(StudentService);
  }
