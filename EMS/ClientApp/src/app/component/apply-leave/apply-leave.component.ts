import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LeaveService } from 'src/app/Services/LeaveService';
import { LeaveTypeService } from 'src/app/Services/LeaveTypeService';
import { LeaveRequest } from 'src/app/models/apply-leave.model';


@Component({
  selector: 'apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {
  errorText: string | null = null;
  leaveForm!: FormGroup;
  leaveRequest: LeaveRequest | undefined;
  constructor( 
    private router: Router,
    private fb: FormBuilder,
    private leaveService : LeaveService
    ) { }

  ngOnInit(): void {
    this.leaveForm = this.fb.group({
      startDate: ['', Validators.required], 
      endDate: ['', Validators.required],
      reason: [''],
    });
  }



  onSubmit() {
    if (this.leaveForm.valid) {
      // Handle form submission here
      console.log(this.leaveForm.value);

      this.leaveRequest = {
        startDate: this.leaveForm.value.startDate,
        endDate: this.leaveForm.value.endDate,
        leaveTypeId: this.leaveForm.value.leaveType,
        requestComments: this.leaveForm.value.reason,
        requestingEmployeeId: 1,
        leaveId: 0
      };
      console.log(this.leaveRequest);
      // Post data to API
      this.leaveService.applyLeave(this.leaveRequest).subscribe(
        (response) => {
          if(response.success){
            this.errorText = response.message;
            this.router.navigate(['/leave-data']);
          }else{
            this.errorText = response.message;
          }
          
        },
        (error) => {
          console.error('Error submitting leave request:', error);
          // Handle error scenarios
          if (error.status === 400) {
            // Handle Bad Request scenario
            this.errorText = 'Bad request: Please check your input data.';
          } else {
            // Handle other error scenarios
            this.errorText = 'An error occurred while submitting the leave request.';
          }
        }
      );

    } else {
      // Mark all form controls as touched to display validation messages
      this.markFormGroupTouched(this.leaveForm);
    }
  }
  markFormGroupTouched(formGroup: FormGroup) {
    Object.values(formGroup.controls).forEach((control) => {
      control.markAsTouched();

      if (control instanceof FormGroup) {
        this.markFormGroupTouched(control);
      }
    });
  }
}
