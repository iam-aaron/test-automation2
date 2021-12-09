@AllTests @BSuite @Bsuite-Website @HealthAndSafety @Survey-Reporting @Logistics-Team-Member @PreStart-Desktop-Report @ignore
Feature: Health and Safety - Reports - Prestart Desktop Report

	As a BSuite Desktop User
	I can login to BSuite Desktop portal
	So that I can carry out my tasks

@GSQA-177 @PositiveTests 
Scenario: Health and Safety - Reports - Prestart Desktop Report - Day 1 Prestart Form
All run on a single day(No Day 1 and Day 2)
	Given I have opened the BSuite Desktop Portal
	When I login as a User with role '<Role>' for the first time in a day
	Then I am required to complete the Pre Start Checklist for the day
	And the 'first' question of the Pre Start Checklist is displayed as follows
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
	And I log off from Bsuite 'Desktop' portal
	When I have logged into BSuite 'Desktop' portal as a User with role 'Service Delivery Manager'
	And I can navigate to 'Reports' page from the top menu
	And I have clicked 'Prestart Desktop' link 
	And I select DateTime range for current day
	And I click 'Output To CSV' button to download the Prestart Report
	Then Open the downloaded Prestart Report to verify structure and Prestart Checklist responses of '<Role>' are recorded accurately

Examples: 
	| Role                 |
	| Logistics Technician |
	#| Workshop Technician  |
	
