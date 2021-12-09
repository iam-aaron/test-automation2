@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Service Plans - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to add a Service Plan.

@GSQA-112 @PositiveTests
Scenario: System Administration - Service Plans - System Admin
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with role '<Role>'	
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'
	And I have navigated to 'Service Plan' page from the top menu Lookup
	And I click the 'Add New' button to load details	
	And I enter the following details in the 'Service Plan' page
		| Field                | Value                              |
		| Contract - Work Type | ALH Group - IT Support - Break Fix |
		| Site                 | 688                                |  
		| Generic Support      | RegressionTest                     |
	And I enter into 'Service Plan Instructions' frame and type as 'This service plan is created for regression testing only.'	
	When I click the 'Save' button to save the details
	Then 'View Service Plan' page is displayed
	Given I click the 'Return To Search' button
	And 'Service Plan' page is displayed
	And I enter the following details in the 'Service Plan' page
		| Field                     | Value                              |
		| WorkType Site Search Text | ALH Group - IT Support - Break Fix |  
	When I click 'Search Service Plans' button	
	Then I verify the service plan newly added
	And I click the 'Home' link
	And I log off from Bsuite 'Desktop' portal
	
#
#Examples: 
#	| Role         | 
#	| System Admin | 


