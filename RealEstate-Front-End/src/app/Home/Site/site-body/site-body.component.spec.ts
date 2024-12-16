import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteBodyComponent } from './site-body.component';

describe('SiteBodyComponent', () => {
  let component: SiteBodyComponent;
  let fixture: ComponentFixture<SiteBodyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SiteBodyComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SiteBodyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
