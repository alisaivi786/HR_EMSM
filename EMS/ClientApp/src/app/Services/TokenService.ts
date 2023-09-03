import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiService } from './ApiService';

@Injectable({
  providedIn: 'root'
})
export class TokenService {

  constructor(private apiService: ApiService<any>) { }

  getToken(): Observable<any> {
    return this.apiService.get('auth/get-token');
  }
  
}
