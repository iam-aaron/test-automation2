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
namespace BSuiteE2ERegressionTestSuite.Features.HealthAndSafety.SurveyReporting
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Health and Safety - Reports - Prestart Desktop Report", new string[] {
            "AllTests",
            "BSuite",
            "Bsuite-Website",
            "HealthAndSafety",
            "Survey-Reporting",
            "Logistics-Team-Member",
            "PreStart-Desktop-Report"}, Description="\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal\r\n\tSo that I can " +
        "carry out my tasks", SourceFile="Features\\Health and Safety\\Survey Reporting\\Health and Safety - Reports - Prestar" +
        "t Desktop Report.feature", SourceLine=1)]
    [TechTalk.SpecRun.IgnoreAttribute()]
    public partial class HealthAndSafety_Reports_PrestartDesktopReportFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "Bsuite-Website",
                "HealthAndSafety",
                "Survey-Reporting",
                "Logistics-Team-Member",
                "PreStart-Desktop-Report",
                "ignore"};
        
#line 1 "Health and Safety - Reports - Prestart Desktop Report.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Health and Safety/Survey Reporting", "Health and Safety - Reports - Prestart Desktop Report", "\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal\r\n\tSo that I can " +
                    "carry out my tasks", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "Bsuite-Website",
                        "HealthAndSafety",
                        "Survey-Reporting",
                        "Logistics-Team-Member",
                        "PreStart-Desktop-Report",
                        "ignore"});
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
        
        public virtual void HealthAndSafety_Reports_PrestartDesktopReport_Day1PrestartForm(string role, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-177",
                    "PositiveTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health and Safety - Reports - Prestart Desktop Report - Day 1 Prestart Form", "All run on a single day(No Day 1 and Day 2)", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 11
 testRunner.Given("I have opened the BSuite Desktop Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
 testRunner.When(string.Format("I login as a User with role \'{0}\' for the first time in a day", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("I am required to complete the Pre Start Checklist for the day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table66.AddRow(new string[] {
                            "1",
                            "Are all licenses that you require for your duties/role currently valid? E.G. driv" +
                                "ers licence, gaming licence/forklift licence?"});
#line 14
 testRunner.And("the \'first\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table66, "And ");
#line hidden
#line 17
 testRunner.When("I respond \'Yes\' to the \'first\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table67.AddRow(new string[] {
                            "2",
                            "Are your tools and equipment in good condition and do you have sufficient/enough " +
                                "PPE?"});
#line 18
 testRunner.Then("the \'second\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table67, "Then ");
#line hidden
#line 21
 testRunner.When("I respond \'Yes\' to the \'second\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table68 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table68.AddRow(new string[] {
                            "3",
                            "Have you completed all mandatory training relevant to your Field Technicians Role" +
                                " - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of" +
                                " the SWP (Safe Work Practice) documents relevant to your role?"});
#line 22
 testRunner.Then("the \'third\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table68, "Then ");
#line hidden
#line 25
 testRunner.When("I respond \'Yes\' to the \'third\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table69.AddRow(new string[] {
                            "4",
                            "I am fit for work and can perform my work without compromising the safety or heal" +
                                "th of myself or others."});
#line 26
 testRunner.Then("the \'fourth\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table69, "Then ");
#line hidden
#line 29
 testRunner.When("I respond \'Yes\' to the \'fourth\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("the Submit button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("I click the \'Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("I log off from Bsuite \'Desktop\' portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.When("I have logged into BSuite \'Desktop\' portal as a User with role \'Service Delivery " +
                        "Manager\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And("I can navigate to \'Reports\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("I have clicked \'Prestart Desktop\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("I select DateTime range for current day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("I click \'Output To CSV\' button to download the Prestart Report", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then(string.Format("Open the downloaded Prestart Report to verify structure and Prestart Checklist re" +
                            "sponses of \'{0}\' are recorded accurately", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Health and Safety - Reports - Prestart Desktop Report - Day 1 Prestart Form, Logi" +
            "stics Technician", new string[] {
                "GSQA-177",
                "PositiveTests"}, SourceLine=41)]
        public virtual void HealthAndSafety_Reports_PrestartDesktopReport_Day1PrestartForm_LogisticsTechnician()
        {
#line 9
this.HealthAndSafety_Reports_PrestartDesktopReport_Day1PrestartForm("Logistics Technician", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
