@AllTests @BSuite @BSuiteDesktop @Login
Feature: Login
As a BSuite Desktop User
	I can login to BSuite Desktop portal
	So that I can carry out my tasks


@GSQA-10090 @PositiveTests @NegativeTests
Scenario: Login to BSuite Desktop Portal
	Given I have logged into 'BSuite Desktop' portal as a User with following User Profile
		| Role         | Username         | Password |
		| System Admin | TestSystemAdmin3 | bsuite   | 
	Then login is successful
