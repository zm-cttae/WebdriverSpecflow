Feature: Offers Page

	Scenario: Offer link when logged out
		Given I went to the main page
		And I am not logged in
		When I click the Offers link
		Then I am on the login page

	Scenario: Offer link when logged in
		Given I went to the main page
		And I am logged in as demouser
		When I click the Offers link
		Then I am on the Offers page
		And The geolocation error is visible