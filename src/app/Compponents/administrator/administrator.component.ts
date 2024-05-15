import { Component, OnInit, inject } from '@angular/core';
import { AdministratorsService } from '../../services/administrators.service';
import { Observable } from 'rxjs';
import { Administrators } from '../../Types/administrators';
import { response } from 'express';
import { error } from 'console';
import {AsyncPipe} from '@angular/common';

@Component({
  selector: 'app-administrator',
  standalone: true,
  imports: [AsyncPipe],
  templateUrl: './administrator.component.html',
  styleUrl: './administrator.component.css'
})
export class AdministratorComponent implements OnInit{
  ngOnInit(): void {
    this.admin$=this.adminService.getadministrators()
  }
  adminService = inject(AdministratorsService);
  admin$!:Observable<Administrators[]>
}
