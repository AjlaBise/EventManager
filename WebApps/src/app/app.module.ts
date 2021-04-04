import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { EventComponent } from './event/event.component';
import { EventContainerComponent } from './event-container/event-container.component';
import { UpdateEventComponent } from './update-event/update-event.component';
import { AddEventComponent } from './add-event/add-event.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    EventComponent,
    EventContainerComponent,
    UpdateEventComponent,
    AddEventComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
