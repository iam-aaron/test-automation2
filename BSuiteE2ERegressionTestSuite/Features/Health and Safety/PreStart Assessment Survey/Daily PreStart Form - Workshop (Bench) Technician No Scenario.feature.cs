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
namespace BSuiteE2ERegressionTestSuite.Features.HealthAndSafety.PreStartAssessmentSurvey
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Health and Safety - Daily PreStart Form - Workshop (Bench) Technician \"No\" Scenar" +
        "io", new string[] {
            "AllTests",
            "BSuite",
            "HealthAndSafety",
            "PreStartAssessment"}, SourceFile="Features\\Health and Safety\\PreStart Assessment Survey\\Daily PreStart Form - Works" +
        "hop (Bench) Technician No Scenario.feature", SourceLine=1)]
    public partial class HealthAndSafety_DailyPreStartForm_WorkshopBenchTechnicianNoScenarioFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "HealthAndSafety",
                "PreStartAssessment"};
        
#line 1 "Daily PreStart Form - Workshop (Bench) Technician No Scenario.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Health and Safety/PreStart Assessment Survey", "Health and Safety - Daily PreStart Form - Workshop (Bench) Technician \"No\" Scenar" +
                    "io", null, ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "HealthAndSafety",
                        "PreStartAssessment"});
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
        
        public virtual void HealthAndSafety_DailyPreStartForm_WorkshopBenchTechnicianNoScenario(string role, string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-168",
                    "NegativeTests",
                    "BSuite",
                    "BSuite-Mobile",
                    "BSuite-Website",
                    "Health&Safety",
                    "Workshop-Technician",
                    "Pre-Start-Form"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            argumentsOfScenario.Add("Username", username);
            argumentsOfScenario.Add("Password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health and Safety - Daily PreStart Form - Workshop (Bench) Technician \"No\" Scenar" +
                    "io", "Responds to questions where the Workshop Technician answers no and enters that he" +
                    " has contacted the People leader.\r\nOnce the Checklist is reactivated by the Peop" +
                    "le Leader then Workshop Technician can then proceed to the next question. ", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
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
#line 8
 testRunner.Given("I have opened the BSuite Desktop Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table21.AddRow(new string[] {
                            string.Format("{0}", role),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 9
 testRunner.And("I login as a User for the first time in a day with user details as follows", ((string)(null)), table21, "And ");
#line hidden
#line 12
 testRunner.Then("I am required to complete the Pre Start Checklist for the day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table22.AddRow(new string[] {
                            "1",
                            "Are all licenses that you require for your duties/role currently valid? E.G. driv" +
                                "ers licence, gaming licence/forklift licence?"});
#line 13
 testRunner.Then("the \'first\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table22, "Then ");
#line hidden
#line 16
 testRunner.When("I respond \'No\' to the \'first\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                            "Prompt Message"});
                table23.AddRow(new string[] {
                            "STOP, further action required"});
#line 17
 testRunner.Then("\'first\' prompt message is displayed to contact Supervisor as follows", ((string)(null)), table23, "Then ");
#line hidden
#line 20
 testRunner.When("data is enterered for the \'first\' question in that prompt after he has contacted " +
                        "the Supervisor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table24.AddRow(new string[] {
                            "2",
                            "Are your tools and equipment in good condition and do you have sufficient/enough " +
                                "PPE?"});
#line 21
 testRunner.Then("the \'second\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table24, "Then ");
#line hidden
#line 24
 testRunner.When("I respond \'No\' to the \'second\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                            "Prompt Message"});
                table25.AddRow(new string[] {
                            "Contact your People Leader"});
#line 25
 testRunner.Then("\'second\' prompt message is displayed to contact Supervisor as follows", ((string)(null)), table25, "Then ");
#line hidden
#line 28
 testRunner.When("data is enterered for the \'second\' question in that prompt after he has contacted" +
                        " the Supervisor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table26.AddRow(new string[] {
                            "3",
                            "Have you completed all mandatory training relevant to your Field Technicians Role" +
                                " - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of" +
                                " the SWP (Safe Work Practice) documents relevant to your role?"});
#line 29
 testRunner.Then("the \'third\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table26, "Then ");
#line hidden
#line 32
 testRunner.When("I respond \'No\' to the \'third\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "Prompt Message"});
                table27.AddRow(new string[] {
                            "Contact your People Leader"});
#line 33
 testRunner.Then("\'third\' prompt message is displayed to contact Supervisor as follows", ((string)(null)), table27, "Then ");
#line hidden
#line 36
 testRunner.When("data is enterered for the \'third\' question in that prompt after he has contacted " +
                        "the Supervisor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table28.AddRow(new string[] {
                            "4",
                            "I am fit for work and can perform my work without compromising the safety or heal" +
                                "th of myself or others."});
#line 37
 testRunner.Then("the \'fourth\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table28, "Then ");
#line hidden
#line 40
 testRunner.When("I respond \'No\' to the \'fourth\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Prompt Message"});
                table29.AddRow(new string[] {
                            "STOP"});
#line 41
 testRunner.Then("\'fourth\' prompt message is displayed to contact Supervisor as follows", ((string)(null)), table29, "Then ");
#line hidden
#line 44
 testRunner.When("data is enterered for the \'fourth\' question in that prompt after he has contacted" +
                        " the Supervisor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.When("I click the \'Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Health and Safety - Daily PreStart Form - Workshop (Bench) Technician \"No\" Scenar" +
            "io, Workshop Technician (New)", new string[] {
                "GSQA-168",
                "NegativeTests",
                "BSuite",
                "BSuite-Mobile",
                "BSuite-Website",
                "Health&Safety",
                "Workshop-Technician",
                "Pre-Start-Form"}, SourceLine=49)]
        public virtual void HealthAndSafety_DailyPreStartForm_WorkshopBenchTechnicianNoScenario_WorkshopTechnicianNew()
        {
#line 5
this.HealthAndSafety_DailyPreStartForm_WorkshopBenchTechnicianNoScenario("Workshop Technician (New)", "TestWrkshp168Tech3", "bsuite", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion