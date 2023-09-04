import { Component, Input } from '@angular/core';

@Component({
  selector: 'dashboard-card',
  templateUrl: './dashboard-card.component.html',
  styleUrls: ['./dashboard-card.component.css']
})
export class DashboardCardComponent {
  @Input() title: string | undefined;
  @Input() content: string | undefined;
  @Input() buttonLabel: string | undefined;
  @Input() cardClass: string | undefined; 
 
}
