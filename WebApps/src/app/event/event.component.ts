import { Component, OnInit } from '@angular/core';
import { EventService } from 'src/app/event.service';
import { Event } from '../event.model';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css'],
})
export class EventComponent implements OnInit {
  events: Event[];

  constructor(private eventService: EventService) {}

  ngOnInit(): void {
    this.getEvents();
  }

  getEvents() {
    this.eventService.getEvents().subscribe((data: any) => {
      this.events = data.collection;
      console.log(data.collection);
    });
    console.log(this.events);
  }
}
