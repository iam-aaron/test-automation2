@AllTests @BSuite @BSuite-Website @Logistics-Storeman @Parts
Feature: Parts - Purchase Order Reconciliation - Logistics Storeman
As a BSuite Desktop User with Role Logistics Storeman
I am able to perform reconciliation of stocks on Purchase Orders into Bytecraft Logistics departments from suppliers.

@GSQA-78 @PositiveTests
Scenario Outline: Parts - Purchase Order Reconciliation - Logistics Storeman
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
	And I log off from Bsuite 'Desktop' portal  
	#And I have opened the BSuite Desktop Portal
	#And I login as a User with User Profile as follows
	#| Role               | Username         | Password |
	#| Logistics Storeman | TestLogStoreman1 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Logistics Storeman'
	And I have navigated to 'Reconcile Purchase Order' page from the top menu
	And I enter the Purchase  Order  number on 'Reconcile Purchase Order' page
	And I enter the following details in the 'Reconcile Purchase Order' page
	| Field               | Value/Action                    |
	| Delivery/Invoice No | DELINV                          |
	| Forwarded to        | Bugs Bunny                      |
	| Delivery Notes      | Order has been fully reconciled |
	| Rec. Qty            | 1                               |
	| Part Notes          | Part has been fully reconciled  |
	And I have clicked 'Save' button on Desktop Portal
	And I verify 'Successfully saved Delivery.' message once the reconciliation is successful
	Then I verify Purchase Order history at the bottom of the page

	 

	Examples:
	| Purchase Order No |
	| BYT               |
	| FS                |
	| WS                |
	| B00               |