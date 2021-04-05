import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { EventComponent } from './event/event.component';
import { EventContainerComponent } from './event-container/event-container.component';
import { UpdateEventComponent } from './update-event/update-event.component';
import { AddEventComponent } from './add-event/add-event.component';
import { EventCardUpdateComponent } from './event-card-update/event-card-update.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    EventComponent,
    EventContainerComponent,
    UpdateEventComponent,
    AddEventComponent,
    EventCardUpdateComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
