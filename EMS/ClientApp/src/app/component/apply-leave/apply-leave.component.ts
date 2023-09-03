import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LeaveService } from 'src/app/Services/LeaveService';
import { LeaveRequest } from 'src/app/models/apply-leave.model';


@Component({
  selector: 'apply-leave',
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

  constructor(private leaveService: LeaveService, private router: Router) { }

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

    this.leaveService.applyLeave(this.leaveRequest).subscribe(
      (response) => {
        this.router.navigate(['/leave-data']);
      },
      (error) => {
        console.error('Error submitting leave request:', error);
        // Handle error scenarios
      }
    );
  }
}
