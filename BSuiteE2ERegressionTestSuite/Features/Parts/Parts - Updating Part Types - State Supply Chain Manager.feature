@AllTests @BSuite @BSuite-Website @State-Supply-Chain-Manager
Feature: Parts - Updating Part Types - State Supply Chain Manager
	As a User with role "State Supply Chain Manager",I am able to update/edit an existing part type record in BSuite

@GSQA-86 
Scenario: Parts - Updating Part Types - State Supply Chain Manager
	Given I have logged into BSuite 'Desktop' portal as a User with role 'State Supply Chain Manager'
	And   I have navigated to 'Admin Part Types' page from 'Administration' in 'Logistics' top menu
	When I click the 'Search Part Types' button
	Then 'List of Parts' is displayed
	Given I select a 'Part Code and Name' and click the icon for Edit Record
	And I click the 'Add More' link
	And I select 'Other' from 'Type' drop down list
	And I enter 'Alias' text as 'RegressionTest'
	And I click the Save button to save the changes
	And I have navigated to 'Admin Part Types' page from 'Administration' in 'Logistics' top menu
	And I enter part code and name used for Edit Record
	And I select the Alias drop down value as 'Other' and enter the Alias text as 'RegressionTest'
	When I click the 'Search Part Types' button
	Then I click on the 'To Alias icon'
	And I verify the changes newly added


