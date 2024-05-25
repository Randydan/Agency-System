import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateAdministratorFormComponent } from './update-administrator-form.component';

describe('UpdateAdministratorFormComponent', () => {
  let component: UpdateAdministratorFormComponent;
  let fixture: ComponentFixture<UpdateAdministratorFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UpdateAdministratorFormComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UpdateAdministratorFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
