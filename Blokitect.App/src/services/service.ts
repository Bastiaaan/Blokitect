import { environment } from '../environments/environment';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Service {

  protected apiUrl: string;
  protected headers: {  } = [];

  constructor(@Inject(String) serviceName: string) {
    serviceName === null ? this.apiUrl : this.apiUrl = `${environment.endPoints.api}${serviceName}/`;
    this.addHeader('Content-Type', 'Application/json');
    this.addHeader('Accept', 'Application/json');
  }

  protected addHeader(key: string, value: any) {
    this.headers[key] = value;
  }

  protected removeHeader(key: string) {
    if (this.headerExists(key)) {
      this.headers[key] = null;
    }

    throw new Error(`the key ${key} is not found`);
  }

  protected headerExists(key: string): boolean {
    return this.headers[key] !== null;
  }

  protected handleError(error: HttpErrorResponse) {
    return throwError(error);
  }
}


