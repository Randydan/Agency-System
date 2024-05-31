import { JsonPipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { inject } from '@angular/core';
import { ClassroomService } from '../../services/classroom.service';
import { __values } from 'tslib';

@Component({
  selector: 'app-classroom-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink],
  templateUrl: './update-classroom-form.component.html',
  styleUrl: './update-classroom-form.component.css'
})
export class UpdateClassroomFormComponent implements OnInit{

  form!: FormGroup;
  Id =0;
  classroomService = inject(ClassroomService);

  constructor(private fb: FormBuilder,
    private route:Router,
    private activateroute: ActivatedRoute
  ){

  }

  onSubmit(){

    this.form.value.Id = this.Id;

    this.classroomService.updateclassroom(this.Id, this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.route.navigateByUrl("/classroom");
      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {
    this.activateroute.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        let routeId = response['id'];
        this.Id=routeId;
        if(!routeId) return;
        this.classroomService.getclassroommethod(routeId).subscribe({
          next:(response)=>{
            this.form.patchValue(response);
          },

          error:err=>{
            console.log(err);
          }
        })
      },
      error:err=>{
        console.log(err);
      } 
    })

    this.form= this.fb.group({
    name: [],
    description: [],
    location: []
    })
  }

}
