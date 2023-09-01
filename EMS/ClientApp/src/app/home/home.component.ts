import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  // Define your data values for the dashboard cards
  totalLeaves: string = "100"; // Example content for totalLeaves
  totalPendingRequests: string = "50"; // Example content for totalPendingRequests
  totalCanceledRequests: string = "10"; // Example content for totalCanceledRequests
  remainingLeave: string = "40"; // Example content for remainingLeave


}
