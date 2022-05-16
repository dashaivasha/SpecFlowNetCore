Feature: AddToCart
Add product to cart

	@smoke
Scenario: Perfom Add an item to cart after authorization
	#steps
	Given I launch the application
	And I click SignIn link
	And I enter the folowing details
	| EmailAddress        | Password |
	| dasiv4nova@yandex.ru | testpass |
	And I click login button
	And I click on logo
	And I click the add to cart button
	And I click Proceed to checkout button
	Then I should see product in the cart
	Then I close the application
