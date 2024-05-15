import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Classrooms } from '../Types/classroom';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClassroomService {

  constructor(private http:HttpClient) { }

  getclassrooms=():Observable<Classrooms[]>=> this.http.get<Classrooms[]>("https://localhost:7270/api/Classroom")
}
