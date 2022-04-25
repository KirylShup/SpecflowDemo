Feature: Login

@tag1
Scenario: Login SSP as Company Admin 
	Given I navigate to SSP login page
	When I login with username and password
	| Username                     | Password     |
	| kiryl_user_75950929@mail.com | CConnect1234 |
	Then 'InviteNewUser' button should be visible
