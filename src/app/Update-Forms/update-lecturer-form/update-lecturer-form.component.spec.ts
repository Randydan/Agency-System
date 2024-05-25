import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateLecturerFormComponent } from './update-lecturer-form.component';

describe('UpdateLecturerFormComponent', () => {
  let component: UpdateLecturerFormComponent;
  let fixture: ComponentFixture<UpdateLecturerFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateLecturerFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateLecturerFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
