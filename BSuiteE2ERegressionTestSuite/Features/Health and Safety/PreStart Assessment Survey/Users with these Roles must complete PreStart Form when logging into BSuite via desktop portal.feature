@AllTests @BSuite @HealthAndSafety @PreStartAssessment 
Feature: Users with these Roles must complete PreStart Form when logging into BSuite via desktop portal

	As a BSuite Desktop User with the following Roles:
		Logistics + Call Desk Technician
		Logistics Admin
		Logistics Admin (Limited Call Desk)
		Logistics Admin (Limited Call Desk) + PO
		Logistics Storeman
		Logistics Storeman (Casual)
		Logistics Storeman (Limited CallDesk)
		Logistics Supervisor
		Logistics Technician
		Workshop + Logistics
		Workshop Admin (NEW)
		Workshop Supervisor
		Workshop Technician (NEW)
	I must complete a Pre Start Assessment Survey when I login for the first time via the BSuite Desktop Portal
	So that I can continue to use the BSuite application to carry out my duties

@BSUITE-10092 @PositiveTests @NegativeTests @ignore
Scenario Outline: BSuite Desktop Users with these Roles must complete PreStart Assessment Survey when logging in for the first time in a day
	Given I have opened the BSuite Desktop Portal
	When I login as a User with role '<Role>' for the first time in a day
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
	| Role                      |
	| Workshop Technician (NEW) |
	| Logistics Admin           |


@BSUITE-10092 @NegativeTests @ignore
Scenario Outline: BSuite Desktop Users PreStart Checklist Negative Paths
	Given I have opened the BSuite Desktop Portal
	When I login as a User with role '<Role>' for the first time in a day
	Then I am required to complete the Pre Start Checklist for the day
	Then the 'first' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                                       |
		| 1               | Are all licenses that you require for your duties/role currently valid? E.G. drivers licence, gaming licence/forklift licence? |
	When I respond 'No' to the 'first' Pre Start Checklist question
	Then a prompt is displayed to contact Supervisor
	When data is enterered in tthat prompt
	And supervisot accepts
	Then the 'second' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                              |
		| 2               | Are your tools and equipment in good condition and do you have sufficient/enough PPE? |
	Then the Submit button is enabled
	When I click the 'Submit' button

Examples: 
	| Role                      |
	| Workshop Technician (NEW) |
