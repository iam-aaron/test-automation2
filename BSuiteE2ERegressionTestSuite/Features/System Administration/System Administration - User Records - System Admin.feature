@AllTests @BSuite @BSuite-Website @System-Admin @System-Administration
Feature: System Administration - User Records - System Admin
	As a User with role "System Admin",I am able to add a new User Account.

@GSQA-110 @PositiveTests
Scenario: System Administration - User Records - System Admin
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with role '<Role>'	
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'
	And I have navigated to 'Personnel' page from the top menu Lookup
	And I click the 'Add Person' button 
	And I enter the following details in the 'Personnel' page
		| Field            | Value                 |
		| First Name       | TestFieldTech         |
		| Last Name        | Regression            |
		| Email            | testfieldtech         |
		| Company          | Bytecraft Systems P/L |
		| AddressName      | TestFieldTech         |
		| Address_Line 1   | 180 Ann St            |
		| Address_Suburb   | Brisbane              |
		| Address_Postcode | 4000                  |
		| Address_Country  | Australia             |
		| Address_State    | QLD                   |  
		| Address_Timezone | Australia/Brisbane    |
	And I click the 'Save' button to save the user details
	And I have navigated to 'Personnel' page from the top menu Lookup
	When I enter the following details in the 'Personnel' page
	| Field            | Value         |
	| Search People    | TestFieldTech |
	| searchActiveFlag | ALL           |  
	And I click the 'Search User' button to load details
	Then I verify the user name newly added

#
#
#	
#
#Examples: 
#	| Role         | 
#	| System Admin | 


