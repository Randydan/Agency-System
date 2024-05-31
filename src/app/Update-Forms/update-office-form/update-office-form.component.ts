import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { LecturerService } from '../../services/lecturer.service';
import { response } from 'express';
import { OfficeService } from '../../services/office.service';

@Component({
  selector: 'app-office-form',
  standalone: true,
  imports: [RouterLink, JsonPipe, ReactiveFormsModule],
  templateUrl: './update-office-form.component.html',
  styleUrl: './update-office-form.component.css'
})
export class UpdateOfficeFormComponent implements OnInit{

  form!: FormGroup;
  Id=0;
  officeService = inject(OfficeService)

  constructor(private fb:FormBuilder,
    private ActivatedRouter: ActivatedRoute,
    private route:Router
  ){

  }

  onSubmit(){
    this.form.value.Id = this.Id;
    this.officeService.updateoffice(this.Id, this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.route.navigateByUrl('/office');
      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {
    this.ActivatedRouter.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        let routeId = response ['id'];
        this.Id = routeId;

        if(!routeId) return;

    this.officeService.getofficemethod(routeId).subscribe({
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
      department: [],
      description:[],
      address: []
})
    }
  }

