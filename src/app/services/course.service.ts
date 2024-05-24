import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Courses } from '../Types/course';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private http:HttpClient) { }
  getcourses=():Observable<Courses[]>=> this.http.get<Courses[]>("https://localhost:7270/api/Course");

  addcourse=(data:Courses)=>this.http.post("https://localhost:7270/api/Course", data);

  deletecourse=(id:number)=>this.http.delete("https://localhost:7270/api/Course?Id=" +id);

}
