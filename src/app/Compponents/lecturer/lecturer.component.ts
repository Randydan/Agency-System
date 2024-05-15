import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ClassroomService } from '../../services/classroom.service';
import { Observable } from 'rxjs';
import { Classrooms } from '../../Types/classroom';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-lecturer',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './lecturer.component.html',
  styleUrl: './lecturer.component.css'
})
export class LecturerComponent implements OnInit {
  ngOnInit(): void {
    this.admin$=this.adminService.getclassrooms()
  }
  adminService = inject(ClassroomService);
  admin$!:Observable<Classrooms[]>
  }

