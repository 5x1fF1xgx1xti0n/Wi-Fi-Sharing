import { Injectable } from '@angular/core';
import { RegistrationModel } from 'src/app/models/registration-model';
import { ApiUserService } from './api-user.service';
import { AuthService } from '../auth/auth.service';
import { Credentials } from 'src/app/models/credentials';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private _api: ApiUserService,
    private _authService: AuthService
  ) { }

  signup(reg: RegistrationModel) {
    this._api.signup(reg).subscribe(data => {
      let cred = new Credentials(reg.email, reg.password);
      this._authService.signin(cred);
    });
  }
}
