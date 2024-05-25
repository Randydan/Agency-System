import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { LecturerService } from '../../services/lecturer.service';
import { response } from 'express';
import { OfficeService } from '../../services/office.service';

@Component({
  selector: 'app-office-form',
  standalone: true,
  imports: [RouterLink, JsonPipe, ReactiveFormsModule],
  templateUrl: './office-form.component.html',
  styleUrl: './office-form.component.css'
})
export class OfficeFormComponent implements OnInit{

  form!: FormGroup;

  officeService = inject(OfficeService)

  constructor(private fb:FormBuilder){

  }

  onSubmit(){

    this.officeService.addoffice(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        alert(response);
      },
      error:err=>{
        console.log(err);
      }
    })
  }
  ngOnInit(): void {
    this.form = this.fb.group({
      department: ['', Validators.required],
      description:['', Validators.required],
      address: ['', Validators.required]
})
    }
  }

