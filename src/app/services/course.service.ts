import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Courses } from '../Types/course';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private http:HttpClient) { }
  getcourses=():Observable<Courses[]>=> this.http.get<Courses[]>("https://localhost:7270/api/Course")

}
