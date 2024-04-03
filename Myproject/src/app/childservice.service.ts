import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Children } from './Models/children-model.module';


@Injectable({
  providedIn: 'root'
})
export class ChildserviceService {
  constructor(private http: HttpClient) { }
  
  public getAllChildren(): Observable<Children[]> {
    console.log("tttttttttt")
    return this.http.get<Children[]>('https://localhost:7094/api/Child')
  }
  
  // public getCoursesrById(id: number): Observable<Children> {
  //   return this.http.get<Children>(`https://localhost:7040/api/Course/${id}`)
  // }
  // public updatCours(id:number,s:Children): Observable<Children> {
  //   return this.http.put<Children>(`https://localhost:7040/api/Course/${id}`,s);
  // }
  // public AddCourse(s:Children): Observable<Children> {
  //    return this.http.post<Children>('https://localhost:7040/api/Course/',s);
  // }
}
