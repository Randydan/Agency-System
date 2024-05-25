import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { AdministratorsService } from '../../services/administrators.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-administrator-form',
  standalone: true,
  imports: [ReactiveFormsModule, JsonPipe, RouterLink,],
  templateUrl: './update-administrator-form.component.html',
  styleUrl: './update-administrator-form.component.css'
})
export class UpdateAdministratorFormComponent implements OnInit{

  form!:FormGroup;
  administratorService= inject(AdministratorsService)
  constructor(private fb:FormBuilder, 
  private toasterservice:ToastrService,
  private router:Router
  ){

  }

  onSubmit(){
    this.administratorService.addadministrator(this.form.value).subscribe({
      next:(response)=>{
        console.log(response);
        this.toasterservice.success("Administrator Successfully Created");
        this.router.navigateByUrl('/administrator');
      },
      error:err=>{
        console.log(err);
        this.toasterservice.error("Something went wrong");
        alert("Something Went wrong!!!")
      }
    })
  }
  ngOnInit(): void {
    this.form = this.fb.group({
      salary:[],
      department:[],
      post: [],
      name:[],
      gender:[],
      dob: [],
      address:[],
      email:[],
      phone: [],
      status: []
    });
  }

}
