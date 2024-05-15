import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Lecturers } from '../Types/lecturer';

@Injectable({
  providedIn: 'root'
})
export class LecturerService {

  constructor(private http:HttpClient) { }

  getlecturers=():Observable<Lecturers[]>=>this.http.get<Lecturers[]>("https://localhost:7270/api/Lecturer")
}
