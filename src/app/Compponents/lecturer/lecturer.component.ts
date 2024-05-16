import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ClassroomService } from '../../services/classroom.service';
import { Observable } from 'rxjs';
import { Classrooms } from '../../Types/classroom';
import { AsyncPipe } from '@angular/common';
import { Lecturers } from '../../Types/lecturer';
import { LecturerService } from '../../services/lecturer.service';

@Component({
  selector: 'app-lecturer',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './lecturer.component.html',
  styleUrl: './lecturer.component.css'
})
export class LecturerComponent implements OnInit {

  lecturers: Lecturers[] = [];
  ngOnInit(): void {
    this.lecturerService.getlecturers().subscribe({
      next:(lecturer)=>{
        this.lecturers =lecturer;
      }
    })
  }
  lecturerService = inject(LecturerService);
  }

