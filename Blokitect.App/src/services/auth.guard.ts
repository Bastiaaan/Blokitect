import { CanActivate, Router } from '@angular/router';
import { AuthService } from './auth.service';
import { Observable } from 'rxjs';

export class AuthGuard implements CanActivate
{
  constructor(private router: Router, private authService: AuthService) {

  }

  canActivate(): Observable<boolean> | boolean {

    const availableToken = localStorage.getItem('authToken');
    if (availableToken !== null) {
      if (this.authService.isAuthenticated(localStorage.getItem('authToken'))) {
        return true;
      }
      console.error('Token not found. Error 404');
      return false;
    }

    return false;
  }
}

