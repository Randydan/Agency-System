import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateClassroomFormComponent } from './update-classroom-form.component';

describe('UpdateClassroomFormComponent', () => {
  let component: UpdateClassroomFormComponent;
  let fixture: ComponentFixture<UpdateClassroomFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateClassroomFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateClassroomFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
