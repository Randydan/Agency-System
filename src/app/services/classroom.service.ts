import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Classrooms } from '../Types/classroom';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClassroomService {

  constructor(private http:HttpClient) { }

  getclassrooms=():Observable<Classrooms[]>=> this.http.get<Classrooms[]>("https://localhost:7270/api/Classroom");

  addclassroom=(Data:Classrooms)=>this.http.post("https://localhost:7270/api/Classroom", Data);

  updateclassroom=(id:number, data:Classrooms)=>this.http.put("https://localhost:7270/api/Classroom?Id="+id, data);
  
  deleteclassroom=(id:number)=>this.http.delete("https://localhost:7270/api/Classroom?Id=" +id);
}
