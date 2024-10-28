import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  //API url
  private apiUrl = 'https://localhost:7062/api/Home/AddData';

  constructor(private http: HttpClient) {}

  addData(formData: string): Observable<any> {
    return this.http.post(this.apiUrl, formData);
  }
}
