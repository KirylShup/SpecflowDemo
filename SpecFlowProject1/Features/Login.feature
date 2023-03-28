Feature: Login

@tag1
Scenario: Login SSP as Company Admin 
	Given I navigate to SSP login page
	When I login with username and password
	| Username                     | Password     |
	| some_user_email_here | some_user_password_here |
	Then 'InviteNewUser' button should be visible
