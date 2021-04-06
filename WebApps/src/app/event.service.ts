import { Injectable, Output } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Eventt } from './event.model';
import { Events } from './events.model';

@Injectable({
  providedIn: 'root',
})
export class EventService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  private eventUrl = "https://localhost:44308/api/event";

  constructor(private http: HttpClient){}

  getEvents(): Observable<Eventt[]> {
    const url = `${this.eventUrl}/gettopten`;
    return this.http.get<Eventt[]>(url);
  }

  getEvent(id: number): Observable<Events> {
    const url = `${this.eventUrl}/getbyid/${id}`;
    return this.http.get<Events>(url);
  }
  addEvent(Eventt: Eventt): Observable<Eventt> {
    const url = `${this.eventUrl}/insert`;
    return this.http.post<Eventt>(url, Eventt, this.httpOptions);
  }

  deleteEvent(id: number): Observable<Eventt> {
    const url = `${this.eventUrl}/remove/${id}`;
    return this.http.delete<Eventt>(url);
  }

  updateEvent(event: Eventt): Observable<Eventt> {
    const url = `${this.eventUrl}/update`;
    console.log(event);
    return this.http.put<Eventt>(url, event, this.httpOptions);
  }
}
