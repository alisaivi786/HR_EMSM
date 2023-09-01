import { Component } from '@angular/core';
import { DataService } from '../shared/DataService';
import { CookieService } from 'ngx-cookie-service';
@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})

export class NavMenuComponent {
  isExpanded = false;

  constructor(private dataService: DataService,private cookieService: CookieService) {
  }
  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
 
  login() {
    this.dataService.login('alimushtaq', 'Password1').subscribe(response => {
      // Assuming a successful login will return a token
      console.log('Token:', response);
      if (response.success && response.error === null) {
        // Save the token to cookies
        this.cookieService.set('auth_token', response.data.token);
        console.log('Token saved to cookies:', response.data.token);
      } else {
        console.error('Authentication failed:', response.message);
      }
    }, error => {
      console.error('Login error:', error);
    });
  }
}
