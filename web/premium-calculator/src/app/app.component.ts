import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AppService } from './app.service';
import { Occupation, Premium, PremiumForm } from './model';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'premium-calculator';
  formData: PremiumForm;
  isDirty = false;
  loadComplete = false;
  selectedOccupation: Occupation;
  occupations: Occupation[];
  selectedState: string;
  states: string[];

  @ViewChild('editForm', { static: true }) public ngForm: NgForm;

  constructor(private service: AppService) {}

  ngOnInit()
  {
    this.loadOccupations();

    this.formData = new PremiumForm();
    this.formData.name = '';
    this.formData.occupation = null;
    this.formData.monthlyExpense = 0.0;
    this.formData.deathCover = 0.0;

  }

  getPremium(): void {
    this.isDirty = false;
    this.service.getMonthlyPremium(this.formData.dateOfBirth, this.formData.occupation.id,
      this.formData.deathCover, this.formData.monthlyExpense)
    .subscribe((data: Premium) => {
      this.formData.premium = data;
      this.loadComplete = true;
    });
  }

  onOptionsSelected(e)
  {
    if (this.ngForm.valid)
    {
      this.getPremium();
    }
    else
    {
      alert('All input fields are mandatory on this form.');
    }
  }

  loadOccupations()
  {
    this.service.getOccupations()
    .subscribe((data: any) => {
      this.occupations = data;
      this.loadComplete = true;
    });
  }
}
