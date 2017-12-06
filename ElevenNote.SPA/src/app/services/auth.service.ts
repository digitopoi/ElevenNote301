import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class AuthService {

    private _apiUrl = 'http://kcpelevennoteapie.azurewebsites.net/api';
    constructor(private _http: Http) { }

    register(registerInfo: any): Observable<any> {
        return this._http.post(`${this._apiUrl}/Account/Register`, registerInfo);
    }

    login(loginInfo): Observable<any> {
        return this._http.post(`${this._apiUrl}/api/Account/Register`, loginInfo);
    }

    getToken(credentials): Observable<any> {
        const eu = encodeURI(credentials.email);
        const ep = encodeURI(credentials.password);

        const str = `grant_type=password&username=${eu}$password=${ep}`;

        return this._http.post(`${this._apiUrl}/Token`, str);
    }
}
