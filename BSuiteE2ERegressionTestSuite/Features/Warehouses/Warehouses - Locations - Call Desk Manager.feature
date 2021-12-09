@AllTests @BSuite @BSuite-Website @Logistics-Admin @Warehouses
Feature: Warehouses - Locations - Call Desk Manager
As a valid BSuite User with role "Call Desk Manager",
I am able to browse for locations and details about Warehouses.

@GSQA-98    
Scenario: Warehouses - Locations - Call Desk Manager
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Call Desk Manager'
	And   I have navigated to 'Admin Warehouse' page from 'Administration' in 'Logistics' top menu
	And   I enter 'Warehouse Name' as 'VIC CW Activ8me'
	And   I click the 'Search' button to load details
	And   I fetch the warehouse details
	And   I click the 'Show Details' link
	When  I select the 'Show Details' drop down value as 'View Record' in 'Admin Warehouse' page
	Then  I verify the warehouse details
	When  I select the 'Show Details' drop down value as 'To Alias' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'List Of Location Alias(es) For VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Setting Warehouse MSL for: VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To Group MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Set Group MSL for VIC CW Activ8me'
	Given I enter 'Alias' as 'Activ8me'
	And   I click the 'Search' button to load details
	And   I fetch the warehouse details
	And   I click the 'Show Details' link
	When  I select the 'Show Details' drop down value as 'View Record' in 'Admin Warehouse' page
	Then  I verify the warehouse details
	When  I select the 'Show Details' drop down value as 'To Alias' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'List Of Location Alias(es) For VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Setting Warehouse MSL for: VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To Group MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Set Group MSL for VIC CW Activ8me'
	Given I click the 'Reset' button to load details
	And   I select the 'Bytecraft/External/VIC/Client Warehouses VIC' location in the Select a Warehouse Location tree
    And   I click the 'Show Warehouses Under' button
	And   I fetch the warehouse details
	And   I click the 'Show Details' link
	When  I select the 'Show Details' drop down value as 'View Record' in 'Admin Warehouse' page
	Then  I verify the warehouse details
	When  I select the 'Show Details' drop down value as 'To Alias' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'List Of Location Alias(es) For VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Setting Warehouse MSL for: VIC CW Activ8me'
	When  I select the 'Show Details' drop down value as 'To Group MSL' in 'Admin Warehouse' page
	Then  A new window is displayed  for 'Set Group MSL for VIC CW Activ8me'
	
#Examples: 
#| Role              |
#| Call Desk Manager |  
