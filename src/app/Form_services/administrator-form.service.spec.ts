import { TestBed } from '@angular/core/testing';

import { AdministratorFormService } from './administrator-form.service';

describe('AdministratorFormService', () => {
  let service: AdministratorFormService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdministratorFormService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
