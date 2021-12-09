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
    [TechTalk.SpecRun.FeatureAttribute("System Administration - User Records - System Admin", new string[] {
            "AllTests",
            "BSuite",
            "BSuite-Website",
            "System-Admin",
            "System-Administration"}, Description="\tAs a User with role \"System Admin\",I am able to add a new User Account.", SourceFile="Features\\System Administration\\System Administration - User Records - System Admi" +
        "n.feature", SourceLine=1)]
    public partial class SystemAdministration_UserRecords_SystemAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuite-Website",
                "System-Admin",
                "System-Administration"};
        
#line 1 "System Administration - User Records - System Admin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/System Administration", "System Administration - User Records - System Admin", "\tAs a User with role \"System Admin\",I am able to add a new User Account.", ProgrammingLanguage.CSharp, new string[] {
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
        
        [TechTalk.SpecRun.ScenarioAttribute("System Administration - User Records - System Admin", new string[] {
                "GSQA-110",
                "PositiveTests"}, SourceLine=5)]
        public virtual void SystemAdministration_UserRecords_SystemAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-110",
                    "PositiveTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("System Administration - User Records - System Admin", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 9
 testRunner.Given("I have logged into BSuite \'Desktop\' portal as a User with role \'System Admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.And("I have navigated to \'Personnel\' page from the top menu Lookup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("I click the \'Add Person\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table161 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table161.AddRow(new string[] {
                            "First Name",
                            "TestFieldTech"});
                table161.AddRow(new string[] {
                            "Last Name",
                            "Regression"});
                table161.AddRow(new string[] {
                            "Email",
                            "testfieldtech"});
                table161.AddRow(new string[] {
                            "Company",
                            "Bytecraft Systems P/L"});
                table161.AddRow(new string[] {
                            "AddressName",
                            "TestFieldTech"});
                table161.AddRow(new string[] {
                            "Address_Line 1",
                            "180 Ann St"});
                table161.AddRow(new string[] {
                            "Address_Suburb",
                            "Brisbane"});
                table161.AddRow(new string[] {
                            "Address_Postcode",
                            "4000"});
                table161.AddRow(new string[] {
                            "Address_Country",
                            "Australia"});
                table161.AddRow(new string[] {
                            "Address_State",
                            "QLD"});
                table161.AddRow(new string[] {
                            "Address_Timezone",
                            "Australia/Brisbane"});
#line 12
 testRunner.And("I enter the following details in the \'Personnel\' page", ((string)(null)), table161, "And ");
#line hidden
#line 25
 testRunner.And("I click the \'Save\' button to save the user details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("I have navigated to \'Personnel\' page from the top menu Lookup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table162 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table162.AddRow(new string[] {
                            "Search People",
                            "TestFieldTech"});
                table162.AddRow(new string[] {
                            "searchActiveFlag",
                            "ALL"});
#line 27
 testRunner.When("I enter the following details in the \'Personnel\' page", ((string)(null)), table162, "When ");
#line hidden
#line 31
 testRunner.And("I click the \'Search User\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("I verify the user name newly added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
