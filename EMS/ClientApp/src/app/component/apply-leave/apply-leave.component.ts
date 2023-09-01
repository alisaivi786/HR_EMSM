import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LeaveRequest } from 'src/app/models/apply-leave.model';
import { DataService } from 'src/app/shared/Service/DataService';

@Component({
  selector: 'app-apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {
  startDate: Date = new Date(); // Set a default date, e.g., today's date
  endDate: Date = new Date();   // Set a default date, e.g., today's date
  leaveType: string = '';       // Initialize with an empty string
  leaveNature: string = '';     // Initialize with an empty string
  remarks: string = '';         // Initialize with an empty string

  leaveRequest: LeaveRequest = {
    startDate: this.startDate,
    endDate: this.endDate,
    leaveTypeId: 1,            // Replace with the actual leave type ID
    requestComments: this.remarks,
    requestingEmployeeId: 123, // Replace with the actual employee ID
    leaveId:0
  };

  constructor(private dataService: DataService, private router: Router) { }

  ngOnInit(): void {
    // Set default values here if needed
    this.leaveNature = 'local'; // Set 'local' as the default value
  }

  onSubmit() {
    this.leaveRequest.startDate = this.startDate;
    this.leaveRequest.endDate = this.endDate;
    this.leaveRequest.leaveTypeId = 1; // Replace with the actual leave type ID
    this.leaveRequest.requestComments = this.remarks;
    this.leaveRequest.requestingEmployeeId = 123; // Replace with the actual employee ID

    this.dataService.applyLeave(this.leaveRequest).subscribe(
      (response) => {
        console.log('Leave request submitted successfully:', response);
        // Handle success, reset form, or navigate to another page as needed
        this.router.navigate(['/fetch-data']);
      },
      (error) => {
        console.error('Error submitting leave request:', error);
        // Handle error scenarios
      }
    );
  }
}
