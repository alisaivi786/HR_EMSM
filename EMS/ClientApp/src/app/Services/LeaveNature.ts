import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LeaveNatureService {
  private leaveTypes: any[] = [
    {
      "value": "local",
      "label": "Local"
    },
    {
      "value": "travel",
      "label": "Travel"
    }
  ];

  constructor(private http: HttpClient) { }

  getLeaveNatures(): Observable<any[]> {
    // If you want to simulate an HTTP request, you can use 'of' to return the data as an observable.
    // In a real application, you would replace this with an actual HTTP GET request.
    return of(this.leaveTypes);
  }
}
