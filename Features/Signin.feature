Feature: SignIn

@LoginSucces
Scenario: Login Success
	Given I navigate to the website URL
		| url | magento |
	Then I should land on the required page
		| title | Home Page |

	When I click on the Sigin an Account
	Then I should land on the required page
		| title | Customer Login |
	When I fill in the account signin details
		| email    | jagadeeswar.re115d29@gmail.com |
		| password | Admin@123                      |
	And I click on the Sign in Account button
	Then I should land on the required page
		| title | Home Page |
	And I should see the user details on the logged-in account page
		| username | Welcome, Jagadeeswar Reddy! |
	Then Click on Logout
	Then I should land on the required page
		| title | Home Page |
		
@LoginFailed
Scenario: Login Failed
	Given I navigate to the website URL
		| url | magento |
	Then I should land on the required page
		| title | Home Page |
	When I click on the Sigin an Account
	Then I should land on the required page
		| title | Customer Login |
	When I fill in the account signin details
		| email    | jagadeeswar.re17788815d29@gmail.com |
		| password | Admin@12113                         |
	And I click on the Sign in Account button
	Then Verify error message
		| error | loginfailed |
	