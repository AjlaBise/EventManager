import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEventComponent } from './add-event/add-event.component';
import { EventContainerComponent } from './event-container/event-container.component';
import { EventComponent } from './event/event.component';
import { UpdateEventComponent } from './update-event/update-event.component';

const routes: Routes = [
  {path:"", component: EventComponent},
  {path:"update-event",component:UpdateEventComponent},
  {path:"add-event", component:AddEventComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
