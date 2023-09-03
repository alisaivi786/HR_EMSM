import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService<T> {
  apiToken : string | undefined = "" ;
  
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    
   }

  private createHeaders(): HttpHeaders {
    const token = this.getTokenFromCookie();
    return new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${token}`
    });
  }


  private getTokenFromCookie(): string {
    return document.cookie.split('; ').find((cookie) => cookie.startsWith('auth_token='))?.split('=')[1] || '';
  }
  

  get(endpoint: string): Observable<T> {
    const headers = this.createHeaders();
    return this.http.get<T>(`${this.baseUrl}${endpoint}`, { headers });
  }

  post(endpoint: string, data: any): Observable<T> {
    const headers = this.createHeaders();
    return this.http.post<T>(`${this.baseUrl}${endpoint}`, data, { headers });
  }

  put(endpoint: string, data: any): Observable<T> {
    const headers = this.createHeaders();
    return this.http.put<T>(`${this.baseUrl}${endpoint}`, data, { headers });
  }

  delete(endpoint: string): Observable<T> {
    const headers = this.createHeaders();
    return this.http.delete<T>(`${this.baseUrl}${endpoint}`, { headers });
  }

  
}
