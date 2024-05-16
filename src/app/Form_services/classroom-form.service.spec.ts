import { TestBed } from '@angular/core/testing';

import { ClassroomFormService } from './classroom-form.service';

describe('ClassroomFormService', () => {
  let service: ClassroomFormService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ClassroomFormService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
