import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Parent } from './Models/Parent.model';

@Injectable({
  providedIn: 'root'
})
export class ParentService {

  constructor(private http: HttpClient) { }
  public getAllParent(): Observable<Parent[]> {
    console.log("tttttttttt")
    return this.http.get<Parent[]>('https://localhost:7094/api/Peren')
  }
}
