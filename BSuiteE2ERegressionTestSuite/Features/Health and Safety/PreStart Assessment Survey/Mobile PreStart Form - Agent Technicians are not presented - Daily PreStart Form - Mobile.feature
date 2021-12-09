@AllTests @BSuite @Bsuite-Mobile @Health&Safety
Feature: Mobile PreStart Form - Agent Technicians are not presented with Daily PreStart Form when they attempt to login via Mobile
	As a BSuite Mobile User
	I can login to BSuite Mobile portal
	So that I can carry out my tasks

@GSQA-162 @PositiveTests 
Scenario: Mobile PreStart Form - Agent Technicians are not presented with Daily PreStart Form when they attempt to login via Mobile
	#Given I have opened the BSuite Mobile Portal
	#And I login as a User with User Profile as follows
	#	| Role   | Username   | Password   |
	#	| <Role> | <Username> | <Password> |
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Agent Technician'
	When login is successful 
	Then The Agent Technician is NOT presented with the Daily PreStart Form

		