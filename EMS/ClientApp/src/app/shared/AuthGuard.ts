import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { CookieService } from 'ngx-cookie-service';
import { TokenService } from '../Services/TokenService';
import { AuthService } from '../Services/AuthService';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  token : boolean = false;
  constructor(private router: Router, private cookieService: CookieService,authService: AuthService) {
    this.token = authService.isAuthenticated();
  }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    
    //const token = this.cookieService.get('auth_token');
    
    // Check if the token is expired or not present
    if (this.token) {
      // Token is expired or not present, redirect to login page
      return this.router.parseUrl('/login');
    }

    // Token is valid, allow navigation
    return true;
  }
}
