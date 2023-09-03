import { Injectable } from '@angular/core';
import { LeaveResponse } from '../models/leave-response.model';
import { ApiService } from './ApiService';
import { Observable } from 'rxjs';
import { Dashboard } from '../models/dashboard.model';

@Injectable({
  providedIn: 'root'
})
export class LeaveService {
  constructor(private apiService: ApiService<LeaveResponse>) { }

  getLeaveDetails(): Observable<LeaveResponse> {
    return this.apiService.get('leave/leave-details');
  }

  applyLeave(leaveRequest: any): Observable<LeaveResponse> {
    return this.apiService.post('leave/apply-leave', leaveRequest);
  }

  deleteLeave(leaveRequest: any): Observable<LeaveResponse> {
    return this.apiService.put('leave/delete-leave', leaveRequest);
  }
   
}
