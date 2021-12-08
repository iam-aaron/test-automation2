﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BSuiteE2ERegressionTestSuite.Features.SystemAdministration
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("User Access to System Admin Screen", new string[] {
            "AllTests",
            "BSuite",
            "BSuiteDesktop",
            "SystemAdministration"}, Description="\tAs a BSuite Desktop User with System Admin Role\r\n\tI can access the Admin screen\r" +
        "\n\tSo that I may carry out my System Administration tasks", SourceFile="Features\\System Administration\\User Access to System Admin Screen.feature", SourceLine=1)]
    public partial class UserAccessToSystemAdminScreenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuiteDesktop",
                "SystemAdministration"};
        
#line 1 "User Access to System Admin Screen.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/System Administration", "User Access to System Admin Screen", "\tAs a BSuite Desktop User with System Admin Role\r\n\tI can access the Admin screen\r" +
                    "\n\tSo that I may carry out my System Administration tasks", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "BSuiteDesktop",
                        "SystemAdministration"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void OnlyUsersWithSystemAdminRoleShallBeAllowedAccessToAdminMenuScreen(string role, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BSUITE-10092",
                    "PositiveTests",
                    "NegativeTests",
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only Users with System Admin role shall be allowed access to Admin menu screen", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("I have opened the BSuite Desktop Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("I login as a User with role \'{0}\'", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("I can navigate to \'Admin\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Only Users with System Admin role shall be allowed access to Admin menu screen, S" +
            "ystem Admin", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=14)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void OnlyUsersWithSystemAdminRoleShallBeAllowedAccessToAdminMenuScreen_SystemAdmin()
        {
#line 8
this.OnlyUsersWithSystemAdminRoleShallBeAllowedAccessToAdminMenuScreen("System Admin", ((string[])(null)));
#line hidden
        }
        
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen(string role, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BSUITE-10092",
                    "PositiveTests",
                    "NegativeTests",
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Users without System Admin role shall not be allowed access to Admin menu screen", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given("I have opened the BSuite Desktop Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.When(string.Format("I login as a User with role \'{0}\'", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("I cannot navigate to \'Admin\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " After Hours Supervisor", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AfterHoursSupervisor()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("After Hours Supervisor", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Agent Logistics (Stock Take)", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AgentLogisticsStockTake()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Agent Logistics (Stock Take)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Agent Manager", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AgentManager()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Agent Manager", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Agent Manager (Logistics)", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AgentManagerLogistics()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Agent Manager (Logistics)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Agent Technician", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AgentTechnician()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Agent Technician", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Agent View", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_AgentView()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Agent View", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " BSuite Documentation", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_BSuiteDocumentation()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("BSuite Documentation", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk + Logistics RO", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskLogisticsRO()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk + Logistics RO", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk Contractor", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskContractor()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk Contractor", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk Manager", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskManager()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk Manager", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk Manager (Service Plan Admin)", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskManagerServicePlanAdmin()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk Manager (Service Plan Admin)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk OCC", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskOCC()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk OCC", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk Supervisor", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskSupervisor()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk Supervisor", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Call Desk Technician", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_CallDeskTechnician()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Call Desk Technician", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Client Admin", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_ClientAdmin()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Client Admin", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Client Technician", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_ClientTechnician()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Client Technician", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Contact Centre Operator", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_ContactCentreOperator()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Contact Centre Operator", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Dashboard View", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_DashboardView()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Dashboard View", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Field Supervisor", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FieldSupervisor()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Field Supervisor", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Field Supervisor (Stocktake)", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FieldSupervisorStocktake()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Field Supervisor (Stocktake)", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Field Tech + Logistics", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FieldTechLogistics()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Field Tech + Logistics", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Field Tech + Workshop + Logistics", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FieldTechWorkshopLogistics()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Field Tech + Workshop + Logistics", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Field Technician", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FieldTechnician()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Field Technician", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Finance", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Finance()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Finance", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Finance Admin", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_FinanceAdmin()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Finance Admin", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Human Resources", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_HumanResources()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Human Resources", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Kamco Client", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_KamcoClient()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Kamco Client", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Logistics + Reports", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_LogisticsReports()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Logistics + Reports", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " National Inventory", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_NationalInventory()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("National Inventory", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " National Workshop Manager", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_NationalWorkshopManager()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("National Workshop Manager", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Part Type Creation", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_PartTypeCreation()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Part Type Creation", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Projects", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Projects()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Projects", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Projects - SME", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Projects_SME()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Projects - SME", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Purchasing", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Purchasing()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Purchasing", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Service Delivery Manager", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_ServiceDeliveryManager()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Service Delivery Manager", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Staging", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Staging()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Staging", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " State Inventory", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_StateInventory()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("State Inventory", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " State Supply Chain Manager", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_StateSupplyChainManager()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("State Supply Chain Manager", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Stock Take", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_StockTake()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Stock Take", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Stocktake Reports", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_StocktakeReports()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Stocktake Reports", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Trainer", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Trainer()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Trainer", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " VG Agent Logistics", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_VGAgentLogistics()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("VG Agent Logistics", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Workshop Admin", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_WorkshopAdmin()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Workshop Admin", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Workshop Technician", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_WorkshopTechnician()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Workshop Technician", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Users without System Admin role shall not be allowed access to Admin menu screen," +
            " Worm", new string[] {
                "BSUITE-10092",
                "PositiveTests",
                "NegativeTests"}, SourceLine=25)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen_Worm()
        {
#line 19
this.UsersWithoutSystemAdminRoleShallNotBeAllowedAccessToAdminMenuScreen("Worm", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion