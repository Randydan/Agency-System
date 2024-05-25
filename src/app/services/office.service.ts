import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Offices } from '../Types/office';

@Injectable({
  providedIn: 'root'
})
export class OfficeService {

  constructor(private http:HttpClient) { }

  getoffice=():Observable<Offices[]>=>this.http.get<Offices[]>("https://localhost:7270/api/Office");

  addoffice=(Data:Offices)=>this.http.post("https://localhost:7270/api/Office", Data);

  updateoffice=(id:number, data:Offices)=>this.http.put("https://localhost:7270/api/Office?Id="+id, data);

  deleteoffice=(id:number)=>this.http.delete("https://localhost:7270/api/Office?Id="+id)
}
