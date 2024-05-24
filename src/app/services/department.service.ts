import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Departments } from '../Types/department';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private http:HttpClient) { }

  getdepartments=():Observable<Departments[]>=> this.http.get<Departments[]>("https://localhost:7270/api/Department");

  addDepartment=(Data:Departments)=>this.http.post("https://localhost:7270/api/Department", Data);

  deletedeparment=(id:number)=>this.http.delete("https://localhost:7270/api/Department?Id="+id);

}
