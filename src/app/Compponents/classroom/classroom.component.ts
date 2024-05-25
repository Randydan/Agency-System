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
 
 delete(id:number){

  this.classroomService.deleteclassroom(id).subscribe({
    next:(response)=>{
      console.log(response);
      this.getClassrooms();
    }
 })
      
 }

 private getClassrooms(): void{
  this.classroomService.getclassrooms().subscribe({
    next:(response)=>{
      this.classrooms = response;
    }
  })

 }
  ngOnInit(): void {
    this.getClassrooms();
  }


  classroomService = inject(ClassroomService);
}