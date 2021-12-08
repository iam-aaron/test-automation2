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
    [TechTalk.SpecRun.FeatureAttribute("Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path -" +
        " via Mobile", new string[] {
            "AllTests",
            "BSuite",
            "HealthAndSafety",
            "Reporting"}, Description="\tAs a BSuite Mobile User\r\n\tI can login to BSuite Mobile portal\r\n\tSo that I can ca" +
        "rry out my tasks", SourceFile="Features\\Health and Safety\\Survey Reporting\\Verify the Pre Start Checklist - Fiel" +
        "d Technicians.Report.feature", SourceLine=1)]
    public partial class HealthAndSafety_MobileDailyPreStartForm_FieldTechnicians_HappyPath_ViaMobileFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "HealthAndSafety",
                "Reporting"};
        
#line 1 "Verify the Pre Start Checklist - Field Technicians.Report.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Health and Safety/Survey Reporting", "Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path -" +
                    " via Mobile", "\tAs a BSuite Mobile User\r\n\tI can login to BSuite Mobile portal\r\n\tSo that I can ca" +
                    "rry out my tasks", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "HealthAndSafety",
                        "Reporting"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path -" +
            " via Mobile", new string[] {
                "GSQA-163"}, SourceLine=7)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void HealthAndSafety_MobileDailyPreStartForm_FieldTechnicians_HappyPath_ViaMobile()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-163",
                    "ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health and Safety - Mobile Daily PreStart Form - Field Technicians - Happy Path -" +
                    " via Mobile", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I have opened the BSuite Mobile Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table73 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table73.AddRow(new string[] {
                            "<Role>",
                            "<Username>",
                            "<Password>"});
#line 10
 testRunner.And("I login as a User with User Profile as follows", ((string)(null)), table73, "And ");
#line hidden
#line 13
 testRunner.When("login is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion