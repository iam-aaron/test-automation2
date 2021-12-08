@AllTests @BSuite @BSuiteDesktop @Login
Feature: Health and Safety - Desktop PreStart Form - Agent Technicians are not presented with Daily PreStart Form when they attempt to login via Desktop
	As a BSuite Desktop User
	I can login to BSuite Desktop portal Health and Safety
	So that I can carry out my tasks
	 
@GSQA-161 @PositiveTests   
Scenario Outline: Desktop PreStart Form - Agent Technicians are not presented with Daily PreStart Form when they attempt to login via Desktop
	Given I have opened the BSuite Desktop Portal
	And I login as a User with User Profile as follows
		| Role   | Username   | Password   |
		| <Role> | <Username> | <Password> |
	When login is successful
	Then The Agent Technician is NOT presented with the Daily PreStart Form

	Examples:
		| Role             | Username         | Password |
		| Agent Technician | TestAgentTech150 | bsuite   |
