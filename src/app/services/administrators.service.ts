import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Administrators } from '../Types/administrators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdministratorsService {

  constructor(private http:HttpClient) { }

  getadministrators=():Observable<Administrators[]>=> this.http.get<Administrators[]>("https://localhost:7270/api/Administrator")
}
