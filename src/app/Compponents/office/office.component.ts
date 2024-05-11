import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-office',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './office.component.html',
  styleUrl: './office.component.css'
})
export class OfficeComponent {
  officeobj: Office;

  constructor(){
    this.officeobj = new Office();
  }
}

export class Office{
 
  Department:string;
  Description:string ;
  Address: string;

  constructor(){
    this.Department='';
    this.Description='';
    this.Address='';
  }
}
