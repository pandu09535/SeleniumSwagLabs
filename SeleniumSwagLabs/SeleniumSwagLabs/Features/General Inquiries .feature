
Feature: General Inquiries 




Scenario: Verifying the General Inquiries page
	Given Chrome is opened and swagLab app is Opened
    And USer enters correct Username "standard_user" and Password "secret_sauce"
	When USer click on login button
	Then IT shows home page
	When USer click on Hamburger
	Then IT shows lists of components
	When USer clicks on About
	Then IT shows saucelabs page 
    When  USer clicks on contact
	Then IT shows Contact components
	When User clicks on GeneralInquiries
	Then It shows GeneralInquiries page
	