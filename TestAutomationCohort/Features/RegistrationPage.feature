Feature: RegistrationPage

As a user
In order to enjoy the benefit of the website, i should be able to sign up successfully.

@tag1
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up 
	And I enter username
	And I enter email
	And I enter password
	When I click on sign up button
	Then I should be able to register successfully
