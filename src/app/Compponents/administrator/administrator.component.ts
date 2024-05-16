import { Component, OnInit, inject } from '@angular/core';
import { AdministratorsService } from '../../services/administrators.service';
import { Observable } from 'rxjs';
import { Administrators } from '../../Types/administrators';
import { response } from 'express';
import { error } from 'console';
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
  
    this.adminService.getadministrators().subscribe({
      next:(response)=>{
        console.log(response);
        this.administrators = response;
      }
    })

  }
  adminService = inject(AdministratorsService);
}
