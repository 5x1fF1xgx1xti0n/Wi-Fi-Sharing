import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/services/user/user.service';
import { RegistrationModel } from 'src/app/models/registration-model';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  regModel = new RegistrationModel();
  passConfirm: string = '';

  constructor(
    private _router: Router,
    private _userService: UserService
  ) { }

  ngOnInit() {
    let token = localStorage.getItem('auth_token');
    if (token != undefined && token != null && token != '') {
      this._router.navigate(['/home']);
    }
  }

  signup() {
    debugger;
    if (this.regModel.password == this.passConfirm) {
      this._userService.signup(this.regModel);
    }
  }
}
