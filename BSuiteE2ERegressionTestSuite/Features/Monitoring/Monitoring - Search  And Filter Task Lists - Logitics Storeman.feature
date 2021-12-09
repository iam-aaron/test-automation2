@AllTests @BSuite @BSuite-Website @Monitoring @Logistics-Storeman
Feature: Monitoring - Search And Filter Task Lists - Logistics Storeman
As a User with role Logistics Storeman accessing BSuite desktop portal,
I am able to search the tasks with field values such as Task#, Client Ref#, and Serial#.

@GSQA-74 
Scenario: Monitoring - Search And Filter Task Lists - Logistics Storeman
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Call Desk Manager'
	And I have navigated to 'Call Centre' page from the top menu
	And I have navigated to 'Add Task' page and entered details as follows
		| Field             | Value                              |
		| Contract/WorkType | ALH Group - IT Support - Break Fix |  
	When I click the 'Add Task' button
	Then I enter the following details in the 'Add Task - FieldTask' page
		| Field             | Value/Action |
		| Site              | 688          |
		| Contact           | Sam1234      |
		| App. Start Time   | 2021-11-02   |
		| App. Start Hour   | 00           |
		| App. Start Minute | 55           |
		| App. End Time     | 2021-11-18   |
		| App. End Hour     | 00           |
		| App. End Minute   | 00           |
		| Serial Number     | 1            |
		| Position          | 1            |
		| Part              | 1000041      |
		| Part Status       | Usable       |
		| Priority          | 1            |
		| Client Ref #      | 1            |  
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-74      |
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button
	Then I log off from Bsuite 'Desktop' portal
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Logistics Storeman'
	When I have navigated to 'Task Status' page from 'Tasks' in 'Logistics' top menu
	Then I search the task number in 'Task Status'
	When I have navigated to 'Task Status' page from 'Tasks' in 'Logistics' top menu
	Then I search the ClientRef number in 'Task Status'
	When I have navigated to 'Task Status' page from 'Tasks' in 'Logistics' top menu
	Then I select the 'No. of Tasks' drop down value as '200' in 'Task Status' page
	And I click 'Search Field Tasks' button
	And I verify the total no of task is displayed as '200'
	
	
	

	
	
	




			 
	

