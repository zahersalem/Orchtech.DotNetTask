import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IEnrolment } from '../Intefaces/IEnrolment';

@Injectable()
export default class 
 {
  public API = 'http://localhost:8080/api';
  public ENROLMENT_API = `${this.API}/enrolment`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<IEnrolment>> {
    return this.http.get<Array<IEnrolment>>(this.ENROLMENT_API);
  }

  get(id: string) {
    return this.http.get(`${this.ENROLMENT_API}/${id}`);
  }

  save(enrolment: IEnrolment): Observable<IEnrolment> {
    let result: Observable<IEnrolment>;
    if (enrolment.Id) {
      result = this.http.put<IEnrolment>(
        `${this.ENROLMENT_API}/${enrolment.Id}`,
        enrolment
      );
    } else {
      result = this.http.post<IEnrolment>(this.ENROLMENT_API, enrolment);
    }
    return result;
  }

  remove(id: number) {
    return this.http.delete(`${this.ENROLMENT_API}/${id.toString()}`);
  }
}