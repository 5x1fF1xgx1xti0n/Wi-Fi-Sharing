import { Injectable } from '@angular/core';
import { ApiAuthService } from './api-auth.service';
import { Credentials } from 'src/app/models/credentials';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})

export class AuthService {

  constructor(
    private _api: ApiAuthService,
    private _router: Router
  ) { }

    signin(cred: Credentials) {
      this._api.signin(cred).subscribe(data => {
        localStorage.setItem('auth_token', data.auth_token);
        this._router.navigate(['/home']);
      });      
    }

    logout() {
      localStorage.removeItem('auth_token');
      this._router.navigate(['/home']);
      window.location.reload();
    }
}
