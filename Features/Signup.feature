Feature: Sign-In

@Signup
Scenario: Verify user will be able to create a new account
	Given I navigate to the website URL
		| url | magento |
	Then I should land on the required page
		| title | Home Page |
	When I click on the Create an Account
	Then I should land on the required page
		| title | Create New Customer Account |
	When I fill in the account creation details
		| firstname     | Jagadeeswar                |
		| lastname      | Reddy                      |
		| email         | jagadeeswar91119@gmail.com |
		| password      | Admin@123                  |
		| password_conf | Admin@123                  |
	And I click on the Create an Account button
	Then I should land on the required page
		| title | My Account |
	And I should see the user details on the logged-in account page
		| username | Welcome, Jagadeeswar Reddy! |


@SignupFail
Scenario: Verify user will be not able to create a new account with existing mail
	Given I navigate to the website URL
		| url | magento |
	Then I should land on the required page
		| title | Home Page |
	When I click on the Create an Account
	Then I should land on the required page
		| title | Create New Customer Account |
	When I fill in the account creation details
		| firstname     | Jagadeeswar                    |
		| lastname      | Reddy                          |
		| email         | jagadeeswar.re115d29@gmail.com |
		| password      | Admin@123                      |
		| password_conf | Admin@123                      |
	And I click on the Create an Account button
	Then Verify error message
		| error | duplicateaccountcreation |

@SignupErrorMessages
Scenario: Verify mandetory field error messages
	Given I navigate to the website URL
		| url | magento |
	Then I should land on the required page
		| title | Home Page |
	When I click on the Create an Account
	Then I should land on the required page
		| title | Create New Customer Account |
	Then Verify mandetory field error messages
