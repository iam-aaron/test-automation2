@AllTests @BSuite @BSuiteDesktop @BulkLoad @Job-Creation @SystemAdmin
Feature: Job Creation - Project Bulk Load - System Admin

@GSQA-14 @PositiveTests
Scenario: Job Creation - Project Bulk Load - System Admin
    Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'	  
	And I have navigated to 'Admin' page from the top menu
	And I have clicked 'Import FieldTasks' link and entered details as follows
		| Field    | Value                         |
		| WorkType | IGS - Deployments             |
		| File     | IGS Deployment WC GSQA-14.csv |
	And I click the 'Upload' button
	#Do you wish to continue to upload the file
	When I click the 'Yes' button
	Then New Tasks should be created and verify the task numbers in 'Task Status Screen'
	
