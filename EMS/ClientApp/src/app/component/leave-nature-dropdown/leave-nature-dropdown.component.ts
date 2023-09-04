import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LeaveNatureService } from 'src/app/Services/LeaveNature';

@Component({
  selector: 'leave-nature-dropdown',
  templateUrl: './leave-nature-dropdown.component.html',
  styleUrls: ['./leave-nature-dropdown.component.css']
})
export class LeaveNatureDropdownComponent implements OnInit {
  @Input() parentForm!: FormGroup;
  leaveNatures: any[] = [];
  leaveNatureControl: FormControl; // Create a local FormControl

  constructor(private leaveNatureService: LeaveNatureService) {
    this.leaveNatureControl = new FormControl('', Validators.required);
  }

  ngOnInit(): void {
    this.loadLeaveTypes();
    this.parentForm.addControl('leaveType', this.leaveNatureControl); // Add the control to the parent form
  }

  loadLeaveTypes() {
    this.leaveNatureService.getLeaveNatures().subscribe(data => {
      this.leaveNatures = data;
    });
  }
}