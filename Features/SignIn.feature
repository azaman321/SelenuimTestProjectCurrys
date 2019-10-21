Feature: Sign Into Currys
	As a user I want to be able to Log-in to my account

@mytag
Scenario: Successful Login
	Given I have am on the Currys website
	When I enter my username and passord
	When I select the 'I already have an account' button
	When I click the sign in button
	Then the abbreviation of the username should be visible on the dashboard
