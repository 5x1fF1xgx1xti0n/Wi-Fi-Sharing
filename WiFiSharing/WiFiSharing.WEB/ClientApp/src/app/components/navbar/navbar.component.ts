import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/services/auth/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  token = null; 

  constructor(
    private _authService: AuthService
  ) { }

  ngOnInit() {
    this.token = localStorage.getItem('auth_token');
  }

  logout() {
    this._authService.logout();
  }
}
