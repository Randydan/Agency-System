import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Lecturers } from '../Types/lecturer';

@Injectable({
  providedIn: 'root'
})
export class LecturerService {

  constructor(private http:HttpClient) { }

  getlecturers=():Observable<Lecturers[]>=>this.http.get<Lecturers[]>("https://localhost:7270/api/Lecturer");

  addlecturer=(Data:Lecturers)=>this.http.post("https://localhost:7270/api/Lecturer", Data);

  updatelecturer=(id:number, data:Lecturers)=>this.http.put("https://localhost:7270/api/Lecturer?Id="+id, data);

  deletelecturer=(id:number)=>this.http.delete("https://localhost:7270/api/Lecturer?Id="+id);
}
