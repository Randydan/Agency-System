import { Component, OnInit, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AsyncPipe } from '@angular/common';
import { Offices } from '../../Types/office';
import { OfficeService } from '../../services/office.service';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-office',
  standalone: true,
  imports: [FormsModule, AsyncPipe,RouterLink],
  templateUrl: './office.component.html',
  styleUrl: './office.component.css'
})
export class OfficeComponent implements OnInit {
  offices: Offices[] =[]
    ngOnInit(): void {
      this.officeService.getoffice().subscribe({
        next:(office)=>{
          this.offices = office;
        }
      })
    }
    officeService = inject(OfficeService);
    }