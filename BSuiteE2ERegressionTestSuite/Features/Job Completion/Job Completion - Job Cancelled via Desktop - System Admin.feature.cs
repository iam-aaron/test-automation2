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
namespace BSuiteE2ERegressionTestSuite.Features.JobCompletion
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Job Completion - Job Cancelled via Desktop - System Admin", new string[] {
            "AllTests",
            "Bsuite",
            "BSuite-Website",
            "Job-Completion",
            "System-Admin"}, Description="As a User with role \"System Admin\" accessing BSuite desktop portal,\r\nI am able to" +
        " Cancel a Task", SourceFile="Features\\Job Completion\\Job Completion - Job Cancelled via Desktop - System Admin" +
        ".feature", SourceLine=1)]
    public partial class JobCompletion_JobCancelledViaDesktop_SystemAdminFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AllTests",
                "Bsuite",
                "BSuite-Website",
                "Job-Completion",
                "System-Admin"};
        
#line 1 "Job Completion - Job Cancelled via Desktop - System Admin.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Job Completion", "Job Completion - Job Cancelled via Desktop - System Admin", "As a User with role \"System Admin\" accessing BSuite desktop portal,\r\nI am able to" +
                    " Cancel a Task", ProgrammingLanguage.CSharp, new string[] {
                        "AllTests",
                        "Bsuite",
                        "BSuite-Website",
                        "Job-Completion",
                        "System-Admin"});
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Job Completion - Job Cancelled via Desktop - System Admin", new string[] {
                "GSQA-52"}, SourceLine=6)]
        public virtual void JobCompletion_JobCancelledViaDesktop_SystemAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "GSQA-52"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Job Completion - Job Cancelled via Desktop - System Admin", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("I have logged into BSuite \'Desktop\' portal as a User with role \'System Admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table115 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table115.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 10
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table115, "And ");
#line hidden
#line 13
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table116 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table116.AddRow(new string[] {
                            "Site",
                            "688"});
                table116.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table116.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table116.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table116.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table116.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table116.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table116.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table116.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table116.AddRow(new string[] {
                            "Position",
                            "1"});
                table116.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table116.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table116.AddRow(new string[] {
                            "Priority",
                            "1"});
                table116.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table116.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table116.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-52"});
#line 14
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table116, "Then ");
#line hidden
#line 32
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.And("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.And("I click \'Search Field Tasks\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.When("I select the task number with status as \'SENT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.Given("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table117 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table117.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 46
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table117, "And ");
#line hidden
#line 49
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table118 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table118.AddRow(new string[] {
                            "Site",
                            "688"});
                table118.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table118.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table118.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table118.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table118.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table118.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table118.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table118.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table118.AddRow(new string[] {
                            "Position",
                            "1"});
                table118.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table118.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table118.AddRow(new string[] {
                            "Priority",
                            "1"});
                table118.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table118.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table118.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-53"});
#line 50
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table118, "Then ");
#line hidden
#line 68
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 72
 testRunner.And("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("I select \'TAKEN\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.Given("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table119 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table119.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 79
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table119, "And ");
#line hidden
#line 82
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table120 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table120.AddRow(new string[] {
                            "Site",
                            "688"});
                table120.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table120.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table120.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table120.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table120.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table120.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table120.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table120.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table120.AddRow(new string[] {
                            "Position",
                            "1"});
                table120.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table120.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table120.AddRow(new string[] {
                            "Priority",
                            "1"});
                table120.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table120.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table120.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-53"});
#line 83
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table120, "Then ");
#line hidden
#line 101
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 102
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 105
 testRunner.And("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And("I select \'QUEUED\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.And("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.Then("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.Given("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table121 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table121.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 112
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table121, "And ");
#line hidden
#line 115
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table122 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table122.AddRow(new string[] {
                            "Site",
                            "688"});
                table122.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table122.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table122.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table122.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table122.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table122.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table122.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table122.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table122.AddRow(new string[] {
                            "Position",
                            "1"});
                table122.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table122.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table122.AddRow(new string[] {
                            "Priority",
                            "1"});
                table122.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table122.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table122.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-53"});
#line 116
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table122, "Then ");
#line hidden
#line 134
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 135
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 138
 testRunner.And("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
 testRunner.And("I select \'TAKEN\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
 testRunner.And("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 141
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 142
 testRunner.Then("I select \'RELEASED\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 144
 testRunner.Then("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.Given("I have navigated to \'Call Centre\' page from the top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table123 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value"});
                table123.AddRow(new string[] {
                            "Contract/WorkType",
                            "ALH Group - IT Support - Break Fix"});
#line 147
 testRunner.And("I have navigated to \'Add Task\' page and entered details as follows", ((string)(null)), table123, "And ");
#line hidden
#line 150
 testRunner.When("I click the \'Add Task\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table124 = new TechTalk.SpecFlow.Table(new string[] {
                            "Field",
                            "Value/Action"});
                table124.AddRow(new string[] {
                            "Site",
                            "688"});
                table124.AddRow(new string[] {
                            "Contact",
                            "Sam1234"});
                table124.AddRow(new string[] {
                            "App. Start Time",
                            "2021-11-02"});
                table124.AddRow(new string[] {
                            "App. Start Hour",
                            "00"});
                table124.AddRow(new string[] {
                            "App. Start Minute",
                            "55"});
                table124.AddRow(new string[] {
                            "App. End Time",
                            "2021-11-18"});
                table124.AddRow(new string[] {
                            "App. End Hour",
                            "00"});
                table124.AddRow(new string[] {
                            "App. End Minute",
                            "00"});
                table124.AddRow(new string[] {
                            "Serial Number",
                            "1"});
                table124.AddRow(new string[] {
                            "Position",
                            "1"});
                table124.AddRow(new string[] {
                            "Part",
                            "1000041"});
                table124.AddRow(new string[] {
                            "Part Status",
                            "Usable"});
                table124.AddRow(new string[] {
                            "Priority",
                            "1"});
                table124.AddRow(new string[] {
                            "Problem Category",
                            "Unknown"});
                table124.AddRow(new string[] {
                            "Problem Code",
                            "Unknown"});
                table124.AddRow(new string[] {
                            "Problem Desc",
                            "GSQA-53"});
#line 151
 testRunner.Then("I enter the following details in the \'Add Task - FieldTask\' page", ((string)(null)), table124, "Then ");
#line hidden
#line 169
 testRunner.When("I click the \'Save\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 170
 testRunner.Then("I fetch the task number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 171
 testRunner.And("I click the \'Finish\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 172
 testRunner.Given("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 173
 testRunner.And("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 174
 testRunner.And("I select \'TAKEN\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 175
 testRunner.And("I have navigated to \'Task Status Screen\' page from \'Call Centre\' top menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 176
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 177
 testRunner.Then("I select \'ONSITE\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 178
 testRunner.When("I search the task number in \'Task Status Screen\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 179
 testRunner.Then("I select \'CANCEL\' from the \'Task Status\' drop down box", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
