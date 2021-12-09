@AllTests @BSuite @HealthAndSafety @Pre-Start-Form @ignore
Feature: Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path - via Mobile
	As a BSuite Mobile User
	I can login to BSuite mobile portal
	So that I can verify is Daily PreStart form is being displayed in mobile portal

@GSQA-163 @Positive-Scenario-B-Suite-Mobile @Pre-Start-Form 
Scenario Outline: Health and Safety - Mobile Daily PreStart Form - Field Technicians Daily PreStart Form will be available for Field Technician in Mobile Portal only
	#Given I have opened the BSuite Mobile Portal
	Given I have logged into 'BSuite Mobile' portal as a User with following User Profile
	#When I login as a User with User Profile as follows
		| Role   | Username   | Password   |
		| <Role> | <Username> | <Password> |  
	When login is successful
	And I am required to complete the Pre Start Checklist for the day in mobile portal
	Then the 'first' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                                       |
		| 1               | My vehicle is roadworthy – e.g. windscreen and mirrors free of damage, all lights operational and tyres inflated with sufficient tread. |
	When I respond 'Yes' to the 'first' Pre Start Checklist question in mobile portal 
	Then the 'second' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                        |
		| 2               | Are all licenses that you require for your duties / role currently valid? E.G. drivers licence, gaming licence? |  
	When I respond 'Yes' to the 'second' Pre Start Checklist question in mobile portal
	Then the 'third' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                              |
		| 3               | Are your tools and equipment in good condition and do you have sufficient / enough PPE? |
	When I respond 'Yes' to the 'third' Pre Start Checklist question in mobile portal
	Then the 'fourth' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                                                                                                                                        |
		| 4               | Have you completed all mandatory training relevant to your Field Technicians Role – (e.g. Electrical safety / lifting / ladders etc.) OR are you familiar with all of the SWP (Safe Work Practice) documents relevant to your role? |
	When I respond 'Yes' to the 'fourth' Pre Start Checklist question in mobile portal
	Then the 'fifth' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                 |
		| 5               | I am fit for work and can perform my work without compromising the safety or health of myself or others. |  
	When I respond 'Yes' to the 'fifth' Pre Start Checklist question in mobile portal
	Then I click the 'Submit' button
		
	Examples: 
	| Role             | Username          | Password |
	| Field Technician | TestField163Tech1 | bsuite   |

 