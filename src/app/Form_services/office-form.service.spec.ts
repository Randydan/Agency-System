import { TestBed } from '@angular/core/testing';

import { OfficeFormService } from './office-form.service';

describe('OfficeFormService', () => {
  let service: OfficeFormService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OfficeFormService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
