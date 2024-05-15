import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Observable } from 'rxjs';
import { Classrooms } from '../../Types/classroom';
import { ClassroomService } from '../../services/classroom.service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-office',
  standalone: true,
  imports: [FormsModule, AsyncPipe],
  templateUrl: './office.component.html',
  styleUrl: './office.component.css'
})
export class OfficeComponent implements OnInit {

    ngOnInit(): void {
      this.admin$=this.adminService.getclassrooms()
    }
    adminService = inject(ClassroomService);
    admin$!:Observable<Classrooms[]>
    }