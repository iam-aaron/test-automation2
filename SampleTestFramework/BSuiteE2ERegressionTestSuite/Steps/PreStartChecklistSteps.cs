using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal;
using FluentAssertions;
using NUnit.Framework;

namespace BSuiteE2ERegressionTest
{
    public sealed partial class StepDefinitions
    {
        [Then(@"I am required to complete the Pre Start Checklist for the day")]
        public void ThenIAmRequiredToCompleteThePreStartChecklistForTheDay()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url.Should().Contain(gblConfig.BSuiteURL + "/prestart");
            //Add PreStart Checklist page to the container
            var preStartChecklistPage = new PreStartPage(webDriver);
            gblCurrentPage = preStartChecklistPage;

            //Verify that PreStart Checklist introductin is set as expected
            //Assert.AreEqual(expected: $"Good morning {preStartChecklistPage.lnkUserFullName.Text}. Lets complete your Pre Start Checklist for today {DateTime.Now.ToString($"dd'{GenerateDateSuffix()} 'MMMM yyyy")}",
             //  actual: preStartChecklistPage.GetChecklistIntroduction(),
             //  message: "FAILED: PreStart Checklist introduction message is not as expected");

            gblMenuItemSelected = UIMap.UIPageMap["PreStart"].resourceName;
        }
                       
        [Then(@"the '([^']*)' question of the Pre Start Checklist is displayed as follows")]
        public void ThenTheQuestionOfThePreStartChecklistIsDisplayedAsFollows(string questionNumber, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var preStartChecklistPage = gblOjectContainer.Resolve<PreStartPage>();
            var expectedQuestionNumber = 0;
            var expQuestionNumberStr = table.Rows[0].Values.ToArray()[0].Trim();
            var expQuestionStr = table.Rows[0].Values.ToArray()[1].Trim();
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 0;
                    break;
                case "second":
                    expectedQuestionNumber = 1;
                    break;
                case "third":
                    expectedQuestionNumber = 2;
                    break;
                case "fourth":
                    expectedQuestionNumber = 3;
                    break;
                case "fifth":
                    expectedQuestionNumber = 4;
                    break;
                case "sixth":
                    expectedQuestionNumber = 5;
                    break;
                default:
                    break;
            }

            var questionDetails = preStartChecklistPage.GetChecklistQuestion(expectedQuestionNumber);

