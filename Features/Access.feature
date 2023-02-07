Feature: Login

@regression @validaccess
@DataSource:AccessData.xlsx @DataSet:Valid
Scenario: Login with valid credentials
	Given user is on '<testurl>' home page
	When  user enters <username> in username text field
	And   user enters <password> in password text field
	And   user click on Login button
	Then  username is displayed on dashboard
	When  user click on Signout button
	Then  user is navigated to home page

@regression @invalidaccess
@DataSource:AccessData.xlsx @DataSet:Invalid
Scenario: Login with invalid credentials
	Given user is on '<testurl>' home page
	When  user enters <username> in username text field
	And   user enters <password> in password text field
	And   user click on Login button
	Then  login error is displayed

