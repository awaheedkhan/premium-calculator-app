# premium-calculator-app
A sample application for premium calculations

# Dependencies
.Net Core Latest
Angular CLI: 11.2.2
Node: 14.16.0

Package                      Version
------------------------------------------------------
@angular-devkit/architect    0.1102.2 (cli-only)
@angular-devkit/core         11.2.2 (cli-only)
@angular-devkit/schematics   11.2.2 (cli-only)
@schematics/angular          11.2.2 (cli-only)
@schematics/update           0.1102.2 (cli-only)

# How to run the application
PremiumCalculator solution (.sln) contains implementation of the API and Unit Tests. Web folder contains a angular based web client.

Step#1: Get latest code
Step#2: Run API (PremiumCalculator.Api should be set as default)
 2.1: API should be available on http://localhost:52123/
Step#3: Run web client 
 3.1: Open folder premium-calculator-app\web\premium-calculator\src\app
 3.2: Run commoand (ng serve -o)
 3.3: Client application should be available on http://localhost:4200/

