Feature: Login

	Scenario: Username visible on login
		Given I went to the main page
		And I am not logged in
		When I click the login link
		Then I am on the login page
		When I enter the login details
		And I click the login button
		Then I am on the main page
		And Profile name should appear