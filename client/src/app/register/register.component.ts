import { Component, input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css',
})
export class RegisterComponent {
  //using this decorator and property to pass down child components
  // we use input signal to register input withing propertity in html
  usersFromHomeComponent = input.required<any>();
  model: any = {};

  register() {
    console.log(this.model);
  }

  cancel() {
    console.log('cancelled');
  }
}
