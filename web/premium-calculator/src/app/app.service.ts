import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MonthlyPremiumRequest, Occupation, Premium } from './model';

@Injectable()
export class AppService {

  baseUrl: string;
  constructor(public httpClient: HttpClient) {
    this.baseUrl = 'http://localhost:52123/api/premium';
  }

  getMonthlyPremium(dateOfBirth: Date, occupationId: number, deathCover: number, monthlyExpense: number): Observable<Premium> {
    return this.httpClient.get<Premium>(
      `${this.baseUrl}/monthly?dateOfBirth=${dateOfBirth}&occupationId=${occupationId}&deathCover=${deathCover}&monthlyExpense=${monthlyExpense}`
    );
  }

  getOccupations(): Observable<Occupation> {
    return this.httpClient.get<Occupation>(
      `${this.baseUrl}/occupations`
    );
  }
}
