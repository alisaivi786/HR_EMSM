import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { WeatherForecast } from './weather-forecast.model';
import { DataService } from '../shared/DataService';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[] = [];

  constructor(private dataService: DataService) {
    this.loadForecasts();
  }

  private loadForecasts() {
    this.dataService.getWeatherForecasts().subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}



