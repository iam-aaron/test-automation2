@AllTests @BSuite @BSuiteDesktop @JobLogging 
Feature: Call Center - Add Task
	As a BSuite Desktop User with Role Workshop Technician (New)
	I can Add a New Task
	So that I may carry out my System Administration tasks


@BSUITE-800 @PositiveTests @ignore
Scenario Outline: Call Centre - Add Task
	Given I have logged into BSuite 'Desktop' portal as a User with role '<Role>'
	And I have navigated to 'Call Centre' page from the top menu
	#And I have navigated to 'Add Task' page and entered details as follows
	#	| Field             | Value                  |
	#	| Contract/WorkType | QLD Pokies - Break Fix |
	#And I click the 'Add Task' button
	#When I enter the following details in the 'Add Task - FieldTask' page
	#	| Field             | Value/Action    |
	#	| Site              | 960             |
	#	| Contact           | Abhy            |
	#	| App. Start Time   | 2021-08-10      |
	#	| App. Start Hour   | 09              |
	#	| App. Start Minute | 00              |
	#	| App. End Time     | 2021-08-10      |
	#	| App. End Hour     | 17              |
	#	| App. End Minute   | 00              |
	#	| Serial Number     | BSUITE800       |
	#	| Position          | 1               |
	#	| Part              | 1000041         |
	#	| Part Status       | Degraded        |
	#	| Task Status       | Degraded        |
	#	| Priority          | 1               |
	#	| Client Ref #      | BSUITE800       |
	#	| Problem Category  | Unknown         |
	#	| Problem Code      | Unknown         |
	#	| Problem Desc      | Regression Test |
	#	| Client Notes      | Regression Test |
	#	| Call Centre Notes | Regression Test |
	#And I click the 'Save' button
	#Then a new Field Task is saved with the following Client Targets
	#	| Target        | End Time                 |
	#	| Creation Time | Current Time             |
	#	| TAKEN         | Current Time + 0.5 hours |
	#	| ONSITE        | Current Time + 2 hours   |
	#	| CLOSED        | Current Time + 14 hours  |
	#Then I click the 'Finish' button

Examples: 
	| Role         |
	| System Admin |
