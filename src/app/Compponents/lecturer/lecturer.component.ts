import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AsyncPipe } from '@angular/common';
import { Lecturers } from '../../Types/lecturer';
import { LecturerService } from '../../services/lecturer.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-lecturer',
  standalone: true,
  imports: [FormsModule, AsyncPipe, RouterLink],
  templateUrl: './lecturer.component.html',
  styleUrl: './lecturer.component.css'
})
export class LecturerComponent implements OnInit {

  lecturers: Lecturers[] = [];

  ngOnInit(): void {
    this.getLecturers();
  }

  private getLecturers():void{
    this.lecturerService.getlecturers().subscribe({
      next:(lecturer)=>{
        this.lecturers =lecturer;
      }
    })
  }

  delete(id:number){
    this.lecturerService.deletelecturer(id).subscribe({
      next:(response)=>{
        console.log(response);
        this.getLecturers();
      }
    })
  }

  lecturerService = inject(LecturerService);
  }

