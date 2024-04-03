import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Children } from '../Models/children-model.module';
import { Parent } from '../Models/Parent.model';
import { ChildserviceService } from '../childservice.service';

@Component({
  selector: 'app-all-children',
  standalone: true,
  imports: [],
  templateUrl: './all-children.component.html',
  styleUrl: './all-children.component.css'
})
export class AllChildrenComponent {

  public childrenList!: Children[];


  constructor(private router: Router, private _ChildrenService:ChildserviceService , private _ParentService: Parent) {
  }
  ngOnInit(): void{


    this._ChildrenService.getAllChildren().subscribe({
      next: (res) => {
        this.childrenList = res
        console.log(this.childrenList)
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
