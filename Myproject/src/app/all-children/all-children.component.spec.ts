import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllChildrenComponent } from './all-children.component';

describe('AllChildrenComponent', () => {
  let component: AllChildrenComponent;
  let fixture: ComponentFixture<AllChildrenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AllChildrenComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AllChildrenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
