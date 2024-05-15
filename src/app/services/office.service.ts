import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Offices } from '../Types/office';

@Injectable({
  providedIn: 'root'
})
export class OfficeService {

  constructor(private http:HttpClient) { }

  getoffice=():Observable<Offices[]>=>this.http.get<Offices[]>("https://localhost:7270/api/Offices")
}
