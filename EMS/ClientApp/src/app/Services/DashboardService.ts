import { Injectable } from '@angular/core';
import { ApiService } from './ApiService';
import { Observable } from 'rxjs';
import { Dashboard } from '../models/dashboard.model';
import { DashboardResponse } from '../models/dashboard-response';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  constructor(private apiService: ApiService<DashboardResponse>) { }

   // Dashboard
  getDashboard(): Observable<DashboardResponse> {
    return this.apiService.get('leave/dashboard');
  }
}
