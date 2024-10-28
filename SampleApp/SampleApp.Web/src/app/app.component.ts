import { Component } from '@angular/core';
import { PersonService } from './services/sample.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  person = { name: '', address: '' };
  submittedPerson: any;
  form: FormGroup;

  constructor(private personService: PersonService, private fb: FormBuilder) {
    this.form = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      address: ['', [Validators.minLength(10), Validators.maxLength(200)]]
    });
  }

  submitForm() {
    if (this.form.invalid) {
      return; // Stop if form is invalid
    }

    const formData = this.form.value;
    console.log('Submitted data:', formData);
    this.personService.addData(formData).subscribe({
      next: (data) => {
        alert("name: " + data.name + "\n" + "address: " + data.address);
        this.form.reset();
      },
      error: (error) => {
        console.error('Error occurred while submitting the form', error);
      }
    });
  }

  onReset() {
    this.form.reset(); // Resets the form fields and validation state
  }
}
