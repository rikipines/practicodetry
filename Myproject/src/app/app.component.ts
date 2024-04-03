import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AllChildrenComponent } from './all-children/all-children.component';
import { AddChildComponent } from './add-child/add-child.component';
import { ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,AllChildrenComponent,AddChildComponent, ReactiveFormsModule,HttpClientModule
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Myproject';
}
