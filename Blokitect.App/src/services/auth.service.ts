import { Inject, Injectable } from '@angular/core'
import { Service } from './service';
import { Router } from '@angular/router';
import { LoginViewModel } from '../models/login-model';
import { RegisterViewModel } from '../models/register-model';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class AuthService extends Service {

  router: Router;  
  
  constructor(private api: HttpClient, router: Router) {
    super("auth");
    this.router = router;
  }

  login(viewModel: LoginViewModel): any {
    this.addHeader("data", JSON.stringify(viewModel));
    return this.api.post<LoginViewModel>(`${this.apiUrl}login`, this.headers)
      .subscribe((result: any) => {
        result.success !== false
          ? localStorage.setItem('authToken', null)
          : console.error('wrong login attempt');

        const token = localStorage.getItem('authToken');
        if (token !== null) {
          this.router.navigateByUrl(`dashboard/${token}`);
        }
      });
  }

  register(viewModel: RegisterViewModel): any {
    this.addHeader("data", JSON.stringify(viewModel));
    return this.api.post(`${this.apiUrl}register`, viewModel)
      .subscribe((data: any) => {
        console.log(data);
      });
  }

  logout(): any {
    this.api.post(`${this.apiUrl}/logout`, this.headers).pipe();
    localStorage.removeItem('token');
  }

  isAuthenticated(token: string): Observable<boolean> {
    return this.api.post<string>(`${this.apiUrl}${token}`, this.headers)
      .pipe((result: any) => {
        return result.success ?? false;
        //handleError();
      });
  }

  isAuthorized(): boolean {
    let apiCall = this.api.get<any>(`${this.apiUrl}`);
    return apiCall === null;
  }
}
