import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OpenProjectsComponent } from './open-projects.component';

describe('OpenProjectsComponent', () => {
  let component: OpenProjectsComponent;
  let fixture: ComponentFixture<OpenProjectsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OpenProjectsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OpenProjectsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
