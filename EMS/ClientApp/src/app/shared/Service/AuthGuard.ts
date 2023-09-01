import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private router: Router, private cookieService: CookieService) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    
    const token = this.cookieService.get('auth_token');

    // Check if the token is expired or not present
    if (!token) {
      // Token is expired or not present, redirect to login page
      return this.router.parseUrl('/login');
    }

    // Token is valid, allow navigation
    return true;
  }
}
