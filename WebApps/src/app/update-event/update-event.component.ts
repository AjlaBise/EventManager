import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Eventt } from '../event.model';
import { EventService } from '../event.service';
import { Events } from '../events.model';

@Component({
  selector: 'app-update-event',
  templateUrl: './update-event.component.html',
  styleUrls: ['./update-event.component.scss'],
})
export class UpdateEventComponent implements OnInit {
  events: Events;
  event: Eventt;

  checkoutForm;
  id: number;

  constructor(
    private eventService: EventService,
    private route: ActivatedRoute,
    private formBuilder: FormBuilder
  ) {
    this.checkoutForm = formBuilder.group({
      id: +this.route.snapshot.params['id'],
      name: '',
      description: '',
      createById: null,
    });
  }

  ngOnInit(): void {
    this.getEvent();
  }

  onSubmit(eventUpdate) {
    this.eventService.updateEvent(eventUpdate
    ).subscribe();
    this.checkoutForm.reset();
    this.getEvent();
    // location.reload();
  }

  getEvent() {
    this.eventService
      .getEvent(+this.route.snapshot.params['id'])
      .subscribe((data) => {
        this.events = data;
        this.event = this.events.event;
      });
  }
}
