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
    [TechTalk.SpecRun.FeatureAttribute("System Administration - Sites - System Admin", new string[] {
            "AllTests",
            "BSuite",
            "BSuite-Website",
            "System-Admin",
            "System-Administration"}, Description="\tAs a User with role System Admin accessing BSuite desktop portal,I am able to vi" +
        "ew/add a Site under a Zone.", SourceFile="Features\\System Administration\\System Administration - Sites - System Admin.featu" +
        "re", SourceLine=1)]
    public partial class SystemAdministration_Sites_SystemAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuite-Website",
                "System-Admin",
                "System-Administration"};
        
#line 1 "System Administration - Sites - System Admin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/System Administration", "System Administration - Sites - System Admin", "\tAs a User with role System Admin accessing BSuite desktop portal,I am able to vi" +
                    "ew/add a Site under a Zone.", ProgrammingLanguage.CSharp, new string[] {
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
        
        [TechTalk.SpecRun.ScenarioAttribute("System Administration - Sites - System Admin", new string[] {
                "GSQA-118",
                "PositiveTests"}, SourceLine=5)]
        public virtual void SystemAdministration_Sites_SystemAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-118",
                    "PositiveTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("System Administration - Sites - System Admin", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.And("I have navigated to \'Region\' page from the top menu Lookup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("I select the \'Please Select\' drop down value as \'Regions\' for the country \'Name\' " +
                        "\'Australia\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("The \'List of Regions\' within the country \'Australia\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("I click the \'Areas\' button for the \'Region\' \'QLD\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("The \'List of Areas\' under the region \'QLD\' within the country \'Australia\' is disp" +
                        "layed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("I click the \'Zone Sets\' button for the \'Area Name\' \'QLD Metro\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("The \'List of Zone Sets\' under the area \'QLD Metro\' within the Region \'QLD\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.When("I click the \'Zones\' button for the \'Zone Set\' \'QLD Metro N 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("The \'List of Zones\' under the zone set \'QLD Metro N 1\' within the area \'QLD Metro" +
                        "\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.When("I click the \'Sites\' button for the \'Zone\' \'QLD ALBION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("The \'List of Sites\' under the zone \'QLD ALBION\' within the zone set \'QLD Metro N " +
                        "1\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
