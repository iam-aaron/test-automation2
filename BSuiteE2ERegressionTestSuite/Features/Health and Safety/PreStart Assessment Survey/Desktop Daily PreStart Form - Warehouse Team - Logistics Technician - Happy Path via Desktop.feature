@AllTests @BSuite @BSuiteDesktop @Login
Feature: Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Logistics Technician - Happy Path via Desktop
	As a BSuite Desktop User
	I can login to BSuite Desktop portal Health and Safety
	So that I can carry out my tasks

@GSQA-166 @PositiveTests 
Scenario Outline: Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Workshop Technician - Happy Path via Desktop
   Given I have opened the BSuite Desktop Portal
	And I login as a User for the first time in a day with user details as follows
	| Role   | Username   | Password   |
	| <Role> | <Username> | <Password> |
	Then I am required to complete the Pre Start Checklist for the day
	Then the 'first' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                                       |
		| 1               | Are all licenses that you require for your duties/role currently valid? E.G. drivers licence, gaming licence/forklift licence? |
	When I respond 'Yes' to the 'first' Pre Start Checklist question
	Then the 'second' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                              |
		| 2               | Are your tools and equipment in good condition and do you have sufficient/enough PPE? |
	When I respond 'Yes' to the 'second' Pre Start Checklist question
	Then the 'third' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                                                                                                                                        |
		| 3               | Have you completed all mandatory training relevant to your Field Technicians Role - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of the SWP (Safe Work Practice) documents relevant to your role? |
	When I respond 'Yes' to the 'third' Pre Start Checklist question
	Then the 'fourth' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                 |
		| 4               | I am fit for work and can perform my work without compromising the safety or health of myself or others. |
	When I respond 'Yes' to the 'fourth' Pre Start Checklist question
	Then the Submit button is enabled
	When I click the 'Submit' button


	Examples:
		| Role                 | Username        | Password |
		| Logistics Technician | TestLog166Tech3 | bsuite   |