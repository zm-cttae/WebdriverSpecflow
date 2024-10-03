Feature: Offers Page

	@ignore
	Scenario: Offer page when logged out
		Given I am on the main page
		And I am not logged in
		When I click the Offers link
		Then I should see the sign in page

	@ignore
	Scenario: Offer link when logged in
		Given I am on the main page
		And I am logged in as demouser
		When I click the Offers link
		Then I should see the Offers page
		And The geolocation error is visible