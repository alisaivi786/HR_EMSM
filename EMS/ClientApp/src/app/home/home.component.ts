import { Component } from '@angular/core';
import { DataService } from '../shared/Service/DataService';
import { Dashboard } from '../models/dashboard.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  // Define your data values for the dashboard cards
  totalLeaves: string = ""; // Initialize to an empty string
  totalPendingRequests: string = "";
  totalCanceledRequests: string = "";

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    // Call the API when the component initializes
    this.dataService.getDashboard().subscribe((data: Dashboard) => {
      // Update the component properties with the API response
      console.log(data.toString());  
      this.totalLeaves = "14";
      this.totalPendingRequests = "3";
      this.totalCanceledRequests = "5";
    });
  }

}
