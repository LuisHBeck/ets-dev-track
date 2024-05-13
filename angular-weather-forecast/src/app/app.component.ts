import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { WeatherService } from './services/weather.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    ReactiveFormsModule,
    FormsModule,
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'angular-weather-forecast';

  searchForm!: FormGroup;
  weather: any;

  constructor(private fb: FormBuilder, private service:WeatherService) {

  }

  ngOnInit() {
    this.searchForm = this.fb.group(
      {
        city: [null, Validators.required]
      }
    )
  }

  searchWeather() {
    console.log(this.searchForm.value)
    this.service.searchWeatherByCity(this.searchForm.get(['city'])!.value).subscribe((res) => {
      this.weather = res;
      console.log(res)
    })
  }
}
