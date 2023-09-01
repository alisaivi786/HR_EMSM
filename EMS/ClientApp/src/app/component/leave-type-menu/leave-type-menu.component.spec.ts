import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeaveTypeMenuComponent } from './leave-type-menu.component';

describe('LeaveTypeMenuComponent', () => {
  let component: LeaveTypeMenuComponent;
  let fixture: ComponentFixture<LeaveTypeMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeaveTypeMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeaveTypeMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