            Assert.IsTrue(questionDetails.questionNumber == expectedQuestionNumber + 1,
                $"Expected Question Number is [{expectedQuestionNumber + 1}], Actual Question Number is [{questionDetails.questionNumber}].");
            Assert.IsTrue(questionDetails.question.Equals(expQuestionStr),
                $"Expected Question is [{expQuestionStr}], Actual Question is [{questionDetails.question}].");
        }

        [Given(@"the '([^']*)' question of the Pre Start Checklist is displayed as follows in mobile portal")]
        [When(@"the '([^']*)' question of the Pre Start Checklist is displayed as follows in mobile portal")]
        [Then(@"the '([^']*)' question of the Pre Start Checklist is displayed as follows in mobile portal")]
        public void ThenTheQuestionOfThePreStartChecklistIsDisplayedAsFollowsInMobilePortal(string questionNumber, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var preStartChecklistPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage>();
            var expectedQuestionNumber = 0;
            var expQuestionNumberStr = table.Rows[0].Values.ToArray()[0].Trim();
            var expQuestionStr = table.Rows[0].Values.ToArray()[1].Trim();
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 0;
                    break;
                case "second":
                    expectedQuestionNumber = 1;
                    break;
                case "third":
                    expectedQuestionNumber = 2;
                    break;
                case "fourth":
                    expectedQuestionNumber = 3;
                    break;
                case "fifth":
                    expectedQuestionNumber = 4;
                    break;
                default:
                    break;
            }

            var questionDetails = preStartChecklistPage.GetChecklistQuestion(expectedQuestionNumber);

            Assert.IsTrue(questionDetails.questionNumber == expectedQuestionNumber + 1,
                $"Expected Question Number is [{expectedQuestionNumber + 1}], Actual Question Number is [{questionDetails.questionNumber}].");
            Assert.IsTrue(questionDetails.question.Equals(expQuestionStr),
                $"Expected Question is [{expQuestionStr}], Actual Question is [{questionDetails.question}].");
        }

        [When(@"I respond '([^']*)' to the '([^']*)' Pre Start Checklist question in mobile portal")]
        public void WhenIRespondToThePreStartChecklistQuestionInMobilePortal(string userResponse, string questionNumber)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var preStartChecklistPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage>();
            var userResponseBool = userResponse.Equals("Yes", StringComparison.InvariantCultureIgnoreCase) ? true : false;
            var expectedQuestionNumber = 0;
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 0;
                    break;
                case "second":
                    expectedQuestionNumber = 1;
                    break;
                case "third":
                    expectedQuestionNumber = 2;
                    break;
                case "fourth":
                    expectedQuestionNumber = 3;
                    break;
                case "fifth":
                    expectedQuestionNumber = 4;
                    break;
                default:
                    break;
            }
            preStartChecklistPage.RespondToPreStartChecklistQuestion(userResponseBool, expectedQuestionNumber);
        }


        [When(@"I respond '([^']*)' to the '([^']*)' Pre Start Checklist question")]
        [Then(@"I respond '([^']*)' to the '([^']*)' Pre Start Checklist question")]
        [Given(@"I respond '([^']*)' to the '([^']*)' Pre Start Checklist question")]
        public void WhenIRespondToThePreStartChecklistQuestion(string userResponse, string questionNumber)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var preStartChecklistPage = gblOjectContainer.Resolve<PreStartPage>();
            var userResponseBool = userResponse.Equals("Yes", StringComparison.InvariantCultureIgnoreCase) ? true : false;
            var expectedQuestionNumber = 0;
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 0;
                    break;
                case "second":
                    expectedQuestionNumber = 1;
                    break;
                case "third":
                    expectedQuestionNumber = 2;
                    break;
                case "fourth":
                    expectedQuestionNumber = 3;
                    break;
                case "fifth":
                    expectedQuestionNumber = 4;
                    break;
                case "sixth":
                    expectedQuestionNumber = 5;
                    break;
                default:
                    break;
            }
            preStartChecklistPage.RespondToPreStartChecklistQuestion(userResponseBool, expectedQuestionNumber);

        }
        
        [Then(@"'([^']*)' prompt message is displayed to contact Supervisor as follows")]
        public void ThenAPromptIsDisplayedToContactSupervisor(string promptNum, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var noToChecklistQuestion = gblOjectContainer.Resolve<PreStartPage>();
            var promptNo = 0;
            switch (promptNum)
            {
                case "first":
                    promptNo = 1;
                    break;
                case "second":
                    promptNo = 2;
                    break;
                case "third":
                    promptNo = 3;
                    break;
                case "fourth":
                    promptNo = 4;
                    break;
                case "fifth":
                    promptNo = 5;
                    break;
                default:
                    break;
            }
            var expPromtStr = table.Rows[0].Values.ToArray()[0].Trim();

            noToChecklistQuestion.validatePromptMessage(promptNo, expPromtStr);

        }

        [When(@"data is enterered for the '([^']*)' question in that prompt after he has contacted the Supervisor")]
        public void WhenDataIsEntereredForTheQuestionInThatPromptAfterHeHasContactedTheSupervisor(string questionNumber)
        {
            var promptAlertNumber = 0;
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            switch (questionNumber)
            {
                case "first":
                    promptAlertNumber = 0;
                    break;
                case "second":
                    promptAlertNumber = 1;
                    break;
                case "third":
                    promptAlertNumber = 2;
                    break;
                case "fourth":
                    promptAlertNumber = 3;
                    break;
                case "fifth":
                    promptAlertNumber = 4;
                    break;
                default:
                    break;
            }

            webDriver.FindElement(By.Id("ctl0_MainContent_Repeater_ctl" + promptAlertNumber + "_confirmcheck")).Click();
            System.Threading.Thread.Sleep(5000);
        }

        [Given(@"I am required to complete the Pre Start Checklist for the day in mobile portal")]        
        [Then(@"I am required to complete the Pre Start Checklist for the day in mobile portal")]
        [When(@"I am required to complete the Pre Start Checklist for the day in mobile portal")]
        [Given(@"I am required to complete the Pre Start Checklist for the day in mobile portal")]
        public void ThenIAmRequiredToCompleteThePreStartChecklistForTheDayInMobilePortal()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url.Should().Contain(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList");
            //Add PreStart Checklist page to the container
            var preStartChecklistPage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage(webDriver);
            gblCurrentPage = preStartChecklistPage;

        }



        [Then(@"the Submit button is enabled")]
        public void ThenTheSubmitButtonIsEnabled()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Submit"))).elementId;
            var isEnabled = wait.Until(drv => drv.FindElement(By.Id(id)).Enabled);
            Assert.IsTrue(isEnabled, "The element is not enabled.");
            isEnabled.Should().BeTrue(because: "The element is not enabled.");
        }       

        [Then(@"'([^']*)' prompt message is displayed to contact Supervisor as follows in mobile portal")]
        public void ThenAPromptIsDisplayedToContactSupervisorInMobilePortal(string promptNum, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var noToChecklistQuestion = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage>();
            var promptNo = 0;
            switch (promptNum)
            {
                case "first":
                    promptNo = 1;
                    break;
                case "second":
                    promptNo = 2;
                    break;
                case "third":
                    promptNo = 3;
                    break;
                case "fourth":
                    promptNo = 4;
                    break;
                default:
                    break;
            }
            var expPromtStr = table.Rows[0].Values.ToArray()[0].Trim();
            noToChecklistQuestion.validatePromptMessage(promptNo, expPromtStr);
        }     

        [When(@"I check the Confirm Customer Operations Manager contacted check box for '([^']*)' no response")]
        public void WhenICheckTheConfirmCustomerOperationsManagerContactedCheckBoxForNoResponse(string responseNumber)
        {
            int expectedResponseNumber = 0;
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            switch (responseNumber)
            {
                case "first":
                    expectedResponseNumber = 1;
                    break;
                case "second":
                    expectedResponseNumber = 2;
                    break;
                case "third":
                    expectedResponseNumber = 3;
                    break;
                case "fourth":
                    expectedResponseNumber = 4;
                    break;
                case "fifth":
                    expectedResponseNumber = 5;
                    break;
                default:
                    break;
            }
            webDriver.FindElement(By.Id("contact_" + expectedResponseNumber)).Click();
            System.Threading.Thread.Sleep(2000);
        }


    }
}
