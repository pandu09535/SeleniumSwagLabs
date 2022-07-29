
Feature: ContactSales


Scenario: Verifying the Contactsale functionality
    Given Chrome is opened And SwagLab app is Opened
    And User enters Correct Username "standard_user" and Password "secret_sauce"
	When User click On login button
	Then It shows Home page
	When user Click on Hamburger
	Then It shows lists of Components
	When User clicks On About
	Then It shows Saucelabs page 
    When  User Clicks on contact
	Then It Shows Contact components
	When User clicks on Contactsales
	Then It shows Contactsales page
	When User enters  FirstName "panduranga"
	And User enters Lastname "sangde"
	And user enters companyname "Saucelabs"
	And user enters Businessmail "panduranga0808@gmail.com"
	And user enters PhoneNumber "8073286898"
	And user select the Companysize
	And user select the Countryname
   # And  user click on CrossbrowserTesting checkbox
	And user fills how did u hear about us Textarea "Social network"
	And user fills comments in commentbox "my problem is pending"
 #  And user clicks on privacy policy checkbox
#	When user clicks on submit button
#	Then It shows thanks for submitting request
	

	

    

	


	