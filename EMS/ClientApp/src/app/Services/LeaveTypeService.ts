import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LeaveTypeService {
  private leaveTypes: any[] = [
    {
      "value": "1",
      "label": "Sick Leave"
    },
    {
      "value": "2",
      "label": "Annual Leave"
    },
    {
      "value": "3",
      "label": "Study Leave"
    },
    {
      "value": "4",
      "label": "Maternal Leave"
    }
  ];

  constructor(private http: HttpClient) { }

  getLeaveTypes(): Observable<any[]> {
    // If you want to simulate an HTTP request, you can use 'of' to return the data as an observable.
    // In a real application, you would replace this with an actual HTTP GET request.
    return of(this.leaveTypes);
  }
}
