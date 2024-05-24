import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Students } from '../Types/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http:HttpClient) { }

  getstudents=():Observable<Students[]>=>this.http.get<Students[]>("https://localhost:7270/api/Student");

  addstudent=(Data:Students)=>this.http.post("https://localhost:7270/api/Student", Data);

  deletestudent=(id:number)=>this.http.delete("https://localhost:7270/api/Student?Id="+id)
}
