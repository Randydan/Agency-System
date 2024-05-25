import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateOfficeFormComponent } from './update-office-form.component';

describe('UpdateOfficeFormComponent', () => {
  let component: UpdateOfficeFormComponent;
  let fixture: ComponentFixture<UpdateOfficeFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateOfficeFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateOfficeFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
