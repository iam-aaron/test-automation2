@AllTests @BSuite @HealthAndSafety @Reporting 
Feature: Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path - via Mobile
	As a BSuite Mobile User
	I can login to BSuite Mobile portal
	So that I can carry out my tasks

@GSQA-163 @ignore
Scenario: Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path - via Mobile
	Given I have opened the BSuite Mobile Portal
	And I login as a User with User Profile as follows
		| Role   | Username   | Password   |
		| <Role> | <Username> | <Password> |
	When login is successful
	