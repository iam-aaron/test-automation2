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
namespace BSuiteE2ERegressionTestSuite.Features.HealthAndSafety.PreStartAssessmentSurvey
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Logistics Tech" +
        "nician - Happy Path via Desktop", new string[] {
            "AllTests",
            "BSuite",
            "BSuiteDesktop",
            "Login"}, Description="\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal Health and Safet" +
        "y\r\n\tSo that I can carry out my tasks", SourceFile="Features\\Health and Safety\\PreStart Assessment Survey\\Desktop Daily PreStart Form" +
        " - Warehouse Team - Logistics Technician - Happy Path via Desktop.feature", SourceLine=1)]
    [TechTalk.SpecRun.IgnoreAttribute()]
    public partial class HealthAndSafety_DesktopDailyPreStartForm_WarehouseTeam_LogisticsTechnician_HappyPathViaDesktopFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuiteDesktop",
                "Login",
                "ignore"};
        
#line 1 "Desktop Daily PreStart Form - Warehouse Team - Logistics Technician - Happy Path via Desktop.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Health and Safety/PreStart Assessment Survey", "Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Logistics Tech" +
                    "nician - Happy Path via Desktop", "\tAs a BSuite Desktop User\r\n\tI can login to BSuite Desktop portal Health and Safet" +
                    "y\r\n\tSo that I can carry out my tasks", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "BSuiteDesktop",
                        "Login",
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
        
        public virtual void HealthAndSafety_DesktopDailyPreStartForm_WarehouseTeam_LogisticsTechnician_HappyPathViaDesktop(string role, string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-166",
                    "PositiveTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Role", role);
            argumentsOfScenario.Add("Username", username);
            argumentsOfScenario.Add("Password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Logistics Tech" +
                    "nician - Happy Path via Desktop", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "Role",
                            "Username",
                            "Password"});
                table28.AddRow(new string[] {
                            string.Format("{0}", role),
                            string.Format("{0}", username),
                            string.Format("{0}", password)});
#line 10
 testRunner.And("I login as a User for the first time in a day with user details as follows", ((string)(null)), table28, "And ");
#line hidden
#line 13
 testRunner.Then("I am required to complete the Pre Start Checklist for the day", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table29.AddRow(new string[] {
                            "1",
                            "Are all licenses that you require for your duties/role currently valid? E.G. driv" +
                                "ers licence, gaming licence/forklift licence?"});
#line 14
 testRunner.Then("the \'first\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table29, "Then ");
#line hidden
#line 17
 testRunner.When("I respond \'Yes\' to the \'first\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table30.AddRow(new string[] {
                            "2",
                            "Are your tools and equipment in good condition and do you have sufficient/enough " +
                                "PPE?"});
#line 18
 testRunner.Then("the \'second\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table30, "Then ");
#line hidden
#line 21
 testRunner.When("I respond \'Yes\' to the \'second\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table31.AddRow(new string[] {
                            "3",
                            "Have you completed all mandatory training relevant to your Field Technicians Role" +
                                " - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of" +
                                " the SWP (Safe Work Practice) documents relevant to your role?"});
#line 22
 testRunner.Then("the \'third\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table31, "Then ");
#line hidden
#line 25
 testRunner.When("I respond \'Yes\' to the \'third\' Pre Start Checklist question", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "Question Number",
                            "Question"});
                table32.AddRow(new string[] {
                            "4",
                            "I am fit for work and can perform my work without compromising the safety or heal" +
                                "th of myself or others."});
#line 26
 testRunner.Then("the \'fourth\' question of the Pre Start Checklist is displayed as follows", ((string)(null)), table32, "Then ");
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
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Health and Safety - Desktop Daily PreStart Form - Warehouse Team - Logistics Tech" +
            "nician - Happy Path via Desktop, Logistics Technician", new string[] {
                "GSQA-166",
                "PositiveTests"}, SourceLine=35)]
        public virtual void HealthAndSafety_DesktopDailyPreStartForm_WarehouseTeam_LogisticsTechnician_HappyPathViaDesktop_LogisticsTechnician()
        {
#line 8
this.HealthAndSafety_DesktopDailyPreStartForm_WarehouseTeam_LogisticsTechnician_HappyPathViaDesktop("Logistics Technician", "TestLog166Tech3", "bsuite", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
