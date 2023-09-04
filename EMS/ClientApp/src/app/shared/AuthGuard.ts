import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router, UrlTree } from '@angular/router';
import { AuthService } from '../Services/AuthService';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private router: Router, private authService: AuthService) {
    // Execute isAuthenticated here in the constructor
    //this.checkIsAuthenticated();
  }

  // private async checkIsAuthenticated(): Promise<void> {
  //   const isAuthenticated = await this.authService.isAuthenticated();

  //   if (!isAuthenticated) {
  //     // Token is expired or not present, you can handle this here
  //     // For example, you might want to redirect to the login page
  //     this.router.navigate(['/login']);
  //   }
  // }

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
