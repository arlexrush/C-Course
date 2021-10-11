import { Injectable } from "@angular/core";
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Response} from '../models/response';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':'application/json'
  })
};

@Injectable({providedIn:'root'})
export class ApiauthServices{
  url:string='https://localhost:5001/api/User/login';

  constructor(private _http : HttpClient){

  }

  login(email:string, password:string): Observable<Response>{
    return this._http.post<Response>(this.url,{email, password}, httpOptions);
  }
}
