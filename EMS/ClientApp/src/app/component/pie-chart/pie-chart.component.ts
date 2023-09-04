import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
import { ChartOptions } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';

@Component({
  selector: 'pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.css']
})
export class PieChartComponent implements OnChanges {
  title = 'ng2-charts-demo';  
  @Input() pieChartData: number[] | undefined;

  // Pie
  public pieChartOptions: ChartOptions<'pie'> = {
    responsive: false,
  };
  public pieChartLabels = ['RemainingBalance', 'Reject', 'Pending', 'Approved'];
  public pieChartDatasets: { data: number[] }[] = []; // Initialize as an empty array
  public pieChartLegend = true;
  public pieChartPlugins = [];

  constructor() {}

  ngOnChanges(changes: SimpleChanges) {
    // Check if the pieChartData input has changed
    if (changes.pieChartData && this.pieChartData) {
      // Update the pieChartDatasets with the new data
      this.pieChartDatasets = [
        {
          data: this.pieChartData
        }
      ];
    }
  }
}
