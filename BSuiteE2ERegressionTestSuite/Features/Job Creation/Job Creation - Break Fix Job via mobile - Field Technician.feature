@AllTests @BSuite @BSuite-Mobile @Field-Technician @Job-Creation
Feature: Job Creation - Break Fix Job via mobile - Field Technician
As a BSuite Mobile User with Role Field Technician
	I am able to add a new Task/Job of Work Type Break-Fix for all Active Contracts in BSuite
So that Customer issue can be taken up for resolution

@GSQA-5 @PositiveTests @ignore
Scenario Outline: Job Creation - Break Fix Job via mobile - Field Technician
	#Given I have opened the BSuite Mobile Portal
	#When I login as a User with User Profile as follows
	#	| Role             | Username               | Password |
	#	| Field Technician | testfieldtechnician107 | bsuite   |
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	Then login is successful
	And I have clicked 'Create Task' link
	When I enter the following details in the 'Create Fieldtask' page
		| Field               | Value/Action       |
		| Worktype            | <Worktype>         |
		| Site                | <Site>             |
		| Serial No           | 05                 |
		| Part                | <Part>             |
		| Position            | <Position>         |
		| Priority            | <Priority>         |
		| Problem Category    | <Problem Category> |
		| Problem Code        | <Problem Code>     |
		| Problem Description | GSQA 5             |
	And I have clicked 'Create Task' button on Mobile Portal
	And I fetch the successfully created Task Number
	And I have clicked '« Back' link
	And I have clicked 'Task #' link
	And I am required to select the created task using the task number
	Then I verify that the Task details of '<Worktype>','<Site>'

	Examples:
		| Worktype                                                 | Site   | Part    | Position | Priority | Problem Category | Problem Code |
		| ALH Group - IT Support - Break Fix                       | 688    | 1000041 | 1        | 1        | Unknown          | Unknown      |


		