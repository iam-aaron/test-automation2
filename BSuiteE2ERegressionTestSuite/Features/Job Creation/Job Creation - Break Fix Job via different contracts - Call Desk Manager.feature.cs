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
namespace BSuiteE2ERegressionTestSuite.Features.JobCreation
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Job Creation - Break Fix Job via different contracts - Call Desk Manager", new string[] {
            "AllTests",
            "BSuite",
            "BSuiteDesktop",
            "Call-Desk-Manager",
            "Job-Creation"}, Description="\tAs a BSuite Desktop User with Role Call Desk Manager\r\n\tI can Add a New Task\r\n\tSo" +
        " that I may carry out my Call Desk Manager tasks", SourceFile="Features\\Job Creation\\Job Creation - Break Fix Job via different contracts - Call" +
        " Desk Manager.feature", SourceLine=1)]
    public partial class JobCreation_BreakFixJobViaDifferentContracts_CallDeskManagerFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "BSuite",
                "BSuiteDesktop",
                "Call-Desk-Manager",
                "Job-Creation"};
        
#line 1 "Job Creation - Break Fix Job via different contracts - Call Desk Manager.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Job Creation", "Job Creation - Break Fix Job via different contracts - Call Desk Manager", "\tAs a BSuite Desktop User with Role Call Desk Manager\r\n\tI can Add a New Task\r\n\tSo" +
                    " that I may carry out my Call Desk Manager tasks", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "BSuite",
                        "BSuiteDesktop",
                        "Call-Desk-Manager",
                        "Job-Creation"});
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
        
        public virtual void JobCreation_BreakFixJobViaDifferentContracts_CallDeskManager(string contract, string site, string app_StartTime, string app_StartHour, string app_StartMinute, string app_EndTime, string app_EndHour, string app_EndMinute, string position, string part, string partStatus, string priority, string problemCategory, string problemCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "GSQA-4",
                    "PositiveTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Contract", contract);
            argumentsOfScenario.Add("Site", site);
            argumentsOfScenario.Add("App. Start Time", app_StartTime);
            argumentsOfScenario.Add("App. Start Hour", app_StartHour);
            argumentsOfScenario.Add("App. Start Minute", app_StartMinute);
            argumentsOfScenario.Add("App. End Time", app_EndTime);
            argumentsOfScenario.Add("App. End Hour", app_EndHour);
            argumentsOfScenario.Add("App. End Minute", app_EndMinute);
            argumentsOfScenario.Add("Position", position);
            argumentsOfScenario.Add("Part", part);
            argumentsOfScenario.Add("Part Status", partStatus);
            argumentsOfScenario.Add("Priority", priority);
            argumentsOfScenario.Add("Problem Category", problemCategory);
            argumentsOfScenario.Add("Problem Code", problemCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job Creation - Break Fix Job via different contracts - Call Desk Manager", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 12
 testRunner.Given("I have logged into BSuite \'Desktop\' portal as a User with role \'Call Desk Manager" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
 testRunner.And("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table125 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table125.AddRow(new string[] {
                            "Contract/WorkType",
                            string.Format("{0}", contract)});
#line 14
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table125, "And ");
#line hidden
#line 17
 testRunner.And("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table126 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table126.AddRow(new string[] {
                            "Site",
                            string.Format("{0}", site)});
                table126.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table126.AddRow(new string[] {
                            "App. Start Time",
                            string.Format("{0}", app_StartTime)});
                table126.AddRow(new string[] {
                            "App. Start Hour",
                            string.Format("{0}", app_StartHour)});
                table126.AddRow(new string[] {
                            "App. Start Minute",
                            string.Format("{0}", app_StartMinute)});
                table126.AddRow(new string[] {
                            "App. End Time",
                            string.Format("{0}", app_EndTime)});
                table126.AddRow(new string[] {
                            "App. End Hour",
                            string.Format("{0}", app_EndHour)});
                table126.AddRow(new string[] {
                            "App. End Minute",
                            string.Format("{0}", app_EndMinute)});
                table126.AddRow(new string[] {
                            "Serial Number",
                            "GSQA04"});
                table126.AddRow(new string[] {
                            "Position",
                            string.Format("{0}", position)});
                table126.AddRow(new string[] {
                            "Part",
                            string.Format("{0}", part)});
                table126.AddRow(new string[] {
                            "Part Status",
                            string.Format("{0}", partStatus)});
                table126.AddRow(new string[] {
                            "Priority",
                            string.Format("{0}", priority)});
                table126.AddRow(new string[] {
                            "Client Ref #",
                            "GSQA04"});
                table126.AddRow(new string[] {
                            "Problem Category",
                            string.Format("{0}", problemCategory)});
                table126.AddRow(new string[] {
                            "Problem Code",
                            string.Format("{0}", problemCode)});
                table126.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA 4 Reg Test"});
                table126.AddRow(new string[] {
                            "Client Notes",
                            "GSQA 4 Reg Test"});
                table126.AddRow(new string[] {
                            "Call Centre Notes",
                            "GSQA 4 Reg Test"});
#line 18
 testRunner.When("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table126, "When ");
#line hidden
#line 40
 testRunner.And("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table127 = new TechTalk.SpecFlow.Table(new string[] {
                            "Target",
                            "End Time"});
                table127.AddRow(new string[] {
                            "Creation Time",
                            "Current Time"});
                table127.AddRow(new string[] {
                            "TAKEN",
                            "Current Time + 0.5 hours"});
                table127.AddRow(new string[] {
                            "ONSITE",
                            "Current Time + 2 hours"});
                table127.AddRow(new string[] {
                            "CLOSED",
                            "Current Time + 14 hours"});
#line 41
 testRunner.Then("a new Field Task is saved with the following Client Targets", ((string)(null)), table127, "Then ");
#line hidden
#line 47
 testRunner.Then("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Job Creation - Break Fix Job via different contracts - Call Desk Manager, ALH Gro" +
            "up - IT Support - Break Fix", new string[] {
                "GSQA-4",
                "PositiveTests"}, SourceLine=50)]
        public virtual void JobCreation_BreakFixJobViaDifferentContracts_CallDeskManager_ALHGroup_ITSupport_BreakFix()
        {
#line 8
this.JobCreation_BreakFixJobViaDifferentContracts_CallDeskManager("ALH Group - IT Support - Break Fix", "688", "2021-11-17", "02", "00", "2021-11-17", "02", "30", "1", "1000041", "Degraded", "1", "Unknown", "Unknown", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
