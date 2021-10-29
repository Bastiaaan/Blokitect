import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivateRegisterComponent } from './private-register.component';

describe('PrivateRegisterComponent', () => {
  let component: PrivateRegisterComponent;
  let fixture: ComponentFixture<PrivateRegisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrivateRegisterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrivateRegisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
