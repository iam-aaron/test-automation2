@Health&Safety @Pre-Start-Form
Feature: Health and Safety - Daily PreStart Form - Field Technician No Scenario and Supervisors View

User Journey (Field Technician):
As a Tabcorp Technician Employee working for MAX Technical Services and using BSuite in my day to day activities,
I want to report the issue that I have (where I have answered No in Daily prestart form) to my supervisor to provide support to enable me to complete my Daily Pre Start Survey 
So that I can safely continue my work
and I can evidence compliance with the Health & Safety policies of Tabcorp while ensuring my supervisors are supporting me.

User Journey (Supervisor):
As a Supervisor with Field Technicians using BSuite in their day to day activities
I want to  record any responses where No is answered and reactivate the checklist or close it.
So that I ensure they can complete the daily Pre Start check list accurately and quickly and proceed to their daily activities.
and I can evidence compliance with the Health & Safety policies of Tabcorp while ensuring I am supporting my team.

Acceptance Criteria:

Given a Field Technician answers 'No' to a question
And the Field Technician has telephoned the Supervisor and discussed the issue
When the Field Technician has responded "No" to a question that requires my response before progressing
Then I can mitigate the issue
And confirm that the Field Technician can safely proceed with work in the appropriate role for that day
And the Supervisor is able to record responses on the check list and reactivate it
And the next question is enabled for the Field Technician 
And Field Technician is allowed to proceed with the survey

The Field Technician has replied No to a critical question on the pre start checklist. The check list has suspended and the Field Technician cannot complete the checklist and move to On Call until their Customer Operations Manager has agreed a response, recorded and reactivate the checklist.

Responds to questions where the Field Technician answers no and the Pre Start checklist in BSuite suspends as a result of that answer.
The supervisor will enter a response and reactivate the Pre Start checklist
Once the Checklist is reactivated the Field Technician can then proceed to the next question.
Relates to Question 1,2 and 5 of the Field Technicians mobile Pre Start check list only.
Where the response is No at Q5 the supervisor may manually update the Field Technician to On Call to enable them to complete other activities ( i.e. not field tasks).

@BSuite @BSuite-Mobile @BSuite-Website 
@Field-Technician @Supervisor @GSQA-167
Scenario: Health and Safety - Daily PreStart Form - Field Technician No Scenario and Supervisors View
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	And I am required to complete the Pre Start Checklist for the day in mobile portal
	#Response to prestart checklist question number 1
	And the 'first' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                                                |
		| 1               | My vehicle is roadworthy – e.g. windscreen and mirrors free of damage, all lights operational and tyres inflated with sufficient tread. |  
	When I respond 'No' to the 'first' Pre Start Checklist question in mobile portal
	Then 'first' prompt message is displayed to contact Supervisor as follows in mobile portal
	   | Prompt Message |
	   | STOP           | 
	And I log off from Bsuite 'Mobile' portal	
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Service Delivery Manager'  
	When I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	Then I click PreStart link for the 'first' No response and reactivate it for 'Field Technician'
	And I log off from Bsuite 'Desktop' portal
	#Response to prestart checklist question number 2
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	And the 'second' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                                                |
		| 2               | Are all licenses that you require for your duties / role currently valid? E.G. drivers licence, gaming licence? |  
	When I respond 'No' to the 'second' Pre Start Checklist question in mobile portal
	Then 'second' prompt message is displayed to contact Supervisor as follows in mobile portal
	    | Prompt Message |
	    | STOP           |  
	And I log off from Bsuite 'Mobile' portal
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Service Delivery Manager'
	When I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	Then I click PreStart link for the 'second' No response and reactivate it for 'Field Technician'
	And I log off from Bsuite 'Desktop' portal
	#Response to prestart checklist question number 3
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	And the 'third' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                |
		| 3               | Are your tools and equipment in good condition and do you have sufficient / enough PPE? |
	When I respond 'Yes' to the 'third' Pre Start Checklist question in mobile portal
	#Response to prestart checklist question number 4
	Then the 'fourth' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                                                                                                                                            |
		| 4               | Have you completed all mandatory training relevant to your Field Technicians Role – (e.g. Electrical safety / lifting / ladders etc.) OR are you familiar with all of the SWP (Safe Work Practice) documents relevant to your role? |  
    When I respond 'Yes' to the 'fourth' Pre Start Checklist question in mobile portal
	#Response to prestart checklist quetion number 5
	Then the 'fifth' question of the Pre Start Checklist is displayed as follows in mobile portal
		| Question Number | Question                                                                                                 |
		| 5               | I am fit for work and can perform my work without compromising the safety or health of myself or others. |
	When I respond 'No' to the 'fifth' Pre Start Checklist question in mobile portal	
	Then 'fifth' prompt message is displayed to contact Supervisor as follows in mobile portal
	    | Prompt Message |
	    | STOP           |  
	And I log off from Bsuite 'Mobile' portal
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Service Delivery Manager'
	When I have navigated to 'Tasks by Watch List' page from 'Call Centre' top menu
	Then I click PreStart link for the 'fifth' No response and reactivate it for 'Field Technician'
	And I log off from Bsuite 'Desktop' portal
	#To submit the prestart checklist
	Given I have logged into BSuite 'Mobile' portal as a User with role 'Field Technician'
	When I check the Confirm Customer Operations Manager contacted check box for 'fifth' no response
	Then I click the 'Submit' button

