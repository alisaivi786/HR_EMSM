import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeaveNatureMenuComponent } from './leave-nature-menu.component';

describe('LeaveNatureMenuComponent', () => {
  let component: LeaveNatureMenuComponent;
  let fixture: ComponentFixture<LeaveNatureMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeaveNatureMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeaveNatureMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
