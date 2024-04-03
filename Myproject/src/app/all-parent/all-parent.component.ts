import { Component } from '@angular/core';
import { Parent } from '../Models/Parent.model';
import { Router } from '@angular/router';
import { ParentService } from '../parent.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-all-parent',
  standalone: true,
  imports: [NgFor],
  templateUrl: './all-parent.component.html',
  styleUrl: './all-parent.component.css'
})
export class AllParentComponent {

parentlist!:Parent[]
constructor(private router: Router, private _parentService:ParentService ) {}



  ngOnInit(): void{


    this._parentService.getAllParent().subscribe({
      next: (res) => {


        this.parentlist = res

        console.log(this.parentlist)
      },
      error: (err) => {
        console.log(err);
      },
      complete: () => {
        console.log('finish');
      }
    });




  }


}
