@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Action Types - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to add an Action Type.

@GSQA-113 @PositiveTests
Scenario: System Administration - Action Types - System Admin
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'	
	And I can navigate to 'Admin' page from the top menu
	And I click the 'Action Types' link
	And 'Action Type' page is displayed
	And I click the 'Add New Action Type' button 
	And I enter the following details in the 'Cause Categories' page
		| Field                   | Value                              |
		| Action Type Name        | RegressionTest                     |
		| Part Required           | Not Checked                        |
		| Part Insurance Required | Not Checked                        |
		| Part Movement Direction | NONE                               |
		| Work Type               | ALH Group - IT Support - Break Fix |
		| Part Type Groups        | ATS                                |  
	And I click the 'Save' button	
	When I enter the following details in the 'Action Type' page
	| Field               | Value          |
	| Search Action Types | RegressionTest |  
	And I click the 'Search' button to search the details
	Then I verify the Action Type newly added

