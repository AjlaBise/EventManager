import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { EventService } from '../event.service';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-add-event',
  templateUrl: './add-event.component.html',
  styleUrls: ['./add-event.component.css']
})
export class AddEventComponent implements OnInit {

  checkoutForm;

  constructor(private eventService: EventService, private formBuilder: FormBuilder, private router: Router) {
    this.checkoutForm = formBuilder.group({
      name: '',
      description: '',
    
    });
   }

  ngOnInit(): void {
   
  }

  onSubmit(event) {
    console.log(event);
    this.checkoutForm.reset();
    this.eventService.addEvent(event).subscribe();
    // this.router.navigate(['/books']);
  }
}
