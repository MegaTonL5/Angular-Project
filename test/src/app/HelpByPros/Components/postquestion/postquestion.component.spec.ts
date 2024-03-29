import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PostquestionComponent } from './postquestion.component';

describe('PostquestionComponent', () => 
{
  let component: PostquestionComponent;
  let fixture: ComponentFixture<PostquestionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PostquestionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PostquestionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
