@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - Cloning Records - System Admin
	As a User with role "System Admin",I am able to Clone User Account from an existing User Account.

@GSQA-109 @PositiveTests
Scenario: System Administration - Cloning Records - System Admin
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with role '<Role>'	
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'
	And I can navigate to 'Admin' page from the top menu
	And I click the 'Clone User Account' link to clone the user account	 
	And I enter the following details in the 'Clone User Account' page
		| Field      | Value                                                            |
		| Company    | TABCORP                                                          |
		| Clone from | testfieldtechnician100 BSuiteRegression - testfieldtechnician100 |  
		| First Name | TestFT                                                           |
		| Last Name  | Regression                                                       |
		| Email      | TestFTRegression@tabcorp.com.au                                  |
		| User Name  | TestFT                                                           |
		| Password   | bsuite                                                           |
	When I click the 'Create' button	
	Then I fetch the user full name created successfully
	And I have navigated to 'Personnel' page from the top menu Lookup
	When I enter the following details in the 'Personnel' page
	| Field            | Value  |
	| Search People    | TestFT |
	| searchActiveFlag | ALL    |  
	And I click the 'Search User' button to load details
	Then I verify the user name newly added

#	
#
#
#
#	
#
#Examples: 
#	| Role         | 
#	| System Admin | 


