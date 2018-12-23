Feature: MyAccount
	In order to use all funcionalities
	As a user
	I want to be able to manage my account

@mytag
Scenario: user can log in
	Given user opens sign in page 
	And enters correct credentials
	When user submits the login form
	Then user will be logged in

	Scenario: user can open wishlist page
		Given user opens sign in page 
		And enters correct credentials
		Given user submits the login form 
		When user opens my wishlist
		Then user can add new wishlist

@my account
Scenario: User can create an account
		Given user opens sign in page 
		And initiates a flow for creating an account
		And user enters all required personal details
		When sbumits the sign up form
		Then user will be logged in 
		And User's full name will be displayed

