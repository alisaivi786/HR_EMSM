import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'apply-leave',
  templateUrl: './apply-leave.component.html',
  styleUrls: ['./apply-leave.component.css']
})
export class ApplyLeaveComponent implements OnInit {
  leaveForm: FormGroup;

  constructor( private router: Router,private fb: FormBuilder) { }

  ngOnInit(): void {
    this.leaveForm = this.fb.group({
      startDate: ['2023-09-01', Validators.required], // Set the default start date here
      endDate: ['2023-09-10', Validators.required],   // Set the default end date here
      leaveNature: ['local', Validators.required],     // Set the default leave nature here
      leaveType: ['Paid', Validators.required],         // Set the default leave type here
      remarks: ['Default remarks'],                     // Set the default remarks here
    });
  }



  onSubmit() {
    if (this.leaveForm.valid) {
      // Handle form submission here
      console.log(this.leaveForm.value);
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
