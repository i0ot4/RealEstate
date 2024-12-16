import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SiteBodyComponent } from "./Home/Site/site-body/site-body.component";
import { BodyComponent } from './Home/Dashboard/body/body.component';

@Component({
  selector: 'app-root',
  imports: [BodyComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'RealEstate';
}
