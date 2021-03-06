@AllTests @Bsuite-Mobile @Agent-Technician @Job-Assignment
Feature: Job Assignment - Agent Tech Takes Job via Mobile - Agent Technician
	

@GSQA-31 
Scenario: Job Assignment - Agent Tech Takes Job via Mobile - Agent Technician
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'	  
	And I have navigated to 'Admin' page from the top menu
	And I have clicked 'Import FieldTasks' link and entered details as follows
		| Field    | Value                         |
		| WorkType | IGS - Deployments             |
		| File     | IGS Deployment WC GSQA-31.csv |
	And I click the 'Upload' button
	#Do you wish to continue to upload the file
	And I click the 'Yes' button
	Then New tasks should be created and I fetch the task numbers
	And I log off from Bsuite 'Desktop' portal
	When I have logged into BSuite 'Mobile' portal as a User with role 'Agent Technician'
	And I have clicked 'Task #' link 
	And I search for the task number and click on the task
	And I have clicked 'Take Task' link
	And I have clicked '« Back to Task List' link
	And I have clicked 'Mine' link
	And Status of the task is updated as TAKEN
	And I have clicked 'All' link 
	And I search for the multiple task numbers and click on the corresponding check box
	And I have clicked 'ETA box' button on Mobile Portal
	And I have clicked 'Take Task' button on Mobile Portal
	And I have clicked 'Mine' link
	Then Status of the tasks is updated as TAKEN



