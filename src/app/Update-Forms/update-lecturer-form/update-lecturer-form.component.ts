import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { LecturerService } from '../../services/lecturer.service';

@Component({
  selector: 'app-lecturer-form',
  standalone: true,
  imports: [RouterLink, ReactiveFormsModule, JsonPipe],
  templateUrl: './update-lecturer-form.component.html',
  styleUrl: './update-lecturer-form.component.css'
})
export class UpdateLecturerFormComponent implements OnInit {

  form!: FormGroup; 
  Id=0;
  lecturerService = inject(LecturerService);

  constructor(private fb:FormBuilder,
    private activatedRouter: ActivatedRoute,
    private route:Router
  ){

  }

  onSubmit(){

    this.form.value.Id = this.Id;

    this.lecturerService.updatelecturer(this.Id, this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.route.navigateByUrl('/lecturer');

      },
      error:err=>{
        console.log(err);
      }
    })
  }
  
  ngOnInit(): void {
    this.activatedRouter.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        let routeId = response ['id'];
        this.Id = routeId;

        if(!routeId) return;

    this.lecturerService.getlecturermethod(routeId).subscribe({
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

    this.form = this.fb.group({
      name: [],  
      gender: [],
      dob: [], 
      address: [],
      email: [],
      phone: [],  
      status: [],
      course: [],
      salary: [],
    })
  }

}
