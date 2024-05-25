import { Component, OnInit, inject } from '@angular/core';
import { AdministratorsService } from '../../services/administrators.service';
import { Administrators } from '../../Types/administrators';
import {AsyncPipe} from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-administrator',
  standalone: true,
  imports: [AsyncPipe, RouterLink],
  templateUrl: './administrator.component.html',
  styleUrl: './administrator.component.css'
})
export class AdministratorComponent implements OnInit{

  administrators: Administrators[] = [];

 ngOnInit(): void {
  this.getAdministrators();
  
  }

  delete(id:number){
    this.adminService.deleteadministrator(id).subscribe({
      next:(response)=>{
        console.log(response);
        this.getAdministrators();
      }
    })
  }

  private getAdministrators():void{
   this.adminService.getadministrators().subscribe({
      next:(response)=>{
        console.log(response);
        this.administrators = response;
      }
    })
  }
  adminService = inject(AdministratorsService);
}
