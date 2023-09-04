import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router, UrlTree } from '@angular/router';
import { AuthService } from '../Services/AuthService';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private router: Router, private authService: AuthService) {}

  async canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Promise<boolean | UrlTree> {

    const isAuthenticated = await this.authService.isAuthenticated();

    if (!isAuthenticated) {
      // Token is expired or not present, redirect to login page
      return this.router.parseUrl('/login');
    }

    // Token is valid, allow navigation
    return true;
  }
}
