@AllTests @BSuite @Bsuite-Mobile @Job-Completion @Field-Technician
Feature: Job Completion - Break Fix Consumable Used via Mobile - Field Technician
	As a User with role Field Technician accessing BSuite Mobile portal,
I am able to complete a job by using a consumable part and valid data on all the required and additional fields.

@GSQA-42 @PositiveTests 
Scenario Outline: Job Completion - Break Fix Consumable Used via Mobile - Field Technician
	#Given I have logged into 'BSuite Desktop' portal as a User with following User Profile
	#	| Role         | Username         | Password |
	#	| System Admin | TestSystemAdmin2 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'System Admin'	
	And I have navigated to 'Call Centre' page from the top menu
	And I have navigated to 'Add Task' page and entered details as follows
		| Field             | Value      |
		| Contract/WorkType | <Contract> |
	And I click the 'Add Task' button
	When I enter the following details in the 'Add Task - FieldTask' page
		| Field             | Value/Action        |
		| Site              | <Site>              |
		| Contact           | Sam1234             |
		| App. Start Time   | <App. Start Time>   |
		| App. Start Hour   | <App. Start Hour>   |
		| App. Start Minute | <App. Start Minute> |
		| App. End Time     | <App. End Time>     |
		| App. End Hour     | <App. End Hour>     |
		| App. End Minute   | <App. End Minute>   |
		| Serial Number     | GSQA170             |
		| Position          | <Position>          |
		| Part              | <Part>              |
		| Part Status       | <Part Status>       |
		| Task Status       | <Task Status>       |
		| Priority          | <Priority>          |
		| Client Ref #      | GSQA170             |
		| Problem Category  | <Problem Category>  |
		| Problem Code      | <Problem Code>      |
		| Problem Desc      | GSQA 170 Reg Test   |
		| Client Notes      | GSQA 170 Reg Test   |
		| Call Centre Notes | GSQA 170 Reg Test   |
	And I click the 'Save' button
	Then a new Field Task is saved with the following Client Targets
		| Target        | End Time                 |
		| Creation Time | Current Time             |
		| TAKEN         | Current Time + 0.5 hours |
		| ONSITE        | Current Time + 2 hours   |
		| CLOSED        | Current Time + 14 hours  |
	And I fetch the task number
	And I click the 'Finish' button
	Then I log off from Bsuite 'Desktop' portal  

 #   Given I have opened the BSuite Mobile Portal
	#When I login as a User with User Profile as follows
	#	| Role             | Username               | Password |
	#	| Field Technician | testfieldtechnician109 | bsuite   |
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'	
	Then I click the 'Task #' link
	Then I am required to select the created task using the task number
	Then I click the 'Take Task' link
	Then I click the 'Update' link
	And I am required to change the Status to 'ONSITE'
	And I have clicked 'Update' button on Mobile Portal
	And I have clicked 'Continue' button on Mobile Portal
	Then The 'first' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                    |
		| 1               | Is this a multi person job? |
	When I respond 'No' to the 'first' My Slam Assessment question
	Then The 'second' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                       |
		| 2               | I am clear on what the job is? |
	When I respond 'Yes' to the 'second' My Slam Assessment question
	Then The 'third' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                                                                                                                                                                                                                        |
		| 3               |  I have the required skills, training, and licences for the task? |
	When I respond 'Yes' to the 'third' My Slam Assessment question
	Then The 'fourth' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                                               |
		| 4               | I have reviewed the Safe Work Procedures for the task. |
	When I respond 'Yes' to the 'fourth' My Slam Assessment question
	Then The 'fifth' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                                                                        |
		| 5               | I have the correct tools and equipment and tools are correct and in good order. |
	When I respond 'Yes' to the 'fifth' My Slam Assessment question
	Then The 'seventh' Question Of The My Slam Assessment Is Displayed As Follows
		| Question Number | Question                      |
		| 7               | Look for Unidentified Hazards |
	When I respond 'No' to the 'seventh' My Slam Assessment question
	Then the Submit button is enabled for MySlamAssessment
	And I click the 'Submit' button
	And I select the 'Add Action' drop down value as 'REPLACED' in 'Work Log for Field Task' page on Mobile portal
	And I have clicked 'Next »' button on Mobile Portal
	And I have entered Part Number '1000041' under 'Part In - Part No' and clicked on 'Part In - Search' 
	And I select the Part Number '1000041' in Search Part page
	And I have entered Part Number '1000041' under 'Part Out - Part No' and clicked on 'Part Out - Search' 
	And I select the Part Number '1000041' in Search Part page
	And I enter Part Fault Description 'Part Fault Description for Workshop'
	And I have clicked 'AddAction' button on Mobile Portal
	And I have clicked 'Close Work Log' button on Mobile Portal
	And I select the 'Cause Category' drop down value as 'CC625-ALH Cisco Bank Switch' in 'Please Select Cause Category' page on Mobile portal
	And I select the 'Cause Category Details' drop down value as 'Unknown' in 'Please Select Cause Category' page on Mobile portal
	And I have clicked 'Save' button on Mobile Portal
	And I click Close Work Log button and Cancel on 'Do You Want to Change Cause Category?' pop up 
	And I have clicked 'Update' button on Mobile Portal
	And I click the 'Update' link
	And I am required to change the Status to 'CLOSED'
	And I have clicked 'Update' button on Mobile Portal
	And I click the '« Back to Task List' link
	And I click the 'Past Actioned' link
	And Status of task updated as 'COM'
	



	Examples:
		| Contract                           | Site | App. Start Time | App. Start Hour | App. Start Minute | App. End Time | App. End Hour | App. End Minute | Position | Part    | Part Status | Priority | Problem Category | Problem Code |
		| ALH Group - IT Support - Break Fix | 688  | 2021-11-17      | 02              | 00                | 2021-11-17    | 02            | 30              | 1        | 1000041 | Degraded    | 1        | Unknown          | Unknown      |
	
