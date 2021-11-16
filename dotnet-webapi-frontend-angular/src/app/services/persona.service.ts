import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from '../domain/persona';

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

  public save(persona: Persona): Observable<any> {
    return this.httpClient.post(this.url, persona);
  }
}
