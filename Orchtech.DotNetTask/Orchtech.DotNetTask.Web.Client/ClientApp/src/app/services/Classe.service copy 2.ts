import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IClasse } from '../Intefaces/IClasse';

@Injectable()
export default class 
 {
  public API = 'http://localhost:8080/api';
  public CLASSE_API = `${this.API}/classe`;

  constructor(private http: HttpClient) {}

  getAll(): Observable<Array<IClasse>> {
    return this.http.get<Array<IClasse>>(this.CLASSE_API);
  }

  get(id: string) {
    return this.http.get(`${this.CLASSE_API}/${id}`);
  }

  save(classe: IClasse): Observable<IClasse> {
    let result: Observable<IClasse>;
    if (classe.Id) {
      result = this.http.put<IClasse>(
        `${this.CLASSE_API}/${classe.Id}`,
        classe
      );
    } else {
      result = this.http.post<IClasse>(this.CLASSE_API, classe);
    }
    return result;
  }

  remove(id: number) {
    return this.http.delete(`${this.CLASSE_API}/${id.toString()}`);
  }
}