import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterOutlet } from '@angular/router';
import { Observable, catchError } from 'rxjs';
import { urlToHttpOptions } from 'url';
import { HttpService} from '../../http.service';

@Component({
  selector: 'app-administrator',
  standalone: true,
  imports: [RouterOutlet, FormsModule, HttpClientModule],
  templateUrl: './administrator.component.html',
  styleUrl: './administrator.component.css'
})
export class AdministratorComponent {

  Adminobj: Administrator = new Administrator();
  httpServices= inject(HttpService)
  constructor(private http:HttpClient){

  }
  
  onRegister(){
    debugger;
  this.httpServices.Adminget().subscribe(result=>{
    console.log(result);
    this.Adminobj = result;
    console.log(this.Adminobj);
  });
  // alert('Success')

    // debugger;
    // const localUser = .getItem('Administrators');
    // if(localUser !=null){
    //   const admins = JSON.parse(localUser);
    //   admins.push(this.Adminobj);
    //   localStorage.setItem('Administrators', JSON.stringify(admins))
    // }else{
    //   const admins = [];
    //   admins.push(this.Adminobj)
    //   localStorage.setItem('Administrators', JSON.stringify(admins))
    // }

    // alert('Registrattion Successfull')
  }

}


export class Administrator{
  Salary: number; 
  Department: string; 
  Post: string; 
  Name: string;  
  Gender: string  
  Dob: string;
  Address: string; 
  Email: string;  
  Phone: number; 
  Status: string;
  
  constructor(){
    this.Salary = 0;
    this.Department = '';
    this.Post = '';
    this.Name = '';
    this.Gender='';
    this.Dob ='';
    this.Address = '';
    this.Email='';
    this.Phone= 0;
    this.Status ='';
  }
}
