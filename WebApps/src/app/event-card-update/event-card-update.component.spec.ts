import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventCardUpdateComponent } from './event-card-update.component';

describe('EventCardUpdateComponent', () => {
  let component: EventCardUpdateComponent;
  let fixture: ComponentFixture<EventCardUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EventCardUpdateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EventCardUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
