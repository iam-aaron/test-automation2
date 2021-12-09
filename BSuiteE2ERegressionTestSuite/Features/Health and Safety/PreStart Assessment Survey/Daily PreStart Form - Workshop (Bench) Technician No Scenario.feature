@AllTests @BSuite @HealthAndSafety @PreStartAssessment @ignore
Feature: Health and Safety - Daily PreStart Form - Workshop (Bench) Technician "No" Scenario

@GSQA-168 @NegativeTests @BSuite @BSuite-Mobile @BSuite-Website @Health&Safety @Workshop-Technician @Pre-Start-Form
Scenario Outline: Health and Safety - Daily PreStart Form - Workshop (Bench) Technician "No" Scenario
Responds to questions where the Workshop Technician answers no and enters that he has contacted the People leader.
Once the Checklist is reactivated by the People Leader then Workshop Technician can then proceed to the next question. 
	Given I have opened the BSuite Desktop Portal
	And I login as a User for the first time in a day with user details as follows
	| Role   | Username   | Password   |
	| <Role> | <Username> | <Password> |
	Then I am required to complete the Pre Start Checklist for the day
	Then the 'first' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                                       |
		| 1               | Are all licenses that you require for your duties/role currently valid? E.G. drivers licence, gaming licence/forklift licence? |
	When I respond 'No' to the 'first' Pre Start Checklist question
	Then 'first' prompt message is displayed to contact Supervisor as follows
	    | Prompt Message                |
	    | STOP, further action required |  
	When data is enterered for the 'first' question in that prompt after he has contacted the Supervisor
	Then the 'second' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                              |
		| 2               | Are your tools and equipment in good condition and do you have sufficient/enough PPE? |
	When I respond 'No' to the 'second' Pre Start Checklist question
	Then 'second' prompt message is displayed to contact Supervisor as follows
	    | Prompt Message             |
	    | Contact your People Leader |  
	When data is enterered for the 'second' question in that prompt after he has contacted the Supervisor
	Then the 'third' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                                                                                                                                        |
		| 3               | Have you completed all mandatory training relevant to your Field Technicians Role - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of the SWP (Safe Work Practice) documents relevant to your role? |
	When I respond 'No' to the 'third' Pre Start Checklist question
	Then 'third' prompt message is displayed to contact Supervisor as follows
	    | Prompt Message             |
	    | Contact your People Leader |  
	When data is enterered for the 'third' question in that prompt after he has contacted the Supervisor
	Then the 'fourth' question of the Pre Start Checklist is displayed as follows
		| Question Number | Question                                                                                                 |
		| 4               | I am fit for work and can perform my work without compromising the safety or health of myself or others. |
	When I respond 'No' to the 'fourth' Pre Start Checklist question
	Then 'fourth' prompt message is displayed to contact Supervisor as follows
	    | Prompt Message |
	    | STOP           |  
	When data is enterered for the 'fourth' question in that prompt after he has contacted the Supervisor
	When I click the 'Submit' button

Examples: 
	| Role                      | Username           | Password |
	| Workshop Technician (New) | TestWrkshp168Tech3 | bsuite   |  




