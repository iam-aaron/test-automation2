@AllTests @BSuite @BSuite-Website @State-Supply-Chain-Manager @Parts @Purchase-order
Feature: Parts - Create Purchase Order - State Supply Chain Manager
As a BSuite Desktop User with Role State Supply Chain Manager
I am able to create a Purchase Order in BSuite

@GSQA-77 @PositiveTests
Scenario Outline: Parts - Create Purchase Order - State Supply Chain Manager
	#Given I have opened the BSuite Desktop Portal
	#And I login as a User with User Profile as follows
	#	| Role                       | Username                       | Password |
	#	| State Supply Chain Manager | teststatesupplychainmanager111 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'State Supply Chain Manager'
	And I have navigated to 'Purchase Orders' page from the top menu
	And I click the 'Add New Purchase Order' button
	And I enter the following details in the 'Purchase Orders' page
	| Field               | Value/Action                                                           |
	| Purchase Order No   | <Purchase Order No>                                                    |  
	| Supplier Name       | 3rd Party Supplier                                                     |
	| Order Status        | ORDERED                                                                |
	| Order Currency      | AUD                                                                    |
	| Comments            | This PO is created for regression testing purpose only. Not a real P.O |
	| Part Type           | 1000000 : GMIC (GREY/BLUE)                                             |
	| Diss. Code          | 11.11.1111.11.11111                                                    |
	| Quantity            | 1                                                                      |
	| Unit Cost (Ex. GST) | 100                                                                    |
	And I have clicked 'Add' button on Desktop Portal
	And I have clicked 'Save' button on Desktop Portal
	And I enter the successfully created Purchase Order No
	And I have clicked 'Search' button on Desktop Portal
	And I verify the Purchase Order created

	Examples:
	| Purchase Order No |
	| BYT               |
	| FS                |
	| WS                |
	| B00               |