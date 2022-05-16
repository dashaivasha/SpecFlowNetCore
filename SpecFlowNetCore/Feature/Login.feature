Feature: Login
Login to Automationpractice application

@smoke
Scenario: Perfom Login to Automationpractice site
	#steps
	Given I launch the application
	And I click SignIn link
	And I enter the folowing details
	| EmailAddress        | Password |
	| dasiv4nova@yandex.ru | testpass |
	And I click login button
	Then I should see My Account link
	Then I close the application

	@smoke
Scenario: Perfom Login to Automationpractice site with wrong password
	#steps
	Given I launch the application
	And I click SignIn link
	And I enter the folowing details
	| EmailAddress        | Password |
	| dasiv4nova@yandex.ru | test |
	And I click login button
	Then I should not see My Account link
	Then I close the application
