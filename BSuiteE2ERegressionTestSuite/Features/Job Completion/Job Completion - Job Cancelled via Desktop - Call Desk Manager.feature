@AllTests @Bsuite @BSuite-Website @Job-Completion @Call-Desk-Manager
Feature: Job Completion - Job Cancelled via Desktop - Call Desk Manager
As a User with role "Call Desk Manager" accessing BSuite desktop portal,
I am able to Cancel a Task

Description
@GSQA-53
Scenario: Job Completion - Job Cancelled via Desktop - Call Desk Manager
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
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-53      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button	
	#NEW
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I search the task number in 'Task Status Screen'
	And I select 'CANCEL' from the 'Task Status' drop down box
	#SENT
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I click 'Search Field Tasks' button
	When I select the task number with status as 'SENT'
	Then I select 'CANCEL' from the 'Task Status' drop down box
	#TAKEN
	Given I have navigated to 'Call Centre' page from the top menu
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
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-53      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button	
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I search the task number in 'Task Status Screen'
	And I select 'TAKEN' from the 'Task Status' drop down box
	And I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	When I search the task number in 'Task Status Screen'	
	Then I select 'CANCEL' from the 'Task Status' drop down box
	#QUEUED
	Given I have navigated to 'Call Centre' page from the top menu
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
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-53      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button	
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I search the task number in 'Task Status Screen'
	And I select 'QUEUED' from the 'Task Status' drop down box
	And I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	When I search the task number in 'Task Status Screen'	
	Then I select 'CANCEL' from the 'Task Status' drop down box	
	#RELEASED
	Given I have navigated to 'Call Centre' page from the top menu
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
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-53      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button	
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I search the task number in 'Task Status Screen'
	And I select 'TAKEN' from the 'Task Status' drop down box
	And I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	When I search the task number in 'Task Status Screen'	
	Then I select 'RELEASED' from the 'Task Status' drop down box
	When I search the task number in 'Task Status Screen'
	Then I select 'CANCEL' from the 'Task Status' drop down box	
	#ONSITE
	Given I have navigated to 'Call Centre' page from the top menu
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
		| Problem Category  | Unknown      |
		| Problem Code      | Unknown      |
		| Problem Desc      | GSQA-53      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button	
	Given I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	And I search the task number in 'Task Status Screen'
	And I select 'TAKEN' from the 'Task Status' drop down box
	And I have navigated to 'Task Status Screen' page from 'Call Centre' top menu
	When I search the task number in 'Task Status Screen'	
	Then I select 'ONSITE' from the 'Task Status' drop down box
	When I search the task number in 'Task Status Screen'
	Then I select 'CANCEL' from the 'Task Status' drop down box	
	
	
