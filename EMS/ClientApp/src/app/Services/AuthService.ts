import { Injectable } from '@angular/core';
import { AuthResponse } from '../models/auth-response.model';
import { ApiService } from './ApiService';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isAuthenticatedData : boolean = false;
  bearedToken : string = "";
  constructor(private apiService: ApiService<AuthResponse>,private router: Router) { }

  login(userName: string, password: string): Observable<AuthResponse> {
    const authRequest = { userName, password };
    console.log(authRequest);
    return this.apiService.post('auth/login', authRequest);
  }

  getToken(): Observable<AuthResponse> {
    return this.apiService.get('auth/get-token');
  }

  getTokenValidation(): Observable<any> {
    return this.apiService.get('auth/token-auhtenticated');
  }

  isAuthenticated(): boolean {
    // Add your authentication logic here
    // For example, check if the user is logged in or has a valid token
    this.getTokenValidation().subscribe(response => {
      if (response.success && response.error === null) {
        this.isAuthenticatedData = true;
      } else {
        this.isAuthenticatedData = false;
      }
    }, error => {
      this.isAuthenticatedData = false;
    });

    return this.isAuthenticatedData;
  }

  getTokenFromCookies(): string {
    // Add your authentication logic here
    // For example, check if the user is logged in or has a valid token
    this.getToken().subscribe(response => {
      if (response.success && response.error === null) {
        console.log(response);
        this.bearedToken = response.data.token;
      } else {
        this.bearedToken = "";
      }
    }, error => {
      this.bearedToken = "";
    });

    return this.bearedToken;
  }

  redirectToLogin(): void {
    this.router.navigate(['/login']); // Redirect to the login page
  }
  // You can add more authentication-related methods here as needed.
}
