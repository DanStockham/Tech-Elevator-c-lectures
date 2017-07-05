Feature: CreditCardPayoff
	In order to understand how long it will
	take me to pay off my credit card, I need
	a credit card payoff calculator.

# Our scenario below simulates a number of 
# different data entry conditions to make
# sure that the calculator works under different
# sets of data.

Scenario Outline: Calculate Credit Card Payoff
	Given I am on the home page
	And I want to calculate credit card payoff
	When I provide my <apr>, <balance>, and <monthly payment>
	And I submit the calculate credit card form
	Then I should see the payoff page that shows me it takes <months> to pay off

	Examples: 
	| apr | balance  | monthly payment | months			|
	| 2.5 | 25000.00 | 150.00          | 205 months		|
	| 3.0 | 10000    | 124.24          | 90 months		|
