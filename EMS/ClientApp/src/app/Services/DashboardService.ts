import { Injectable } from '@angular/core';
import { ApiService } from './ApiService';
import { Observable } from 'rxjs';
import { Dashboard } from '../models/dashboard.model';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  constructor(private apiService: ApiService<Dashboard>) { }

   // Dashboard
  getDashboard(): Observable<Dashboard> {
    return this.apiService.get('leave/leave-details');
  }
}
