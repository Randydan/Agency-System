import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateDepartmentFormComponent } from './update-department-form.component';

describe('UpdateDepartmentFormComponent', () => {
  let component: UpdateDepartmentFormComponent;
  let fixture: ComponentFixture<UpdateDepartmentFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateDepartmentFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateDepartmentFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
