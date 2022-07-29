Feature: Login



Scenario:Verify SwagLabs login functionality on chrome
	Given Chrome is Opened and SwagLab app is Opened
	When User enters correct Username "standard_user" and Password "secret_sauce"
	When User Click on login button
	Then It Shows home page
	When User click on Hamburger
	Then It Shows lists of components
	And User clicks on About
	
	


	


	

	