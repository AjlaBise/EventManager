import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-update-event',
  templateUrl: './update-event.component.html',
  styleUrls: ['./update-event.component.css']
})
export class UpdateEventComponent implements OnInit {

  public name=" ";
  public description=" ";
  public user=" ";
  public startDate="";
  public endDate="";
  constructor() { }

  ngOnInit(): void {
  }

}
