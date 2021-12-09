@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Zones - System Admin
	As a User with role System Admin accessing BSuite desktop portal,I am able to view/add a Zone under a Zone Set

@GSQA-117 @PositiveTests
Scenario: System Administration - Zones - System Admin
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with role '<Role>'
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'	
	And I have navigated to 'Region' page from the top menu Lookup
	When I select the 'Please Select' drop down value as 'Regions' for the country 'Name' 'Australia'	
	Then The 'List of Regions' within the country 'Australia' is displayed
	When I click the 'Areas' button for the 'Region' 'QLD'
	Then The 'List of Areas' under the region 'QLD' within the country 'Australia' is displayed
	When I click the 'Zone Sets' button for the 'Area Name' 'QLD Metro'
	Then The 'List of Zone Sets' under the area 'QLD Metro' within the Region 'QLD' is displayed
	When I click the 'Zones' button for the 'Zone Set' 'QLD Metro N 1'
	Then The 'List of Zones' under the zone set 'QLD Metro N 1' within the area 'QLD Metro' is displayed
#
#
#Examples: 
#	| Role         | 
#	| System Admin | 


