@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Zonesets - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to view/add a ZoneSet under an Area under a Region within a Country.As a User with role System Admin accessing BSuite desktop portal,I am able to view/add an Area under a Region.

@GSQA-116 @PositiveTests
Scenario: System Administration - Zonesets - System Admin
	Given I have opened the BSuite Desktop Portal
	And I login as a User with role '<Role>'	
	And I have navigated to 'Region' page from the top menu Lookup
	When I select the 'Please Select' drop down value as 'Regions' for the country 'Name' 'Australia'	
	Then The 'List of Regions' within the country 'Australia' is displayed
	When I click the 'Areas' button for the 'Region' 'QLD'
	Then The 'List of Areas' under the region 'QLD' within the country 'Australia' is displayed
	When I click the 'Zone Sets' button for the 'Area Name' 'QLD Metro'
	Then The 'List of Zone Sets' under the area 'QLD Metro' within the Region 'QLD' is displayed


Examples: 
	| Role         | 
	| System Admin | 


