using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace BSuiteE2ERegressionTest
{
    [Binding]
    public sealed partial class StepDefinitions : TechTalk.SpecFlow.Steps
    {
        public readonly IObjectContainer gblOjectContainer;
        public readonly TechTalk.SpecFlow.ScenarioContext gblScenarioContext;
        public readonly TechTalk.SpecFlow.FeatureContext gblFeatureContext;

        public StepDefinitions(IObjectContainer _objectContainer, FeatureContext _featureContext, ScenarioContext _scenarioContext)
        {
            this.gblOjectContainer = _objectContainer;
            this.gblFeatureContext = _featureContext;
            this.gblScenarioContext = _scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //Load test framework configuration settings for the current test run
            gblConfig = new Config();
            gblConfig.LoadConfig();

            //TODO: Load test data for the current test run
            //LoadTestData();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            gblTestStepCounter = 0;
            //Start the web driver
            var webDriver = SetupWebDriver();
            //Add Selenium web driver to the container,
            //so that binding classes can specify IWebDriver dependencies
            //(a constructor argument of type IWebDriver).
            gblOjectContainer.RegisterInstanceAs<OpenQA.Selenium.IWebDriver>(webDriver);
        }

        [BeforeStep]
        public void BeforeStep()
        {
            if (gblTestStepCounter == 0)
            {
                foreach (var tag in gblScenarioContext.ScenarioInfo.Tags)
                {
                    if (tag.Contains("BSUITE-"))
                    {
                        gblTestCaseId = tag;
                        break;
                    }
                }

                //Configure NLog Targets for output
                //ConfigureLogger();

                //Console.Write($"Testcase: {gblTestCaseId}");
                //gblLogger.Info($"<h1 style=\"color: blue\">Testcase: {gblTestCaseId}</h1>");
                //gblLogger.Info($"<h2>Feature Title: {gblFeatureContext.FeatureInfo.Title}</h1>");
                //gblLogger.Info($"<h3>Feature Description:</h3>");
                //gblLogger.Info($"<p>{gblFeatureContext.FeatureInfo.Description.Replace(System.Environment.NewLine, "<br>")}</p>");
                //gblLogger.Info($"<h2>Scenario Title: {gblScenarioContext.ScenarioInfo.Title}</h1>");
                //gblLogger.Info($"<p>Test Run Start Date and Time: {Metrics.RegressionTestRunStartTime}<p>");
                //gblLogger.Info($"<hr>");              
            }
            
            //switch (gblScenarioContext.StepContext.StepInfo.StepDefinitionType)
            //{
            //    case StepDefinitionType.Given:
            //        Console.WriteLine($"Test Step: Given {gblScenarioContext.StepContext.StepInfo.Text}.</h3>");
            //        break;
            //    case StepDefinitionType.When:
            //        gblLogger.Info($"<h3>Test Step: When {gblScenarioContext.StepContext.StepInfo.Text}</h3>");
            //        break;
            //    case StepDefinitionType.Then:
            //        gblLogger.Info($"<h3>Test Step: Then {gblScenarioContext.StepContext.StepInfo.Text}</h3>");
            //        break;
            //    default:
            //        break;
            //}
            //var testStepTable = gblScenarioContext.StepContext.StepInfo.Table;
            //if (testStepTable != null)
            //{
            //    gblLogger.Info($"<table style=\"width: 100 % \">");
            //    gblLogger.Info($"<tr>");
            //    for (int i = 0; i < testStepTable.Rows.FirstOrDefault().Keys.Count; i++)
            //    {
            //        gblLogger.Info($"<th> {testStepTable.Rows.FirstOrDefault().Keys.ToList()[i]} </th>");
            //    }
            //    foreach (var row in testStepTable.Rows)
            //    {
            //        gblLogger.Info($"<tr>");
            //        for (int j = 0; j < row.Keys.Count; j++)
            //        {
            //            gblLogger.Info($"<td>{row.Skip(j).FirstOrDefault().Value}</td> ");
            //        }
            //        gblLogger.Info($"</tr>");
            //    }
            //    gblLogger.Info($"</tr>");
            //    gblLogger.Info($"</table>");
            //}
        }
    }
}
