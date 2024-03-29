import { Component, OnInit } from '@angular/core';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title ='helpbypros-app'
  constructor(private auth: AuthService) {}

  ngOnInit() {
   this.auth.localAuthSetup();
    this.auth.handleAuthCallback();
  }

}