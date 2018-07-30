Feature: Invalid Credentials Login
	User without valid credentials
	should not be able to log in
	to ICD Portal


@InvalidCredentials
Scenario Outline: User cannot login with invalid credentials
	Given I am on the login page
	When I fill in Username field with <username>
	And I fill in Password field with <password>
	And I press the Login button
	Then I should see "Invalid username and/or password" message

	Examples: 
		| example description  | username       | password       |
		| Unregistered User    | "john"         | "password"     |
		| Blank username       | ""		        | "password"     |
		| Blank password       | "john"		    | ""             |
		| Unicode characters   | "Jöḧṅ"		    | "ṗäṡṡẅöṛḋ"     |
		| SQL injection 	   | "' or '1'='1'" | "' or '1'='1'" |

