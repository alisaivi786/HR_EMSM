import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { WeatherForecast } from '../../fetch-data/weather-forecast.model';
import { AuthResponse } from '../../models/auth-response.model';
import { LeaveResponse } from '../../models/leave-response.model';
import { LeaveRequest } from '../../models/apply-leave.model';
import { DeleteLeave } from '../../models/delete-leave.model';
import { Dashboard } from '../../models/dashboard.model';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  private getTokenFromCookie(): string {
    // Replace 'auth_token' with the actual cookie name where your token is stored
    return document.cookie.split('; ').find((cookie) => cookie.startsWith('auth_token='))?.split('=')[1] || '';
  }

  private createHeaders(): HttpHeaders {
    const token = this.getTokenFromCookie();
    console.log("AM: Token= "+token);
    return new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${token}`
    });
  }

  login(userName: string, password: string): Observable<AuthResponse> {
    const authRequest = { userName, password };
    return this.http.post<AuthResponse>(`${this.baseUrl}auth/login`, authRequest);
  }

  getWeatherForecasts(): Observable<WeatherForecast[]> {
    const headers = this.createHeaders();
    return this.http.get<WeatherForecast[]>(`${this.baseUrl}auth`, { headers });
  }

  getLeaveDetails(): Observable<LeaveResponse> {
    const headers = this.createHeaders();
    return this.http.get<LeaveResponse>(`${this.baseUrl}leaverequest/leavedetails`, { headers });
  }

  applyLeave(leaveRequest: LeaveRequest): Observable<AuthResponse> {
    const headers = this.createHeaders();
    return this.http.post<AuthResponse>(`${this.baseUrl}leaverequest/applyleave`, leaveRequest, { headers });
  }

  updateLeaveRequest(leaveRequest: DeleteLeave): Observable<AuthResponse> {
    const headers = this.createHeaders();
    return this.http.put<AuthResponse>(`${this.baseUrl}leaverequest/deleteleave`, leaveRequest, { headers });
  }
  
  //dashboard
  getDashboard(): Observable<Dashboard> {
    const headers = this.createHeaders();
    return this.http.get<Dashboard>(`${this.baseUrl}leaverequest/dashboard`, { headers });
  }
}
