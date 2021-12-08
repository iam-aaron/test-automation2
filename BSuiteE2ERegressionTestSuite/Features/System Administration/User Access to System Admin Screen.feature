@AllTests @BSuite @BSuiteDesktop @SystemAdministration
Feature: User Access to System Admin Screen
	As a BSuite Desktop User with System Admin Role
	I can access the Admin screen
	So that I may carry out my System Administration tasks

@BSUITE-10092 @PositiveTests @NegativeTests @ignore
Scenario Outline: Only Users with System Admin role shall be allowed access to Admin menu screen
	Given I have opened the BSuite Desktop Portal
	When I login as a User with role '<Role>'
	Then I can navigate to 'Admin' page from the top menu

Examples: 
	| Role         | 
	| System Admin | 


@BSUITE-10092 @PositiveTests @NegativeTests @ignore
Scenario Outline: Users without System Admin role shall not be allowed access to Admin menu screen
	Given I have opened the BSuite Desktop Portal
	When I login as a User with role '<Role>'
	Then I cannot navigate to 'Admin' page from the top menu

Examples: 
	| Role                                     |
	| After Hours Supervisor                   |
	| Agent Logistics (Stock Take)             |
	| Agent Manager                            |
	| Agent Manager (Logistics)                |
	| Agent Technician                         |
	| Agent View                               |
	| BSuite Documentation                     |
	| Call Desk + Logistics RO                 |
	| Call Desk Contractor                     |
	| Call Desk Manager                        |
	| Call Desk Manager (Service Plan Admin)   |
	| Call Desk OCC                            |
	| Call Desk Supervisor                     |
	| Call Desk Technician                     |
	| Client Admin                             |
	| Client Technician                        |
	| Contact Centre Operator                  |
	| Dashboard View                           |
	| Field Supervisor                         |
	| Field Supervisor (Stocktake)             |
	| Field Tech + Logistics                   |
	| Field Tech + Workshop + Logistics        |
	| Field Technician                         |
	| Finance                                  |
	| Finance Admin                            |
	| Human Resources                          |
	| Kamco Client                             |
	#| Logistics + Call Desk Technician         |
	| Logistics + Reports                      |
	#| Logistics Admin                          |
	#| Logistics Admin (Limited Call Desk)      |
	#| Logistics Admin (Limited Call Desk) + PO |
	#| Logistics Storeman                       |
	#| Logistics Storeman (Casual)              |
	#| Logistics Storeman (Limited CallDesk)    |
	#| Logistics Supervisor                     |
	#| Logistics Technician                     |
	| National Inventory                       |
	| National Workshop Manager                |
	| Part Type Creation                       |
	| Projects                                 |
	| Projects - SME                           |
	| Purchasing                               |
	| Service Delivery Manager                 |
	| Staging                                  |
	| State Inventory                          |
	| State Supply Chain Manager               |
	| Stock Take                               |
	| Stocktake Reports                        |
	| Trainer                                  |
	| VG Agent Logistics                       |
	#| Workshop + Logistics                     |
	| Workshop Admin                           |
	#| Workshop Admin (NEW)                     |
	#| Workshop Supervisor                      |
	| Workshop Technician                      |
	#| Workshop Technician (NEW)                |
	| Worm                                     |
