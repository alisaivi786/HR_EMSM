import { Component, Inject } from '@angular/core';
import { LeaveData } from '../../models/leave-data.model';
import { DeleteLeave } from '../../models/delete-leave.model';
import { LeaveService } from '../../Services/LeaveService';

@Component({
  selector: 'leave-data',
  templateUrl: './leave-data.component.html'
})
export class LeaveDataComponent {
  showMessage: boolean = false;
  message : string = "";
  public leaveResponse: LeaveData[] = [];
  public leavId : number |undefined;
  constructor(private leaveService: LeaveService) {
    this.loadLeaveDetails();
  }

  private loadLeaveDetails() {
    this.leaveService.getLeaveDetails().subscribe(result => {
      this.leaveResponse = result.data;
    }, error => console.error(error));
  }

  deleteLeaveRequest(leaveRequestId: number) {
    // Prepare the leave request data for soft delete (update the flag)
    const updatedLeaveRequest: DeleteLeave = {
      leaveId: leaveRequestId,
    };
  
    // Call your API service to update the leave request with the soft delete flag
    this.leaveService.deleteLeave(updatedLeaveRequest).subscribe(
      (response) => {
        // Display the message
        this.showMessage = true;
        this.message = response.message;
        this.loadLeaveDetails();
        // Set a timeout to hide the message after 5 seconds
        setTimeout(() => {
          this.showMessage = false;
        }, 2000); // 1000 milliseconds (5 seconds)
      },
      (error) => {
        // Handle error scenarios
        console.error('Error soft deleting leave request:', error);
      }
    );
  }
}



