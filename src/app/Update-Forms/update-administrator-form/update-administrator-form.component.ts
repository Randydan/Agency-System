import { JsonPipe } from '@angular/common';
import { Component, OnInit, inject } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
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
  administratorService= inject(AdministratorsService);
  Id =0;
  constructor(private fb:FormBuilder, 
  private toasterservice:ToastrService,
  private router:Router,
  private activateRouter:ActivatedRoute
  ){

  }

  onSubmit(){
    console.log("route id", this.Id);
    this.form.value.Id = this.Id;

    this.administratorService.updateadministrator(this.Id, this.form.value).subscribe({
      next:value =>{
        console.log(value);
        // this.toasterservice.success("Administrator Successfully Created");
        this.router.navigateByUrl('/administrator');
      },
      error:err=>{
        console.log(err);
        this.toasterservice.error("Something went wrong");
        //("Something Went wrong!!!")
      }
    })
  }
  ngOnInit(): void {

    this.activateRouter.params.subscribe({
      next:(response)=>{
        console.log(response['id']);
        let routeId = response['id'];
        this.Id=routeId;
        if(!routeId) return;
        this.administratorService.getadminmethod(routeId).subscribe({
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
