import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RegistrationModel } from 'src/app/models/registration-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiUserService {

  private _url = "https://localhost:44301/api/user/"

  constructor(
    private _http: HttpClient
  ) { }

  signup(reg: RegistrationModel): Observable<any> {
    return this._http.post(this._url + '/registration', reg) as Observable<any>;
  }
}
