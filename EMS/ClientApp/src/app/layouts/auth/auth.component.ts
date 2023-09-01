import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { DataService } from 'src/app/shared/DataService';

@Component({
  selector: 'auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {
  email: string = ''; // Binding for email input field
  password: string = ''; // Binding for password input field
  errorMessage: string | null = null;

  constructor(private dataService: DataService, private router: Router,private cookieService: CookieService) { }

  ngOnInit(): void {
  }

  login() {
    // Call the login API using the data from the input fields

    // Reset the error message
  this.errorMessage = null;

    this.dataService.login(this.email, this.password).subscribe(response => {
      if (response.success && response.error === null) {
        // Successfully logged in, handle further actions if needed
        this.cookieService.set('auth_token', response.data.token);
        //console.log('Login successful:', response.data.token);
        this.router.navigate(['/home']);
      } else {
        // Display error message if login fails
        //console.error('Login error:', response.message);
        this.errorMessage = 'Invalid email or password.';
      }
    }, error => {
      //console.error('Login error:', error);
      this.errorMessage = 'An error occurred while trying to log in.';
    });
  }

}
