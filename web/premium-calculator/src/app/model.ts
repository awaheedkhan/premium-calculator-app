export class PremiumForm
{
  name: string;
  dateOfBirth: Date;
  occupation: Occupation;
  deathCover: number;
  monthlyExpense: number;
  state: string;
  postCode: string;
  premium: Premium;
}

export class MonthlyPremiumRequest
{
    dateOfBirth: Date;
    occupationId: number;
    deathCover: number;
    monthlyExpense: number;
}

export class Premium
{
  deathPremium: number;
  yearlyCover: number;
}

export class Occupation
{
  id: number;
  label: string;
}
