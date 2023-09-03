import { Component } from '@angular/core';
import { Dashboard } from '../../models/dashboard.model';
import { DashboardService } from '../../Services/DashboardService';

@Component({
  selector: 'dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent {
  // Define your data values for the dashboard cards
  totalLeaves: string = ""; // Initialize to an empty string
  totalPendingRequests: string = "";
  totalCanceledRequests: string = "";

  constructor(private dashboardService: DashboardService) { }

  ngOnInit(): void {
    // Call the API when the component initializes
    this.dashboardService.getDashboard().subscribe((data: Dashboard) => {
      // Update the component properties with the API response
      this.totalLeaves = "14";
      this.totalPendingRequests = "3";
      this.totalCanceledRequests = "5";
    });
  }

}
