import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ClassroomService } from '../../services/classroom.service';
import { Classrooms } from '../../Types/classroom';
import { inject } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-classroom',
  standalone: true,
  imports: [FormsModule, AsyncPipe,RouterLink],
  templateUrl: './classroom.component.html',
  styleUrl: './classroom.component.css'
})
export class ClassroomComponent implements OnInit{

  classrooms: Classrooms[] =[]
  ngOnInit(): void {
    this.classroomService.getclassrooms().subscribe({
      next:(response)=>{
        this.classrooms = response;
      }
    })
  }
  classroomService = inject(ClassroomService);
}