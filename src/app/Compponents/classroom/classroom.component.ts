import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ClassroomService } from '../../services/classroom.service';
import { Classrooms } from '../../Types/classroom';
import { Observable } from 'rxjs';
import { Inject,inject } from '@angular/core';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-classroom',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './classroom.component.html',
  styleUrl: './classroom.component.css'
})
export class ClassroomComponent implements OnInit{
  ngOnInit(): void {
    this.admin$=this.adminService.getclassrooms()
  }
  adminService = inject(ClassroomService);
  admin$!:Observable<Classrooms[]>
}