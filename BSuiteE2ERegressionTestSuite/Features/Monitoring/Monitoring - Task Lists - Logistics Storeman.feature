@AllTests @BSuite @BSuite-Website @Monitoring @Logistics-Storeman
Feature: Monitoring - Task Lists - Logistics Storeman
As a User with role Logistics Storeman accessing BSuite desktop portal,
I am able to monitor tasks and agent/technician activities.

@GSQA-70 
Scenario: Monitoring - Task Lists - Logistics Storeman
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Logistics Storeman'	
	And I have navigated to 'Task Status' page from 'Tasks' in 'Logistics' top menu
	And I click 'Search Field Tasks' button
	And I verify that a list of all active tasks is displayed
	And I search the task number in 'Task Status'
	And I select the checkbox 'Change Column Views'
	And I select the checkbox 'State' on Change Column Views
	And I deselect the checkbox 'APP_END' on Change Column Views
	And I click the 'save view' button
	And I verify that the column 'State' is 'viewed' as desired	
	And I deselect the checkbox 'State' on Change Column Views
	And I select the checkbox 'APP_END' on Change Column Views
	And I click the 'save view' button

	
	
	




			 
	

