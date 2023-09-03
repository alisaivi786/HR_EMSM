import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { AuthService } from 'src/app/Services/AuthService';

@Component({
  selector: 'auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent {
  email: string = ''; 
  password: string = '';
  errorMessage: string | null = null;

  constructor(private authService: AuthService, private router: Router,private cookieService: CookieService) { }

  login() {
    // Reset the error message
    this.errorMessage = null;

    this.authService.login(this.email, this.password).subscribe(response => {
      if (response.success && response.error === null) {
        this.cookieService.set('auth_token', response.data.token);
        this.router.navigate(['/home-page']);
      } else {
        this.errorMessage = 'Invalid email or password.';
      }
    }, error => {
      this.errorMessage = 'An error occurred while trying to log in.';
    });
  }
}
