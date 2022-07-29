Feature: SauceCommunity


#Background: Launch browser and swagLabs Web Application
#Given Chrome is launched and Swaglabs Web application is Opened
#When  User enters correct Username "standard_user" and Password "secret_sauce"
#And   User click on login button
#Then  It shows HomePage

#Scenario: Verifying Hamburger functionality
#When user click on Hamburger
#Then It shows list of components

#Scenario: Verifying About Functionality
#When User clicks on About
#Then It shows saucelabs page 

#Scenario: Verifying Contact Functionality
#When  User clicks on contact
#Then It shows Contact components

#Scenario: Verifying Sauce Community Functionality
#When User clicks on SauceCommunity
#Then It shows SauceCommunity page








Scenario: Verifying the SauceCommunity page
	Given Chrome is opened and SwagLab app is Opened
   And User enters correct Username "standard_user" and Password "secret_sauce"
	When User click on login button
	Then It shows home page
	When user click on Hamburger
   Then It shows lists of components
	When User clicks on About
	Then It shows saucelabs page 
   When  User clicks on contact
	Then It shows Contact components
	When User clicks on SauceCommunity
	Then It shows SauceCommunity page
