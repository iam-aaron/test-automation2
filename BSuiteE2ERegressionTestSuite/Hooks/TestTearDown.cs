using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;

namespace BSuiteE2ERegressionTest
{
    public sealed partial class StepDefinitions
    {
        [AfterScenario]
        public void AfterScenario()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var testScenarioResult = "PASS";
            var testResultColor = "green";

            if ( gblScenarioContext.TestError == null)
            {
                Metrics.Passed += 1;
                testScenarioResult = "PASS";
            }
            else
            {
                Metrics.Failed += 1;
                testScenarioResult = $"FAIL";
            }
            testResultColor = testScenarioResult.Contains("PASS") ? "green" : "red";

            //gblLogger.Info($"<hr>");
            //gblLogger.Info($"<h1 style=\"color: {testResultColor}\">Test Result: {testScenarioResult}</h1>");
            //if (gblScenarioContext.TestError != null)
            //{
            //    gblLogger.Info($"<p style=\"color: {testResultColor}\">Exception: {gblScenarioContext.TestError.Message}</p>");
            //    gblLogger.Info($"<p style=\"color: {testResultColor}\">Stack Trace: {gblScenarioContext.TestError.StackTrace}</p>");
            //}
            //gblLogger.Info($"<hr>");

            foreach (var tag in gblScenarioContext.ScenarioInfo.Tags)
            {
                if(tag.Contains("PositiveTests")) Metrics.NumberOfPositiveScenarios++;
                if (tag.Contains("NegativeTests")) Metrics.NumberOfNegativeScenarios++;
            }

            Metrics.RegressionTestRunEndTime = DateTime.Now;
            Metrics.RegressionTestRunTotalTime = Metrics.RegressionTestRunEndTime - Metrics.RegressionTestRunStartTime;

            OpenQA.Selenium.ICapabilities caps = ((RemoteWebDriver)webDriver).Capabilities;
            Metrics.BrowserName = caps.GetCapability("browserName").ToString();
            Metrics.BrowserVersion = caps.GetCapability("browserVersion").ToString();
            Metrics.PlatformName = caps.GetCapability("platformName").ToString();
            Console.WriteLine($"Test Run End Date and Time:{DateTime.Now}");
            Console.WriteLine($"Test Run Duration: {Metrics.RegressionTestRunTotalTime.Hours} hours {Metrics.RegressionTestRunTotalTime.Minutes} minutes {Metrics.RegressionTestRunTotalTime.Seconds} seconds {Metrics.RegressionTestRunTotalTime.Milliseconds} milliseconds");
            Console.WriteLine($"Test Environment: {gblConfig.TestEnvName}</p>");
            Console.WriteLine($"Test Run Initiated By: {Metrics.RegressionTestRunInitiatedBy} from computer with hostname: {Metrics.RegressionTestRunInitiatedFrom}</p>");
            Console.WriteLine($"BSuite Application Software Version Tested: {Metrics.BSuiteSoftwareVersion}");
            Console.WriteLine($"Browser Name: {Metrics.BrowserName}");
            Console.WriteLine($"Browser Version: {Metrics.BrowserVersion}");
            Console.WriteLine($"Platform Name: {Metrics.PlatformName}");
            //NLog.LogManager.Shutdown(); // Flush and close down internal threads and timers

            //Logout after executing the scenario block
            try
            {

                if (webDriver.Title.Contains("BSuite on WAP"))
                {
                    webDriver.FindElement(By.LinkText("Logout")).Click();
                }
                else
                {
                    webDriver.FindElement(By.Id("ctl0_ctl3_logout")).Click();
                }

            }
            catch (OpenQA.Selenium.NoSuchElementException e1)
            {
                Console.WriteLine($"Exception: {e1.Message}");
                //Do nothing
            }
            webDriver.Close();
            webDriver.Dispose();
        }

        [AfterStep]
        public void AfterStep()
        {
            var testResultColor = "green";            
            var testStepResult = (gblScenarioContext.StepContext.Status == ScenarioExecutionStatus.OK)
                ? " PASS"
                : $" FAIL";
            testResultColor = testStepResult.Contains("PASS") ? "green" : "red";
            //gblLogger.Info($"<p style=\"color: {testResultColor}\">Test Step Result: {testStepResult}</p>");
            //if (ScenarioStepContext.Current.TestError != null)
            //{
            //    gblLogger.Info($"<p style=\"color: {testResultColor}\">Exception: {gblScenarioContext.StepContext.TestError.Message}</p>");
            //    gblLogger.Info($"<p style=\"color: {testResultColor}\">Stack Trace: {gblScenarioContext.StepContext.TestError.StackTrace}</p>");
            //}
            //gblLogger.Info($"<hr style=\"border:0.25px dashed grey\"/>");
            
            // Capture ScreenShot
            CaptureScreenShot();

            gblTestStepCounter++;
        }

        ///// <summary>
        ///// Assembly Cleanup
        ///// </summary>
        //[AssemblyCleanup()]
        //public void AssemblyCleanup()
        //{

        //}
    }
}
