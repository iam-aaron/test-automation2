@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Regions - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to view/add a Region.

@GSQA-114 @PositiveTests
Scenario: System Administration - Regions - System Admin
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with role '<Role>'	
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'
	And I have navigated to 'Region' page from the top menu Lookup
	When I select the 'Please Select' drop down value as 'Regions' for the country 'Name' 'Australia'	
	Then The 'List of Regions' within the country 'Australia' is displayed

#
#Examples: 
#	| Role         | 
#	| System Admin | 


