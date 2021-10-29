import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LanguageService {

  constructor() {
    var localizationData = this.fetchCountry();
    console.log(localizationData);
    localStorage.setItem('language', this.fetchCountry());
  }

  selectLanguage(language: string) {
    localStorage.setItem('language', language);
  }

  obtainLocation(position) {
    let latitude = position.coords.latitude;
    let longitude = position.coords.longitude;

    this.reserveGeoCodingWithGoogle(longitude, latitude);
  }

  reserveGeoCodingWithGoogle(latitude, longitude) {
    fetch(`https://maps.googleapis.com/maps/api/geocode/json?
      latlng=${latitude},${longitude}&key={GOOGLE_MAP_KEY}`)
      .then(res => res.json())
      .then(response => {
        console.log(`User's location: ${response}`)
      })
      .catch(status => {
        console.log(`Request failed: Returned a status of ${status}`);
      })
  }

  fetchCountry(): any {
    return fetch('https://extreme-ip-lookup.com/json/')
      .then(res => res.json())
      .then(response => {
        return response.countryCode;
      })
      .catch(data => {
        console.log('Request failed');
      });
  }
}
