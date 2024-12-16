import { Component } from '@angular/core';
import { SideBarComponent } from "../shared/side-bar/side-bar.component";
import { MainHeaderComponent } from "../shared/main-header/main-header.component";
import { FooterComponent } from "../shared/footer/footer.component";
import { IndexPageComponent } from "../components/index-page/index-page.component";

@Component({
  selector: 'app-body',
  imports: [IndexPageComponent, FooterComponent, MainHeaderComponent],
  templateUrl: './body.component.html',
  styleUrl: './body.component.css'
})
export class BodyComponent {

}
