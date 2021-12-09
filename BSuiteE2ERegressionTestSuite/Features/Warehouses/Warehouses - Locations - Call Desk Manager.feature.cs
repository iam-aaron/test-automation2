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
namespace BSuiteE2ERegressionTestSuite.Features.Warehouses
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Warehouses - Locations - Call Desk Manager", new string[] {
            "AllTests",
            "BSuite",
            "BSuite-Website",
            "Logistics-Admin",
            "Warehouses"}, Description="As a valid BSuite User with role \"Call Desk Manager\",\r\nI am able to browse for lo" +
        "cations and details about Warehouses.", SourceFile="Features\\Warehouses\\Warehouses - Locations - Call Desk Manager.feature", SourceLine=1)]
    public partial class Warehouses_Locations_CallDeskManagerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuite-Website",
                "Logistics-Admin",
                "Warehouses"};
        
#line 1 "Warehouses - Locations - Call Desk Manager.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Warehouses", "Warehouses - Locations - Call Desk Manager", "As a valid BSuite User with role \"Call Desk Manager\",\r\nI am able to browse for lo" +
                    "cations and details about Warehouses.", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "BSuite-Website",
                        "Logistics-Admin",
                        "Warehouses"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Warehouses - Locations - Call Desk Manager", new string[] {
                "GSQA-98"}, SourceLine=6)]
        public virtual void Warehouses_Locations_CallDeskManager()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-98"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Warehouses - Locations - Call Desk Manager", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
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
 testRunner.Given("I have logged into BSuite \'Desktop\' portal as a User with role \'Call Desk Manager" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("I have navigated to \'Admin Warehouse\' page from \'Administration\' in \'Logistics\' t" +
                        "op menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("I enter \'Warehouse Name\' as \'VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("I click the \'Search\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("I fetch the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("I click the \'Show Details\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When("I select the \'Show Details\' drop down value as \'View Record\' in \'Admin Warehouse\'" +
                        " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("I verify the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When("I select the \'Show Details\' drop down value as \'To Alias\' in \'Admin Warehouse\' pa" +
                        "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("A new window is displayed  for \'List Of Location Alias(es) For VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("I select the \'Show Details\' drop down value as \'To MSL\' in \'Admin Warehouse\' page" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("A new window is displayed  for \'Setting Warehouse MSL for: VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("I select the \'Show Details\' drop down value as \'To Group MSL\' in \'Admin Warehouse" +
                        "\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("A new window is displayed  for \'Set Group MSL for VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Given("I enter \'Alias\' as \'Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.And("I click the \'Search\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("I fetch the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("I click the \'Show Details\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("I select the \'Show Details\' drop down value as \'View Record\' in \'Admin Warehouse\'" +
                        " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("I verify the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("I select the \'Show Details\' drop down value as \'To Alias\' in \'Admin Warehouse\' pa" +
                        "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("A new window is displayed  for \'List Of Location Alias(es) For VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When("I select the \'Show Details\' drop down value as \'To MSL\' in \'Admin Warehouse\' page" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("A new window is displayed  for \'Setting Warehouse MSL for: VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When("I select the \'Show Details\' drop down value as \'To Group MSL\' in \'Admin Warehouse" +
                        "\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("A new window is displayed  for \'Set Group MSL for VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Given("I click the \'Reset\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 35
 testRunner.And("I select the \'Bytecraft/External/VIC/Client Warehouses VIC\' location in the Selec" +
                        "t a Warehouse Location tree", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.And("I click the \'Show Warehouses Under\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("I fetch the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("I click the \'Show Details\' link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.When("I select the \'Show Details\' drop down value as \'View Record\' in \'Admin Warehouse\'" +
                        " page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.Then("I verify the warehouse details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.When("I select the \'Show Details\' drop down value as \'To Alias\' in \'Admin Warehouse\' pa" +
                        "ge", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("A new window is displayed  for \'List Of Location Alias(es) For VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.When("I select the \'Show Details\' drop down value as \'To MSL\' in \'Admin Warehouse\' page" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("A new window is displayed  for \'Setting Warehouse MSL for: VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When("I select the \'Show Details\' drop down value as \'To Group MSL\' in \'Admin Warehouse" +
                        "\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then("A new window is displayed  for \'Set Group MSL for VIC CW Activ8me\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
