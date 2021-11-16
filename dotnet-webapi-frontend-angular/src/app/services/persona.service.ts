import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  public url: string;

  constructor(public httpClient: HttpClient) {
    this.url = 'https://localhost:5001/api/Persona/';
  }

  public getAll(): Observable<any> {
    return this.httpClient.get(this.url);
  }
}
