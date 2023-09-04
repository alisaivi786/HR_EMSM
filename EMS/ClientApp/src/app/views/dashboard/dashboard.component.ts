import { Component, OnInit } from '@angular/core';
import { DashboardService } from '../../Services/DashboardService';
import { DashboardResponse } from 'src/app/models/dashboard-response';

@Component({
  selector: 'dashboard',
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent implements OnInit {
  // Define your data values for the dashboard cards
  totalLeaves: string = ""; // Initialize to an empty string
  totalPendingRequests: string = "";
  totalCanceledRequests: string = "";
  remainingBalance: string = "";

  chartData: number[] = [];
  constructor(private dashboardService: DashboardService) {
   }

   ngOnInit(): void {
    // Call the API when the component initializes
    this.dashboardService.getDashboard().subscribe(
      (data: DashboardResponse) => {
        // Update the component properties with the API response
        console.log(data);
        this.totalLeaves = data.data.approved;
        this.totalPendingRequests = data.data.pending;
        this.totalCanceledRequests = data.data.reject;
        this.remainingBalance = (parseInt(data.data.totalEmployeeLeave) - parseInt(data.data.approved)).toString() ;
        this.chartData = [parseInt(this.remainingBalance),parseInt(this.totalCanceledRequests),parseInt(this.totalPendingRequests),parseInt(this.totalLeaves)]
      console.log(this.chartData);
      },
      (error) => {
        console.error('Error occurred:', error);
        // Handle the error, e.g., display an error message to the user
      }
    );
  }
}
