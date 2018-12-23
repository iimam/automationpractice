Feature: PDP
	In order to avoid silly 
	As a math idiot
	I want to be told the sum of two numbers


	@Cart
	Scenario: User can add product to cart
	 Given user opens dresses section
	 And opens first product from the list
	 And increases quantity to 2
	 When user clicks on add to cart button
    Then product is added to cart
	