import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import {catchError, retry} from 'rxjs/operators';
import { ClienteOrden } from '../models/clienteOrden';
import { Response } from '../models/response';
import {throwError as observableThrowError} from 'rxjs';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class ApiclienteService {

  url: string = 'https://localhost:5001/api/Cliente'

  public Answer: any[] = [];

  constructor(private _http: HttpClient) { }

  get():Observable<Response> {
    return this._http.get<Response>(this.url);
  }

  add(cliente: ClienteOrden): Observable<Response>{
    return this._http.post<Response>(this.url, cliente, httpOptions)
  }

  edit(cliente: ClienteOrden): Observable<Response>{
    console.log(cliente);
    return this._http.put<Response>(this.url, cliente, httpOptions);
  }

  delete(cliente: ClienteOrden): Observable<Response>{

    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: {
        idCliente: `${cliente.idCliente}`,
        nombre: ''

      }
    }
    return this._http.delete<Response>(`${this.url}/${cliente.idCliente}`, httpOptions)

  }


}
