import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeopleSaveComponent } from './people-save.component';

describe('PeopleSaveComponent', () => {
  let component: PeopleSaveComponent;
  let fixture: ComponentFixture<PeopleSaveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeopleSaveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeopleSaveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
