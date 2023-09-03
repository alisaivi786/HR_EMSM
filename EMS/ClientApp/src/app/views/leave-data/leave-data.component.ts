import { Component, Inject } from '@angular/core';
import { LeaveData } from '../../models/leave-data.model';
import { DeleteLeave } from '../../models/delete-leave.model';
import { LeaveService } from '../../Services/LeaveService';

@Component({
  selector: 'leave-data',
  templateUrl: './leave-data.component.html'
})
export class LeaveDataComponent {
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
        this.loadLeaveDetails();
      },
      (error) => {
        // Handle error scenarios
        console.error('Error soft deleting leave request:', error);
      }
    );
  }
}



