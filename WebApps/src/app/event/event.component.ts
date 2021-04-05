import { Component, OnInit } from '@angular/core';
import {EventService} from 'src/app/event.service';
import {Event} from '../event.model';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {


  constructor() { }

  ngOnInit(): void {
  
  }

}
