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
namespace BSuiteE2ERegressionTestSuite.Features.JobAssignment
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager", new string[] {
            "AllTests",
            "Bsuite",
            "BSuite-Website",
            "Call-Desk-Manager",
            "JobAssignment"}, Description=@"As a User with role ""Call Desk Manager"" accessing BSuite desktop portal,
I am able to Assign Task to a Field Technician on BSuite desktop portal,
So that the task will then be available for the Field Technician to view by clicking Mine in the Tasks section at the top of the main screen on the BSuite mobile portal.", SourceFile="Features\\Job Assignment\\Job Assignment - Field Tech Assigned Job via Desktop - Ca" +
        "ll Desk Manager.feature", SourceLine=1)]
    public partial class JobAssignment_FieldTechAssignedJobViaDesktop_CallDeskManagerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "Bsuite",
                "BSuite-Website",
                "Call-Desk-Manager",
                "JobAssignment"};
        
#line 1 "Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Job Assignment", "Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager", @"As a User with role ""Call Desk Manager"" accessing BSuite desktop portal,
I am able to Assign Task to a Field Technician on BSuite desktop portal,
So that the task will then be available for the Field Technician to view by clicking Mine in the Tasks section at the top of the main screen on the BSuite mobile portal.", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "Bsuite",
                        "BSuite-Website",
                        "Call-Desk-Manager",
                        "JobAssignment"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager", new string[] {
                "GSQA-25"}, SourceLine=8)]
        public virtual void JobAssignment_FieldTechAssignedJobViaDesktop_CallDeskManager()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-25"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job Assignment - Field Tech Assigned Job via Desktop - Call Desk Manager", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
#line 10
 testRunner.Given("I have logged into BSuite \'Desktop\' portal as a User with role \'Call Desk Manager" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.And("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table71 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table71.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 12
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table71, "And ");
#line hidden
#line 15
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table72 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table72.AddRow(new string[] {
                            "Site",
                            "688"});
                table72.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table72.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table72.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table72.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table72.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table72.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table72.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table72.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table72.AddRow(new string[] {
                            "Position",
                            "1"});
                table72.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table72.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table72.AddRow(new string[] {
                            "Priority",
                            "1"});
                table72.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table72.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table72.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-25"});
#line 16
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table72, "Then ");
#line hidden
#line 34
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Given("I have navigated to \'Tasks by Watch List\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
 testRunner.And("I click the \'Edit Preferences\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("I add the technician \'TestFieldTech27\' from \'All Technicians\' to \'Technicians cur" +
                        "rently on watch list\' in \'Edit Watch List Preference\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("I add state as \'QLD\' and worktype as \'ALH Group - IT Support Break Fix\' to watch " +
                        "list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("I click the \'Save and Update\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("I click the \'Unassigned\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("I select the task number fetched for the state \'QLD\' and the worktype \'ALH Group " +
                        "- IT Support Break Fix\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("I select \'TAKEN\' from the \'Task Status\' drop down box for \'Field Technician\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("I log off from Bsuite \'Desktop\' portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.When("I have opened the BSuite Mobile Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table73 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table73.AddRow(new string[] {
                            "Field Technician",
                            "TestFieldTech27",
                            "bsuite"});
#line 50
 testRunner.And("I login as a User with User Profile as follows", ((string)(null)), table73, "And ");
#line hidden
#line 54
 testRunner.Then("I click the \'Mine\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.And("I click the \'Task #\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("I verify the task in My Tasks page on mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
