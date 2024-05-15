import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Classrooms } from '../../Types/classroom';
import { inject } from '@angular/core';
import { Observable } from 'rxjs';
import { CourseService } from '../../services/course.service';
import { Courses } from '../../Types/course';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-course',
  standalone: true,
  imports: [FormsModule,AsyncPipe],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent implements OnInit{
  ngOnInit(): void {
    
    this.admin$=this.adminService.getcourses()
  }
  adminService = inject(CourseService);
  admin$!:Observable<Courses[]>

  
}

