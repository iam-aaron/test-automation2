@AllTests @Bsuite @BSuite-Website @Call-Desk-Manager @JobAssignment 
Feature: Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager
As a User with role "Call Desk Manager" accessing BSuite desktop portal,
I am able to Assign Task to a Field Technician on BSuite desktop portal,
So that the task will then be available for the Field Technician to view by clicking Mine in the Tasks section at the top of the main screen on the BSuite mobile portal.
	

@GSQA-25 
Scenario: Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager
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
		| Problem Desc      | GSQA-25      |		
	When I click the 'Save' button
	Then I fetch the task number
	And I click the 'Finish' button
	#And I fetch the 'Field Technician' full name
	Given I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	And I click the 'Edit Preferences' button
	#And I add 'Field Technician' from 'All Technicians' to 'Technicians currently on watch list' in 'Edit Watch List Preference' page
	And I add the technician 'TestFieldTech27' from 'All Technicians' to 'Technicians currently on watch list' in 'Edit Watch List Preference' page
	And I add state as 'QLD' and worktype as 'ALH Group - IT Support Break Fix' to watch list
	And I click the 'Save and Update' button
	And I click the 'Unassigned' link
	And I select the task number fetched for the state 'QLD' and the worktype 'ALH Group - IT Support Break Fix'
	And I select 'TAKEN' from the 'Task Status' drop down box for 'Field Technician' 
	And I log off from Bsuite 'Desktop' portal
	#When I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	When I have opened the BSuite Mobile Portal
	And I login as a User with User Profile as follows
		| Role             | Username        | Password |
		| Field Technician | TestFieldTech27 | bsuite   |  
	#Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	Then I click the 'Mine' link
	And I click the 'Task #' link
	And I verify the task in My Tasks page on mobile portal


	



	

