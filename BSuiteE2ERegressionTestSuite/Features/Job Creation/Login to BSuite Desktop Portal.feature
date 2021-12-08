@AllTests @BSuite @BSuiteDesktop @Login
Feature: Login
As a BSuite Desktop User
	I can login to BSuite Desktop portal
	So that I can carry out my tasks


@GSQA-10090 @PositiveTests @NegativeTests @ignore
Scenario Outline: Login to BSuite Desktop Portal
	Given I have opened the BSuite Desktop Portal
	When I login as a User with User Profile as follows	
		| Role   | Username   | Password   |
		| <Role> | <Username> | <Password> |
	Then login is successful

Examples: 
	| Role         | Username | Password |
	| System Admin | akshatha | akshatha |
	| System Admin | sanjanam | sanjanam |

