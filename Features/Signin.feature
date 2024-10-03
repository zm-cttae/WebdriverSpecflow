Feature: Signin

	Scenario: Username visible on signin
		Given I went to the mainpage
		When I click the signin link
		Then I am on the signin page
		When I enter the login details
		And I click the login button
		Then I am on the mainpage
		And Profile name should appear