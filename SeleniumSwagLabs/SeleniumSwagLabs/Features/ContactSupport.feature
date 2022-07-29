Feature: ContactSupport


Scenario: Verifying the ContactSupport page
	Given Chrome is opened and SwagLab App is Opened
    And User enters correct Username "standard_user" And Password "secret_sauce"
	When User click on login Button
	Then It shows home Page
	When user click On Hamburger
	Then It shows Lists of components
	When User Clicks on About
	Then It Shows saucelabs page 
    When  User clicks On contact
	Then It shows contact components
	When User clicks on ContactSupport
	Then It shows ContactSupport page
	And User clicks on Getsupport
	
	