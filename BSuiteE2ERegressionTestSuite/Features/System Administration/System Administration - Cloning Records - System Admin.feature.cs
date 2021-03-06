// ------------------------------------------------------------------------------
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
    [TechTalk.SpecRun.FeatureAttribute("System Administration - Cloning Records - System Admin", new string[] {
            "AllTests",
            "BSuite",
            "BSuite-Website",
            "System-Admin",
            "System-Administration"}, Description="\tAs a User with role \"System Admin\",I am able to Clone User Account from an exist" +
        "ing User Account.", SourceFile="Features\\System Administration\\System Administration - Cloning Records - System A" +
        "dmin.feature", SourceLine=1)]
    public partial class SystemAdministration_CloningRecords_SystemAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuite-Website",
                "System-Admin",
                "System-Administration"};
        
#line 1 "System Administration - Cloning Records - System Admin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/System Administration", "System Administration - Cloning Records - System Admin", "\tAs a User with role \"System Admin\",I am able to Clone User Account from an exist" +
                    "ing User Account.", ProgrammingLanguage.CSharp, new string[] {
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
        
        [TechTalk.SpecRun.ScenarioAttribute("System Administration - Cloning Records - System Admin", new string[] {
                "GSQA-109",
                "PositiveTests"}, SourceLine=5)]
        public virtual void SystemAdministration_CloningRecords_SystemAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-109",
                    "PositiveTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("System Administration - Cloning Records - System Admin", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.And("I can navigate to \'Admin\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("I click the \'Clone User Account\' link to clone the user account", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table157 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table157.AddRow(new string[] {
                            "Company",
                            "TABCORP"});
                table157.AddRow(new string[] {
                            "Clone from",
                            "testfieldtechnician100 BSuiteRegression - testfieldtechnician100"});
                table157.AddRow(new string[] {
                            "First Name",
                            "TestFT"});
                table157.AddRow(new string[] {
                            "Last Name",
                            "Regression"});
                table157.AddRow(new string[] {
                            "Email",
                            "TestFTRegression@tabcorp.com.au"});
                table157.AddRow(new string[] {
                            "User Name",
                            "TestFT"});
                table157.AddRow(new string[] {
                            "Password",
                            "bsuite"});
#line 12
 testRunner.And("I enter the following details in the \'Clone User Account\' page", ((string)(null)), table157, "And ");
#line hidden
#line 21
 testRunner.When("I click the \'Create\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("I fetch the user full name created successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("I have navigated to \'Personnel\' page from the top menu Lookup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table158 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table158.AddRow(new string[] {
                            "Search People",
                            "TestFT"});
                table158.AddRow(new string[] {
                            "searchActiveFlag",
                            "ALL"});
#line 24
 testRunner.When("I enter the following details in the \'Personnel\' page", ((string)(null)), table158, "When ");
#line hidden
#line 28
 testRunner.And("I click the \'Search User\' button to load details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("I verify the user name newly added", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
