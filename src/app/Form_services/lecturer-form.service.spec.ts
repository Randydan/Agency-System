import { TestBed } from '@angular/core/testing';

import { LecturerFormService } from './lecturer-form.service';

describe('LecturerFormService', () => {
  let service: LecturerFormService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(LecturerFormService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
