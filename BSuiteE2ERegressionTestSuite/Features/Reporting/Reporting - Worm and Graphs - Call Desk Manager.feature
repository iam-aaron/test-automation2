@AllTests @BSuite @BSuite-Website @Reporting @Call-Desk-Manager @WormGraph
Feature: Reporting - Worm and Graphs - Call Desk Manager
As a User with role "Call Desk Manager" accessing the BSuite Desktop portal
I am able to generate Report of type "Worm Graph".

@GSQA-128 @PositiveTests 
Scenario Outline: Reporting - Worm and Graphs - Call Desk Manager
	#Given I have logged into 'BSuite Desktop' portal as a User with following User Profile
	#	| Role              | Username         | Password |
	#	| Call Desk Manager | TestCallDeskMgr2 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Call Desk Manager'
	And I have navigated to 'Reports' page from the top menu
	And I have clicked 'Worm' link and entered details as follows
		| Field                | Value/Action                      |
		| Contract-WorkType(s) | ALH Group - IT Support: Break Fix |
		| Preferred Time Zone  | Australia/Brisbane                |
		| List of Areas        | QLD                               |
	And I check if 'With Mitigation' check box is unchecked
	And I click the 'Display' button 
	And I verify the 'Worm Graph' is displayed
