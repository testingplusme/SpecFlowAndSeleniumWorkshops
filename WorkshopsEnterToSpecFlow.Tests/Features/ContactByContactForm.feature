Feature: ContactByContactForm


@contactform
Scenario: Enter to contact form by url and fill by random data 
	Given I enter to contact form 
	And I fill by random data
	Then I check message "MESSAGE SENT (GO BACK)"
