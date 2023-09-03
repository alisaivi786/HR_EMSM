import { Component } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})

export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router,private cookieService: CookieService) {
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
 
   // Logout method
   logout() {
    // Clear the authentication token from cookies
    this.cookieService.delete('auth_token');
    
    // Navigate to the login page
    this.router.navigate(['/login']);
  }
}
