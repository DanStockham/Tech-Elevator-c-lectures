Feature: Compound Interest
	In order to understand how much I can save
	through annual compound interest, I need a 
	compound interest calculator.

# This is a comment about the scenario.
# This particular scenario doesn't use any input values it provides exact steps and leaves
# it up to the step definition to define the values
Scenario: Calculate Compound Interest
	Given I am on the home page
	And I want to calculate compound interest
	When I enter my principal, interest rate, and term
	Then I should see how much money I have saved

Scenario: Skip Required Data
	Given I am on the home page
	And I want to calculate compound interest
	When I submit the form without the required data
	Then I should see the calculate compound interest page again