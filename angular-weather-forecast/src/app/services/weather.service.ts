import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  API_BASEURL = 'https://api.openweathermap.org/data/2.5/weather?';
  API_KEY = '4f53ba428df46714421147fb968193f9';

  constructor(private httpClient: HttpClient) { }

  searchWeatherByCity(cityName: string): Observable<any>{
    return this.httpClient.get<any>(this.API_BASEURL, {
      params: new HttpParams()
      .set('q', cityName)
      .set('appid', this.API_KEY)
      .set('units', 'metric')
      .set('lang', 'pt_br')
      .set('mode', 'json')
    })
  }
}
