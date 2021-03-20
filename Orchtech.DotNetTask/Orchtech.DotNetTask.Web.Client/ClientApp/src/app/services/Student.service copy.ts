import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IStudent } from '../Intefaces/IStudent';

@Injectable()
export default class 
 {
  public API = 'http://localhost:8080/api';
  public STUDENT_API = `${this.API}/student`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<IStudent>> {
    return this.http.get<Array<IStudent>>(this.STUDENT_API);
  }

  get(id: string) {
    return this.http.get(`${this.STUDENT_API}/${id}`);
  }

  save(student: IStudent): Observable<IStudent> {
    let result: Observable<IStudent>;
    if (student.Id) {
      result = this.http.put<IStudent>(
        `${this.STUDENT_API}/${student.Id}`,
        student
      );
    } else {
      result = this.http.post<IStudent>(this.STUDENT_API, student);
    }
    return result;
  }

  remove(id: number) {
    return this.http.delete(`${this.STUDENT_API}/${id.toString()}`);
  }
}