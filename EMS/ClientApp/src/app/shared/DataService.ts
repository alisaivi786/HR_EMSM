import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { WeatherForecast } from '../fetch-data/weather-forecast.model';
import { AuthResponse } from '../models/auth-response.model';


@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  login(userName: string, password: string): Observable<AuthResponse> {
    const authRequest = { userName, password };
    return this.http.post<AuthResponse>(`${this.baseUrl}auth/login2`, authRequest);
  }

  getWeatherForecasts(): Observable<WeatherForecast[]> {
    return this.http.get<WeatherForecast[]>(`${this.baseUrl}auth`);
  }
}
