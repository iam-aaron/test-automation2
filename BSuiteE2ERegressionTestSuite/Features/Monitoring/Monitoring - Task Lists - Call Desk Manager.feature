@AllTests @BSuite @BSuite-Website @Monitoring @Call-Desk-Manager
Feature: Monitoring - Task Lists - Call Desk Manager
As a User with role Call Desk Manager accessing BSuite desktop portal,
I am able to monitor tasks and agent/technician activities.

@GSQA-68 
Scenario: Monitoring - Task Lists - Call Desk Manager
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Call Desk Manager'	
	And I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	And I click the 'Edit Preferences' button
	And I add the technician 'TestAgentTechnician1' from 'All Agents' to 'Agents currently on watch list' in 'Edit Watch List Preference' page
	And I add the technician 'TestAgentTechnician2' from 'All Agents' to 'Agents currently on watch list' in 'Edit Watch List Preference' page
	And I add the technician 'TestFieldTechnician3' from 'All Technicians' to 'Technicians currently on watch list' in 'Edit Watch List Preference' page
	And I add the technician 'TestFieldTechnician4' from 'All Technicians' to 'Technicians currently on watch list' in 'Edit Watch List Preference' page
	And I add state as 'ACT' and worktype as 'ALH Group - IT Support Break Fix' to watch list
	And I add state as 'QLD' and worktype as 'ALH Group - IT Support Break Fix' to watch list
	And I add state as 'ACT' and worktype as 'ALH Group - IT Support Break Fix' to watch list for pending tasks
	And I add state as 'QLD' and worktype as 'ALH Group - IT Support Break Fix' to watch list for pending tasks
	And I click the 'Save and Update' button
	When I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	Then I verify the 'Tasks by Watch List' page has the following tabs
			 | Tabs               |  
			 | Assigned to Techs  |
			 | Assigned to Agents |
			 | Unassigned         |
			 | Pending            |
	And I verify the 'Tasks by Watch List' page has the following buttons
			 | Buttons          |  
			 | Full Screen Mode |
			 | Edit Preferences |
			 | Show Legend      |	
	And I verify 'TestFieldTechnician3' is displayed under 'Technicians' on 'Assigned to Techs' tab
	And I verify 'TestFieldTechnician4' is displayed under 'Technicians' on 'Assigned to Techs' tab
	And I verify 'Pre Start' status on 'Assigned to Techs' tab
	And I verify 'ONSITE' status on 'Assigned to Techs' tab
	And I verify 'Assigned Tasks' status on 'Assigned to Techs' tab
	When I click the 'Assigned to Agents' link
	Then I verify 'TestAgentTechnician1' is displayed under 'Agents/Clients' on 'Assigned to Agents' tab
	And I verify 'TestAgentTechnician2' is displayed under 'Agents/Clients' on 'Assigned to Agents' tab
	And I verify 'Pre Start' status on 'Assigned to Agents' tab
	And I verify 'ONSITE' status on 'Assigned to Agents' tab
	And I verify 'Assigned Tasks' status on 'Assigned to Agents' tab
	When I click the 'Unassigned' link
	Then I verify the 'State' 'ACT' added to watch list under 'Unassigned'
	And I verify the 'WorkType' 'ALH Group - IT Support Break Fix' added to watch list under 'Unassigned'
	And I verify 'Unassigned Tasks' status on 'Unassigned' tab
	When I click the 'Pending' link
	Then I verify the 'State' 'ACT' added to watch list under 'Pending'
	And I verify the 'WorkType' 'ALH Group - IT Support Break Fix' added to watch list under 'Pending'
	And I verify 'Pending Tasks' status on 'Pending' tab
	Given I have navigated to 'Task Status Screen' page from the top menu
	When I click 'Search Field Tasks' button
	Then I verify that a list of all active tasks is displayed
	When I select the checkbox 'View Status Legend'
	Then I verify for color-coded technician statuses are displayed
	Given I select the checkbox 'View Status Legend'
	And I search the task number in 'Task Status Screen'
	And I select the checkbox 'Change Column Views'
	And I select the checkbox 'State' on Change Column Views
	And I deselect the checkbox 'APP_END' on Change Column Views
	When I click the 'save view' button
	Then I verify that the column 'State' is 'viewed' as desired	
	And I deselect the checkbox 'State' on Change Column Views
	And I select the checkbox 'APP_END' on Change Column Views
	And I click the 'save view' button

	
	
	




			 
	

