@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Cause Codes - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to add a Cause Category.

@GSQA-111 @PositiveTests
Scenario: System Administration - Cause Codes - System Admin
	Given I have opened the BSuite Desktop Portal
	And I login as a User with role '<Role>'	
	And I can navigate to 'Admin' page from the top menu
	And I click the 'Cause Categories' link to add cause category
	And I click the 'Add Cause Category' button 
	And I enter the following details in the 'Cause Categories' page
		| Field              | Value                              |
		| Category Code      | RT                                 |
		| CauseCategory Name | RegressionTest                     |
		| Active             | Checked                            |
		| Billable           | Not Checked                        |
		| WorkTypeList       | ALH Group - IT Support - Break Fix |  
	And I click the 'Save' button	
	When I enter the following details in the 'Cause Categories' page
	| Field                 | Value |
	| Search Cause Category | RT    |  
	And I click the 'Search' button to load details
	Then I verify the category newly added



	

Examples: 
	| Role         | 
	| System Admin | 


