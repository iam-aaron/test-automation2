@AllTests @BSuite @BSuite-Website @Reporting @System-Admin @Management-System-Reports
Feature: Reporting - Management System Reports - System Admin
As a User with role "System Admin" accessing the BSuite Desktop portal
I am able to generate the following types of Management System Reports:
Bad Dates Report

@GSQA-130 @PositiveTests 
Scenario Outline: Reporting - Management System Reports - System Admin
	#Given I have logged into 'BSuite Desktop' portal as a User with following User Profile
	#	| Role         | Username         | Password |
	#	| System Admin | TestSystemAdmin3 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'
	And I have navigated to 'Reports' page from the top menu
	And I have clicked 'Bad Dates Report' link and entered details as follows
		| Field | Value/Action    |
		| Table | baddates_action |
		| Limit | 500             |
		| Debug | Debug - No      |
	And I click the 'Search' button 
	And I verify the 'Internal Server Error' message displayed

