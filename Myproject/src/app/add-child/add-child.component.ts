import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, NgModel, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-child',
  standalone: true,
  imports: [NgFor],
  templateUrl: './add-child.component.html',
  styleUrl: './add-child.component.css'
})
export class AddChildComponent {

  childForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.childForm = this.fb.group({
      name: ['', Validators.required],
      description: [''],
      childId: [null, Validators.required],
      age: [null, Validators.required],
      numOfDarga: [null, Validators.required],
      isRevacha: [false],
      dateOfBirthday: [''],
      motherHelper: [''],
      parent: ['']
    });
  }
  
}

