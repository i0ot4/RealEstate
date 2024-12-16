import { Routes } from '@angular/router';
import { BodyComponent } from './Home/Dashboard/body/body.component';
import { SiteBodyComponent } from './Home/Site/site-body/site-body.component';

export const routes: Routes = [
  { path: 'dashboard', component: BodyComponent },
  { path: 'site', component: SiteBodyComponent },
  { path: '', redirectTo: '/site', pathMatch: 'full' }
];