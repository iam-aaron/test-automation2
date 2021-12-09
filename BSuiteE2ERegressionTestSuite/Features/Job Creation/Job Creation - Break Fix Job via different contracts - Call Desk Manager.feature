@AllTests @BSuite @BSuiteDesktop @Call-Desk-Manager @Job-Creation
Feature: Job Creation - Break Fix Job via different contracts - Call Desk Manager
	As a BSuite Desktop User with Role Call Desk Manager
	I can Add a New Task
	So that I may carry out my Call Desk Manager tasks

@GSQA-4 @PositiveTests 
Scenario Outline: Job Creation - Break Fix Job via different contracts - Call Desk Manager
	#Given I have logged into 'BSuite Desktop' portal as a User with following User Profile
	#	| Role              | Username         | Password |
	#	| Call Desk Manager | TestCallDeskMgr2 | bsuite   |
	Given I have logged into BSuite 'Desktop' portal as a User with role 'Call Desk Manager'
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
		| Serial Number     | GSQA04              |
		| Position          | <Position>          |
		| Part              | <Part>              |
		| Part Status       | <Part Status>       |
		#| Task Status       | <Task Status>       |
		| Priority          | <Priority>         |
		| Client Ref #      | GSQA04             |
		| Problem Category  | <Problem Category> |
		| Problem Code      | <Problem Code>     |
		| Problem Desc      | GSQA 4 Reg Test    |
		| Client Notes      | GSQA 4 Reg Test    |
		| Call Centre Notes | GSQA 4 Reg Test    |
	And I click the 'Save' button
	Then a new Field Task is saved with the following Client Targets
		| Target        | End Time                 |
		| Creation Time | Current Time             |
		| TAKEN         | Current Time + 0.5 hours |
		| ONSITE        | Current Time + 2 hours   |
		| CLOSED        | Current Time + 14 hours  |
	Then I click the 'Finish' button

	Examples:
		| Contract                                                 | Site     | App. Start Time | App. Start Hour | App. Start Minute | App. End Time | App. End Hour | App. End Minute | Position | Part    | Part Status | Priority | Problem Category        | Problem Code             |
		| ALH Group - IT Support - Break Fix                       | 688      | 2021-11-17      | 02              | 00                | 2021-11-17    | 02            | 30              | 1        | 1000041 | Degraded    | 1        | Unknown                 | Unknown                  |
		#| eBET - Break Fix                                         | VG377    | 2021-11-21      | 06              | 00                | 2021-11-21    | 06            | 30              | 5        | 1000041 | Degraded    | P1       | Unknown                 | Unknown                  |
		#| eCash - Break Fix (eCash)                                | 2503     | 2021-11-22      | 07              | 00                | 2021-11-22    | 07            | 30              | 6        | 1000041 | Degraded    | 2        | ATM                     | UNKNOWN                  |
		#| IGS - Deployments                                        | VG8825   | 2021-11-23      | 08              | 00                | 2021-11-23    | 08            | 30              | 7        | 1000041 | Degraded    | P1       | Unknown                 | Unknown                  |
		#| Maxgaming DMS - IMAC                                     | 110340   | 2021-11-26      | 11              | 00                | 2021-11-26    | 11            | 30              | 10       | 1000041 | Degraded    | 12       | VENUE                   | NEW                      |
		#| Maxgaming DMS Callout - Break Fix SDE                    | 110340   | 2021-11-27      | 12              | 00                | 2021-11-27    | 12            | 30              | 1        | 1000041 | Degraded    | 1        | VENUE                   | UNKNOWN                  |
		#| Maxgaming DMS M-WO - Break Fix                           | 108559   | 2021-11-29      | 14              | 00                | 2021-11-29    | 14            | 30              | 3        | 1000041 | Degraded    | 2        | Workorder               | Misc                     |		
		#| NSW Lotteries - Break Fix                                | T0301802 | 2021-12-08      | 23              | 00                | 2021-12-08    | 23            | 30              | 2        | 1000041 | Degraded    | 1        | New Venue               | Complete Kit Install     |
		#| NT Lotteries - Break Fix                                 | 2002207  | 2021-12-09      | 02              | 00                | 2021-12-09    | 02            | 30              | 3        | 1000041 | Degraded    | 1        | New Venue               | Complete Kit Install     |
		#| Prep Line - IMAC                                         | VG389    | 2021-12-13      | 06              | 00                | 2021-12-13    | 06            | 30              | 7        | 1320081 | Degraded    | COB Mon  | Staging                 | Set Up                   |
		#| QLD Pokies - Break Fix                                   | 688      | 2021-12-15      | 08              | 00                | 2021-12-15    | 08            | 30              | 9        | 1000041 | Degraded    | 1        | Unknown                 | Unknown                  |
		#| SA Lotteries - Break Fix                                 | 2002237  | 2021-12-17      | 10              | 00                | 2021-12-17    | 10            | 30              | 1        | 1000041 | Degraded    | 1        | New Venue               | Complete Kit Install     |
		#| SA Player Loyalty - Break Fix                            | 50100525 | 2021-12-18      | 11              | 00                | 2021-12-18    | 11            | 30              | 2        | 1000041 | Degraded    | 2        | Unknown                 | Unknown                  |
		#| SA Pokies - Break Fix                                    | 50100525 | 2021-12-19      | 12              | 00                | 2021-12-19    | 12            | 30              | 3        | 1000041 | Degraded    | 1        | Unknown                 | Unknown                  |
		#| TasTote Wagering - Break Fix                             | 3580     | 2021-12-24      | 17              | 00                | 2021-12-24    | 17            | 30              | 8        | 1000041 | Degraded    | 1        | Orion                   | Fault WAG                |
		#| Unitab Wagering - Break Fix                              | 158      | 2021-12-27      | 20              | 00                | 2021-12-27    | 20            | 30              | 1        | 1000041 | Degraded    | 1        | Orion                   | Fault WAG                |
		#| VIC Gaming - ALH Gaming - Break Fix                      | VG389    | 2021-12-28      | 21              | 00                | 2021-12-28    | 21            | 30              | 2        | 1000041 | Degraded    | P1       | EGM:                    | ALARMING                 |
		#| VIC Gaming - Austral Hotel - Break Fix                   | VG374    | 2021-12-31      | 02              | 00                | 2021-12-31    | 02            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Benalla Bowls Club - Break Fix              | VG252    | 2022-01-02      | 04              | 00                | 2022-01-02    | 04            | 30              | 7        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Black Rhino - Break Fix                     | VG8804   | 2022-01-03      | 05              | 00                | 2022-01-03    | 05            | 30              | 8        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Box Hill RSL - Break Fix                    | VG661    | 2022-01-05      | 07              | 00                | 2022-01-05    | 07            | 30              | 10       | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Cardinia Park Hotel - Break Fix             | VG9864   | 2022-01-07      | 09              | 00                | 2022-01-07    | 09            | 30              | 2        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Cardinia/Pakenham Club - Break Fix          | VG413    | 2022-01-08      | 10              | 00                | 2022-01-08    | 10            | 30              | 3        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Clayton Bowls Club - Break Fix              | VG373    | 2022-01-09      | 11              | 00                | 2022-01-09    | 11            | 30              | 4        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Club Hotel Warragul - Break Fix             | VG9842   | 2022-01-10      | 12              | 00                | 2022-01-10    | 12            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Club Kilsyth/Ringwood - Break Fix           | VG921    | 2022-01-11      | 13              | 00                | 2022-01-11    | 13            | 30              | 6        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Dick Whittington Tavern - Break Fix         | VG6062   | 2022-01-13      | 15              | 00                | 2022-01-13    | 15            | 30              | 8        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Drums Hotel - Break Fix                     | VG504    | 2022-01-15      | 17              | 00                | 2022-01-15    | 17            | 30              | 10       | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Essendon/Melton Club - Break Fix            | VG8462   | 2022-01-18      | 20              | 00                | 2022-01-18    | 20            | 30              | 3        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Invy Espy Hotel - Break Fix                 | VG9841   | 2022-01-20      | 22              | 00                | 2022-01-20    | 22            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Keilor Hotel - Break Fix                    | VG202    | 2022-01-22      | 02              | 00                | 2022-01-22    | 02            | 30              | 7        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Kellys Motor Club Hotel - Break Fix         | VG111    | 2022-01-23      | 03              | 00                | 2022-01-23    | 03            | 30              | 8        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Kooringal Golf Club - Break Fix             | VG136    | 2022-01-26      | 06              | 00                | 2022-01-26    | 06            | 30              | 1        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Korumburra Hotel - Break Fix                | VG8782   | 2022-01-27      | 07              | 00                | 2022-01-27    | 07            | 30              | 2        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Lorne Hotel - Break Fix                     | VG8722   | 2022-01-30      | 10              | 00                | 2022-01-30    | 10            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Momentum Gaming - Break Fix                 | VG9568   | 2022-02-06      | 17              | 00                | 2022-02-06    | 17            | 30              | 2        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Moonee Valley Legends - Break Fix           | VG47     | 2022-02-07      | 18              | 00                | 2022-02-07    | 18            | 30              | 3        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Morwell Club Inc - Break Fix                | VG5682   | 2022-02-08      | 19              | 00                | 2022-02-08    | 19            | 30              | 4        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Myrtleford Savoy Sporting Club - Break Fix  | VG229    | 2022-02-09      | 20              | 00                | 2022-02-09    | 20            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Noble Park Football Social Club - Break Fix | VG56     | 2022-02-10      | 21              | 00                | 2022-02-10    | 21            | 30              | 6        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - North Ballarat Sports Club - Break Fix      | VG49     | 2022-02-11      | 22              | 00                | 2022-02-11    | 22            | 30              | 7        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - PM - PM                                     | VG389    | 2022-02-14      | 03              | 00                | 2022-02-14    | 03            | 30              | 10       | 1000041 | Degraded    | 10 Weeks | EGM                     | Alarm                    |
		#| VIC Gaming - Premier Hotels - Break Fix                  | VG43     | 2022-02-15      | 04              | 00                | 2022-02-15    | 04            | 30              | 1        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Pubco - Break Fix                           | VG8222   | 2022-02-17      | 06              | 00                | 2022-02-17    | 06            | 30              | 3        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Rising Sun Hotel - Break Fix                | VG90     | 2022-02-19      | 08              | 00                | 2022-02-19    | 08            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Rubicon Hotel Motel - Break Fix             | VG9628   | 2022-02-22      | 11              | 00                | 2022-02-22    | 11            | 30              | 8        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Seagulls Nest - Williamstown FC - Break Fix | VG533    | 2022-02-23      | 12              | 00                | 2022-02-23    | 12            | 30              | 9        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - SGS Gaming - Break Fix                      | VG25     | 2022-02-24      | 13              | 00                | 2022-02-24    | 13            | 30              | 10       | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Sphinx Hotel - Break Fix                    | VG237    | 2022-02-25      | 14              | 00                | 2022-02-25    | 14            | 30              | 1        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Sunshine City Club - Break Fix              | VG276    | 2022-02-26      | 15              | 00                | 2022-02-26    | 15            | 30              | 2        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Tabet Gaming - Break Fix                    | VG8642   | 2022-02-27      | 16              | 00                | 2022-02-27    | 16            | 30              | 3        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Union Club Hotel - Break Fix                | VG3941   | 2022-03-01      | 18              | 00                | 2022-03-01    | 18            | 30              | 5        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Veneto Club - Break Fix                     | VG40     | 2022-03-02      | 19              | 00                | 2022-03-02    | 19            | 30              | 6        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Wood Group - Break Fix                      | VG8022   | 2022-03-06      | 23              | 00                | 2022-03-06    | 23            | 30              | 10       | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Gaming - Yarram Country Club - Break Fix             | VG5663   | 2022-03-08      | 10              | 00                | 2022-03-08    | 10            | 30              | 2        | 1000041 | Degraded    | P1       | EGM                     | Alarm                    |
		#| VIC Lotteries - Break Fix                                | T0100103 | 2022-03-11      | 13              | 00                | 2022-03-11    | 13            | 30              | 5        | 1000041 | Degraded    | 1        | Audio                   | Audio Fault Cust Display |
		#| Wagering - Break Fix                                     | 3622     | 2022-03-12      | 14              | 00                | 2022-03-12    | 14            | 30              | 6        | 1000041 | Degraded    | 2        | Keno and Wagering Venue | OLGR                     |
