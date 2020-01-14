import { Component, OnInit } from '@angular/core';
import { Credentials } from 'src/app/models/credentials';
import { AuthService } from 'src/app/services/auth/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  credentials = new Credentials("", "");

  constructor(
    private _service: AuthService,
    private _router: Router
  ) { }

  ngOnInit() {
    let token = localStorage.getItem('auth_token');
    if (token != undefined && token != null && token != '') {
      this._router.navigate(['/home']);
    }
  }

  signin() {
    this._service.signin(this.credentials);
  }
}
