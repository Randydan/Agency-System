import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { Administrator } from './Compponents/administrator/administrator.component';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  http= inject(HttpClient);
  constructor() { }

  Adminget(){
    var url = "https://localhost:7270/api/Administrator"
    return this.http.get<Administrator>(url);
  }

  // Adminpost(){
  //   return this.http.post<Administrator>(this.apiUrl+'/api/Administrator')
  // }
}
