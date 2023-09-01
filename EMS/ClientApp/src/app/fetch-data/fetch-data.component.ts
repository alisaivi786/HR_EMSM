import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecast } from './weather-forecast.model';
import { DataService } from '../shared/Service/DataService';
import { LeaveResponse } from '../models/leave-response.model';
import { LeaveData } from '../models/leave-data.model';
import { DeleteLeave } from '../models/delete-leave.model';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public leaveResponse: LeaveData[] = [];
  public leavId : number |undefined;
  constructor(private dataService: DataService) {
    this.loadLeaveDetails();
  }

  private loadLeaveDetails() {
    this.dataService.getLeaveDetails().subscribe(result => {
      this.leaveResponse = result.data;
      console.log(this.leaveResponse)
    }, error => console.error(error));
  }

  deleteLeaveRequest(leaveRequestId: number) {
    // Prepare the leave request data for soft delete (update the flag)
    const updatedLeaveRequest: DeleteLeave = {
      leaveId: leaveRequestId,
    };
  
    // Call your API service to update the leave request with the soft delete flag
    this.dataService.updateLeaveRequest(updatedLeaveRequest).subscribe(
      (response) => {
        // Handle success, e.g., update the view or show a success message
        console.log('Leave request soft deleted successfully:', response);
        // Reload or update the leaveResponse data
        this.loadLeaveDetails();
      },
      (error) => {
        // Handle error scenarios
        console.error('Error soft deleting leave request:', error);
      }
    );
  }
  
  

}



