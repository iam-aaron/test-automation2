using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using BSuiteE2ERegressionTest.Models.BSuite.MobilePortal;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace BSuiteE2ERegressionTest
{
     
    
    public sealed partial class StepDefinitions
    {
        [When(@"I am required to select the created task using the task number")]
        [Then(@"I am required to select the created task using the task number")]
        [Given(@"I am required to select the created task using the task number")]


        public void ThenIAmRequiredToSelectTheCreatedTaskUsingTheTaskNumber()
        { 
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();           
            string gblvalue = gblTaskNumber.ToString();
            ICollection<IWebElement> links = webDriver.FindElements(By.XPath("//table[@class='datalist']/tbody/tr/td[2]/a"));
           
            
            foreach(var link in links)
            {
                
                if (link.Text.Contains(gblvalue))
                {
                    link.Click();
                    System.Threading.Thread.Sleep(5000);
                    break;
                }
                
            }
        }

       

        [Then(@"The '([^']*)' Question Of The My Slam Assessment Is Displayed As Follows")]
        public void TheQuestionOfTheMySlamAssessmentIsDisplayedAsFollows(string questionNumber, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var mySlamAssessmentPage = gblOjectContainer.Resolve<MySlamPage>();
            var expectedQuestionNumber = 0;
            var expQuestionNumberStr = table.Rows[0].Values.ToArray()[0].Trim();
            var expQuestionStr = table.Rows[0].Values.ToArray()[1].Trim();
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 1;
                    break;
                case "second":
                    expectedQuestionNumber = 2;
                    break;
                case "third":
                    expectedQuestionNumber = 3;
                    break;
                case "fourth":
                    expectedQuestionNumber = 4;
                    break;
                case "fifth":
                    expectedQuestionNumber = 5;
                    break;
                case "sixth":
                    expectedQuestionNumber = 6;
                    break;
                case "seventh":
                    expectedQuestionNumber = 7;
                    break;
                default:
                    break;
            }

            var questionDetails = GetMyslammQuestion(expectedQuestionNumber);
            if (expectedQuestionNumber >= 7)
            {
                expectedQuestionNumber--;
            }

            Assert.IsTrue(questionDetails.questionNumber == expectedQuestionNumber,
                $"Expected Question Number is [{expectedQuestionNumber}], Actual Question Number is [{questionDetails.questionNumber}].");
            Assert.IsTrue(questionDetails.question.Contains(expQuestionStr),
                $"Expected Question is [{expQuestionStr}], Actual Question is [{questionDetails.question}].");
        }
        [When(@"I respond '([^']*)' to the '([^']*)' My Slam Assessment question")]
        public void WhenIRespondToTheMySlamPageQuestion(string userResponse, string questionNumber)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var mySlamAssessmentPage = gblOjectContainer.Resolve<MySlamPage>();
            var userResponseBool = userResponse.Equals("Yes", StringComparison.InvariantCultureIgnoreCase) ? true : false;
            var expectedQuestionNumber = 0;
            switch (questionNumber)
            {
                case "first":
                    expectedQuestionNumber = 1;
                    break;
                case "second":
                    expectedQuestionNumber = 2;
                    break;
                case "third":
                    expectedQuestionNumber = 3;
                    break;
                case "fourth":
                    expectedQuestionNumber = 4;
                    break;
                case "fifth":
                    expectedQuestionNumber = 5;
                    break;
                case "Sixth":
                    expectedQuestionNumber = 6;
                    break;
                case "seventh":
                    expectedQuestionNumber = 7;
                    break;
                default:
                    break;
            }
           RespondToMySlammChecklistQuestion(userResponseBool,expectedQuestionNumber);

        }

        [Then(@"the Submit button is enabled for MySlamAssessment")]
        public void ThenTheSubmitButtonIsEnabledForMySlamAssessment()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            gblMenuItemSelected = "mobile?siteSafeCheck=1";
            var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Submit"))).elementId;
            var isEnabled = wait.Until(drv => drv.FindElement(By.Id(id)).Enabled);
            Assert.IsTrue(isEnabled, "The element is not enabled.");
            isEnabled.Should().BeTrue(because: "The element is not enabled.");
        }

            public (int questionNumber, string question) GetMyslammQuestion(int questionNumber)
        {
            var actualQuestionNumber = 0;
            var actualQuestion = "";
            questionNumber++;

            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            //Get the list of all MySlamm Checklist questions
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("mySlamFormContainer")));
            var questions = webDriver.FindElements(By.XPath("//div[@id='mySlamFormContainer']/div["+ questionNumber+"]/div"));
             actualQuestionNumber = int.Parse(questions[0].FindElement(By.TagName("span")).Text.Replace(")", ""));
            var actualQuestionText = questions[0].Text;
            

            //var actualQuestionBeforeSplit = actualQuestionText[0].Text;
            var actualQuestionAfterSplit = actualQuestionText.Split(")");
            actualQuestion = actualQuestionAfterSplit[1];
            

            return (actualQuestionNumber, actualQuestion);
        }

        public void RespondToMySlammChecklistQuestion(bool userResponse, int questionNumber)
        {
            questionNumber++;

            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            //Get the list of all MySlamm Checklist questions
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("mySlamFormContainer")));
            var questions = webDriver.FindElements(By.XPath("//div[@id='mySlamFormContainer']/div[" + questionNumber + "]/div"));
            var yesResponseInput = questions[1].FindElement(By.TagName("input"));
            var noResponseInput = questions[2].FindElement(By.TagName("input"));

            if (yesResponseInput.Enabled && noResponseInput.Enabled)
            {
                if (userResponse)
                {
                    yesResponseInput.Click();
                    System.Threading.Thread.Sleep(2000);
                }
                else
                {
                    noResponseInput.Click();
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        public void CompletePreStartChecklist(bool[] userResponses)
        {
            var expNumQuestionsInPreStartChecklist = 4;
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            //Get the PreStart Checklist container
            var preStartChecklistContainer = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("pre-start-container"))).FirstOrDefault();
            var mainContentRepeaterContainer = preStartChecklistContainer.FindElements(By.Id("ctl0_MainContent_Repeater_Container"));
            for (int i = 0; i < expNumQuestionsInPreStartChecklist; i++)
            {
                RespondToMySlammChecklistQuestion(userResponses[i], i);
            }
        }

        [Then(@"I verify the task status as '([^']*)'")]
        public void ThenIVerifyTheTaskStatusAs(string taskStatus)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            gblMenuItemSelected = "mobile?taskstatus=1";
            var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Task Status"))).elementId;
            var actualStatus = webDriver.FindElement(By.XPath(id)).Text;
            Assert.IsTrue(actualStatus.Contains(taskStatus));
        }



    }
}

