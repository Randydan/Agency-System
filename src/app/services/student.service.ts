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

  updatestundent=(id:number, data:Students)=>this.http.put("https://localhost:7270/api/Student?Id="+id, data);

  getstudentsmethod=(id:number):Observable<Students[]>=>this.http.get<Students[]>("https://localhost:7270/api/Student/" + id);


  deletestudent=(id:number)=>this.http.delete("https://localhost:7270/api/Student?Id="+id)
}
