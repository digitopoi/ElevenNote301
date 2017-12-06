import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AuthService {

    private _apiUrl = 'http://kcpelevennoteapie.azurewebsites.net/api';
    constructor(private _http: Http) { }

    register(registerInfo: any) {
        return this._http.post(`${this._apiUrl}/Account/Register`, registerInfo);
    }
}
