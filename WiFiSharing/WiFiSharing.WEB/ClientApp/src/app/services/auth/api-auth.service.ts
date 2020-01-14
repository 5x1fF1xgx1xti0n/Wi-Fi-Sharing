import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Token } from 'src/app/models/token';
import { Credentials } from 'src/app/models/credentials';

@Injectable({
  providedIn: 'root'
})

export class ApiAuthService {

  _url = "https://localhost:44301/api/auth/"

  constructor(
    private _http: HttpClient
    ) { }

    signin(cred: Credentials): Observable<Token> {
      return this._http.post(this._url + "login", cred) as Observable<Token>;
    }
}
