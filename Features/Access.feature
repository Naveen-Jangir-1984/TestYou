Feature: Login

@validaccess
Scenario Outline: Login with valid credentials
	Given user in on <testurl> home page
	When user enters <username> in username text field
	And user enters <password> in password text field
	And user click on Login button
	Then username is displayed on dashboard
	When user click on Signout button
	Then user is navigated to home page
	Examples: 
	| testurl                             | username        | password   |
	| 'https://www.testyou.in/Login.aspx' | testwithtestyou | 0123456789 |
