import { Injectable, Output } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import {Event} from './event.model';

@Injectable({
  providedIn: 'root',
})
export class EventService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  private eventUrl = "https://localhost:44308/api/event";

  constructor(private http: HttpClient){}

  getEvents(): Observable<Event[]> {
    const url = `${this.eventUrl}/gettopten`;
    return this.http.get<Event[]>(url);
  }

  addEvent(event: Event): Observable<Event> {
    const url = `${this.eventUrl}/insert`;
    return this.http.post<Event>(url, event, this.httpOptions);
  }

  deleteEvent(id: number): Observable<Event> {
    const url = `${this.eventUrl}/remove/${id}`;
    return this.http.delete<Event>(url);
  }
}
