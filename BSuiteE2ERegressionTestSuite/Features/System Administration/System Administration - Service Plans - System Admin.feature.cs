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
    [TechTalk.SpecRun.FeatureAttribute("System Administration - Service Plans - System Admin", new string[] {
            "AllTests",
            "BSuite",
            "BSuite-Website",
            "System-Admin",
            "System-Administration"}, Description="\tAs a User with role System Admin accessing BSuite desktop portal,I am able to ad" +
        "d a Service Plan.", SourceFile="Features\\System Administration\\System Administration - Service Plans - System Adm" +
        "in.feature", SourceLine=1)]
    public partial class SystemAdministration_ServicePlans_SystemAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuite-Website",
                "System-Admin",
                "System-Administration"};
        
#line 1 "System Administration - Service Plans - System Admin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/System Administration", "System Administration - Service Plans - System Admin", "\tAs a User with role System Admin accessing BSuite desktop portal,I am able to ad" +
                    "d a Service Plan.", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "BSuite-Website",
                        "System-Admin",
                        "System-Administration"});
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
        
        public virtual void SystemAdministration_ServicePlans_SystemAdmin(string role, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-112",
                    "PositiveTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("System Administration - Service Plans - System Admin", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
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
#line 7
 testRunner.Given("I have opened the BSuite Desktop Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.And(string.Format("I login as a User with role \'{0}\'", role), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("I have navigated to \'Service Plan\' page from the top menu Lookup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("I click the \'Add New\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table136 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table136.AddRow(new string[] {
                            "Contract - Work Type",
                            "ALH Group - IT Support - Break Fix"});
                table136.AddRow(new string[] {
                            "Site",
                            "688"});
                table136.AddRow(new string[] {
                            "Generic Support",
                            "RegressionTest"});
#line 11
 testRunner.And("I enter the following details in the \'Service Plan\' page", ((string)(null)), table136, "And ");
#line hidden
#line 16
 testRunner.And("I enter into \'Service Plan Instructions\' frame and type as \'This service plan is " +
                        "created for regression testing only.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.When("I click the \'Save\' button to save the details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("\'View Service Plan\' page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Given("I click the \'Return To Search\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.And("\'Service Plan\' page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table137 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table137.AddRow(new string[] {
                            "WorkType Site Search Text",
                            "ALH Group - IT Support - Break Fix"});
#line 21
 testRunner.And("I enter the following details in the \'Service Plan\' page", ((string)(null)), table137, "And ");
#line hidden
#line 24
 testRunner.When("I click \'Search Service Plans\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("I verify the service plan newly added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.And("I click the \'Home\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("I log off from Bsuite \'Desktop\' portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("System Administration - Service Plans - System Admin, System Admin", new string[] {
                "GSQA-112",
                "PositiveTests"}, SourceLine=31)]
        public virtual void SystemAdministration_ServicePlans_SystemAdmin_SystemAdmin()
        {
#line 6
this.SystemAdministration_ServicePlans_SystemAdmin("System Admin", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion