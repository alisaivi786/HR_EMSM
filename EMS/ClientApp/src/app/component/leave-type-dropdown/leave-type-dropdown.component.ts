import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { LeaveTypeService } from 'src/app/Services/LeaveTypeService';

@Component({
  selector: 'leave-type-dropdown',
  templateUrl: './leave-type-dropdown.component.html',
  styleUrls: ['./leave-type-dropdown.component.css']
})
export class LeaveTypeDropdownComponent implements OnInit {
  @Input() parentForm!: FormGroup;
  leaveTypes: any[] = [];
  leaveTypeControl: FormControl; // Create a local FormControl

  constructor(private leaveTypeService: LeaveTypeService) {
    this.leaveTypeControl = new FormControl('', Validators.required);
  }

  ngOnInit(): void {
    this.loadLeaveTypes();
    this.parentForm.addControl('leaveType', this.leaveTypeControl); 
  }

  loadLeaveTypes() {
    this.leaveTypeService.getLeaveTypes().subscribe(data => {
      this.leaveTypes = data;
    });
  }
}
