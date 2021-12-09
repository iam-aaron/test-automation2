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
    [TechTalk.SpecRun.FeatureAttribute("Health and Safety - Mobile Daily PreStart Form - Field Technicians Daily PreStart" +
        " Form will be available on mobile devices only", new string[] {
            "AllTests",
            "BSuite",
            "HealthAndSafety",
            "Pre-Start-Form"}, Description="\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal\r\n\tSo that I can " +
        "verify is Daily PreStart form is being displayed only in mobile and not in Deskt" +
        "op", SourceFile="Features\\Health and Safety\\PreStart Assessment Survey\\Pre Start Checklist - Field" +
        " Technicians Login- In Mobile - Not in Desktop - Report.feature", SourceLine=1)]
    [TechTalk.SpecRun.IgnoreAttribute()]
    public partial class HealthAndSafety_MobileDailyPreStartForm_FieldTechniciansDailyPreStartFormWillBeAvailableOnMobileDevicesOnlyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "HealthAndSafety",
                "Pre-Start-Form",
                "ignore"};
        
#line 1 "Pre Start Checklist - Field Technicians Login- In Mobile - Not in Desktop - Report.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Health and Safety/PreStart Assessment Survey", "Health and Safety - Mobile Daily PreStart Form - Field Technicians Daily PreStart" +
                    " Form will be available on mobile devices only", "\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal\r\n\tSo that I can " +
                    "verify is Daily PreStart form is being displayed only in mobile and not in Deskt" +
                    "op", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "HealthAndSafety",
                        "Pre-Start-Form",
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
        
        public virtual void HealthAndSafety_MobileDailyPreStartForm_FieldTechniciansDailyPreStartFormWillNotBeAvailableInDesktopPortalAndWillBeAvailableForFieldTechnicianInMobilePortalOnly(string role, string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-164",
                    "Negative-Scenario-B-Suite-Desktop",
                    "Positive-Scenario-B-Suite-Mobile",
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health and Safety - Mobile Daily PreStart Form - Field Technicians Daily PreStart" +
                    " Form will not be available in desktop portal and will be available for Field Te" +
                    "chnician in Mobile Portal only", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table47.AddRow(new string[] {
                            string.Format("{0}", role),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 10
 testRunner.When("I login as a User with User Profile as follows", ((string)(null)), table47, "When ");
#line hidden
#line 13
 testRunner.Then("login is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And("Daily preStartChecklList Should not be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I log off from Bsuite \'Desktop\' portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table48.AddRow(new string[] {
                            string.Format("{0}", role),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 18
 testRunner.Given("I have logged into \'BSuite Mobile\' portal as a User with following User Profile", ((string)(null)), table48, "Given ");
#line hidden
#line 21
 testRunner.Then("login is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("I am required to complete the Pre Start Checklist for the day in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table49.AddRow(new string[] {
                            "1",
                            "My vehicle is roadworthy – e.g. windscreen and mirrors free of damage, all lights" +
                                " operational and tyres inflated with sufficient tread."});
#line 23
 testRunner.Then("the \'first\' question of the Pre Start Checklist is displayed as follows in mobile" +
                        " portal", ((string)(null)), table49, "Then ");
#line hidden
#line 26
 testRunner.When("I respond \'Yes\' to the \'first\' Pre Start Checklist question in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table50.AddRow(new string[] {
                            "2",
                            "Are all licenses that you require for your duties / role currently valid? E.G. dr" +
                                "ivers licence, gaming licence?"});
#line 27
 testRunner.Then("the \'second\' question of the Pre Start Checklist is displayed as follows in mobil" +
                        "e portal", ((string)(null)), table50, "Then ");
#line hidden
#line 30
 testRunner.When("I respond \'Yes\' to the \'second\' Pre Start Checklist question in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table51.AddRow(new string[] {
                            "3",
                            "Are your tools and equipment in good condition and do you have sufficient / enoug" +
                                "h PPE?"});
#line 31
 testRunner.Then("the \'third\' question of the Pre Start Checklist is displayed as follows in mobile" +
                        " portal", ((string)(null)), table51, "Then ");
#line hidden
#line 34
 testRunner.When("I respond \'Yes\' to the \'third\' Pre Start Checklist question in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table52.AddRow(new string[] {
                            "4",
                            "Have you completed all mandatory training relevant to your Field Technicians Role" +
                                " – (e.g. Electrical safety / lifting / ladders etc.) OR are you familiar with al" +
                                "l of the SWP (Safe Work Practice) documents relevant to your role?"});
#line 35
 testRunner.Then("the \'fourth\' question of the Pre Start Checklist is displayed as follows in mobil" +
                        "e portal", ((string)(null)), table52, "Then ");
#line hidden
#line 38
 testRunner.When("I respond \'Yes\' to the \'fourth\' Pre Start Checklist question in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table53.AddRow(new string[] {
                            "5",
                            "I am fit for work and can perform my work without compromising the safety or heal" +
                                "th of myself or others."});
#line 39
 testRunner.Then("the \'fifth\' question of the Pre Start Checklist is displayed as follows in mobile" +
                        " portal", ((string)(null)), table53, "Then ");
#line hidden
#line 42
 testRunner.When("I respond \'Yes\' to the \'fifth\' Pre Start Checklist question in mobile portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("I click the \'Submit\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Health and Safety - Mobile Daily PreStart Form - Field Technicians Daily PreStart" +
            " Form will not be available in desktop portal and will be available for Field Te" +
            "chnician in Mobile Portal only, Field Technician", new string[] {
                "GSQA-164",
                "Negative-Scenario-B-Suite-Desktop",
                "Positive-Scenario-B-Suite-Mobile",
                "Pre-Start-Form"}, SourceLine=47)]
        public virtual void HealthAndSafety_MobileDailyPreStartForm_FieldTechniciansDailyPreStartFormWillNotBeAvailableInDesktopPortalAndWillBeAvailableForFieldTechnicianInMobilePortalOnly_FieldTechnician()
        {
#line 8
this.HealthAndSafety_MobileDailyPreStartForm_FieldTechniciansDailyPreStartFormWillNotBeAvailableInDesktopPortalAndWillBeAvailableForFieldTechnicianInMobilePortalOnly("Field Technician", "TestField164Tech1", "bsuite", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
