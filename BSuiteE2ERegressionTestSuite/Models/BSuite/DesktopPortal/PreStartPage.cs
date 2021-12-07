using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;

namespace BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal
{
    public class PreStartPage
    {
        /// <summary>
        /// Web Driver
        /// </summary>
        public IWebDriver driver { get; set; }
        /// <summary>
        /// Page URL
        /// </summary>
        public string url = "/prestart";

        /// <summary>
        /// User Full Name
        /// </summary>
        public IWebElement lnkUserFullName;

        /// <summary>
        /// User Role Hyperlink
        /// </summary>
        public IWebElement lnkRole;

        /// <summary>
        /// Submit button
        /// </summary>
        public IWebElement btnSubmit;

        public PreStartPage(IWebDriver driver)
        {
            this.driver = driver;
            this.lnkUserFullName = driver.FindElement(By.Id("ctl0_ctl2_userFullName"));
            this.lnkRole = driver.FindElement(By.Id("ctl0_ctl2_Role"));
            this.btnSubmit = driver.FindElement(By.Id("ctl0_MainContent_SubmitButton"));
        }

        /// <summary>
        /// Get PreStart Checklist Introduction message
        /// </summary>
        /// <returns></returns>
        public string GetChecklistIntroduction()
        {
            var main_container = this.driver.FindElement(By.ClassName("main-container"));
            var intro_container = main_container.FindElement(By.ClassName("introduction-container"));
            List<string> introduction = new List<string>();
            foreach (var element in intro_container.FindElements(By.TagName("span")))
            {
                foreach (var subElement in element.FindElements(By.TagName("span")))
                {
                    if (!string.IsNullOrEmpty(subElement.Text))
                    {
                        if(!introduction.Contains(element.Text)) introduction.Add(element.Text);
                        if (!introduction.Contains(subElement.Text)) introduction.Add(subElement.Text);
                    }
                }
            }
            return introduction[0] + ". " + introduction[2];
        }

        /// <summary>
        /// Get PreStart Checklist Question
        /// </summary>
        /// <returns></returns>
        public (int questionNumber, string question) GetChecklistQuestion(int questionNumber)
        {
            var actualQuestionNumber = 0;
            var actualQuestion = "";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            //Get the PreStart Checklist container
            var preStartChecklistContainer = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("pre-start-container"))).FirstOrDefault();
            var mainContentRepeaterContainer = preStartChecklistContainer.FindElements(By.Id("ctl0_MainContent_Repeater_Container"));

            //Get the list of all PreStart Checklist questions
            var questionSetWrappers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("question-set-wrapper")));
            var questionSet = questionSetWrappers[questionNumber].FindElement(By.ClassName("question-set"));
            var questionText = questionSet.FindElement(By.ClassName("ques-text"));
            actualQuestionNumber = int.Parse(questionText.FindElement(By.ClassName("ques-number")).Text.Replace(".", ""));
            actualQuestion = questionText.FindElement(By.Id($"ctl0_MainContent_Repeater_ctl{questionNumber}_ques")).Text;
            //for (int i = (questionNumber-1); i < questionSetWrappers.Count; i++)
            //{
            //    //Parse each PreStart question set
            //    var questionSet = questionSetWrappers.Skip(i).FirstOrDefault().FindElement(By.ClassName("question-set"));
            //    var questionText = questionSet.FindElement(By.ClassName("ques-text"));
            //    actualQuestionNumber = int.Parse(questionText.FindElement(By.ClassName("ques-number")).Text.Replace(".", ""));
            //    actualQuestion = questionText.FindElement(By.Id($"ctl0_MainContent_Repeater_ctl{i}_ques")).Text;
            //    //var stopAlertSection = questionSet.FindElement(By.ClassName("stop-alert-section"));
            //    //var alertMessage = stopAlertSection.FindElement(By.ClassName("alert-message"));
            //    //var alertMessageSentences = alertMessage.FindElements(By.TagName("span"));
            //}
            return (actualQuestionNumber, actualQuestion);
        }

        /// <summary>
        /// Respond to a PreStart Checklist question
        /// </summary>
        /// <param name="userResponse"></param>
        /// <returns></returns>
        public void RespondToPreStartChecklistQuestion(bool userResponse, int questionNumber)
        {
            var actualQuestionNumber = 0;
            var actualQuestion = "";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            //Get the PreStart Checklist container
            var preStartChecklistContainer = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("pre-start-container"))).FirstOrDefault();
            var mainContentRepeaterContainer = preStartChecklistContainer.FindElements(By.Id("ctl0_MainContent_Repeater_Container"));

            //Get the list of all PreStart Checklist questions
            var questionSetWrappers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("question-set-wrapper")));
            //Parse each PreStart question set
            var questionSet = questionSetWrappers.Skip(questionNumber).FirstOrDefault().FindElement(By.ClassName("question-set"));
            var questionText = questionSet.FindElement(By.ClassName("ques-text"));
            actualQuestionNumber = int.Parse(questionText.FindElement(By.ClassName("ques-number")).Text.Replace(".", ""));
            actualQuestion = questionText.FindElement(By.Id($"ctl0_MainContent_Repeater_ctl{questionNumber}_ques")).Text;
            var yesResponseInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id($"ctl0_MainContent_Repeater_ctl{questionNumber}_yes"))).FirstOrDefault();
            var noResponseInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id($"ctl0_MainContent_Repeater_ctl{questionNumber}_no"))).FirstOrDefault();
            //var stopAlertSection = questionSet.FindElement(By.ClassName("stop-alert-section"));
            //var alertMessage = stopAlertSection.FindElement(By.ClassName("alert-message"));
            //var alertMessageSentences = alertMessage.FindElements(By.TagName("span"));

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

        /// <summary>
        /// Respond to all PreStart Checklist questions
        /// </summary>
        /// <param name="userResponse"></param>
        /// <returns></returns>
        public void CompletePreStartChecklist(bool[] userResponses)
        {
            var expNumQuestionsInPreStartChecklist = 4;
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            //Get the PreStart Checklist container
            var preStartChecklistContainer = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("pre-start-container"))).FirstOrDefault();
            var mainContentRepeaterContainer = preStartChecklistContainer.FindElements(By.Id("ctl0_MainContent_Repeater_Container"));         
            for(int i=0;i<expNumQuestionsInPreStartChecklist;i++)
            {
                RespondToPreStartChecklistQuestion(userResponses[i], i);
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void validatePromptMessage(int promptNo, string expQuestionStr)
        {
            //string alertMessage = driver.FindElement(By.XPath("//div[@class='alert-message']/span[" + promptNo + "]")).Text;
            var alertMessage = driver.FindElements(By.XPath("(//div[@class='stop-alert-section'])[" + promptNo +"]")).ToList();
            foreach (var alert in alertMessage)
            {
                var alertMsg = alert.FindElement(By.TagName("span"));
                string Msg = alertMsg.FindElement(By.TagName("span")).Text;
                Assert.IsTrue(Msg.Equals(expQuestionStr));
                break;
            }
            
        }

        /// <summary>
        /// Click the Submit button
        /// </summary>
        public void Submit()
        {
            this.btnSubmit = driver.FindElement(By.Id("ctl0_MainContent_SubmitButton"));
            this.btnSubmit.Click();
            System.Threading.Thread.Sleep(2000);
        }

        ///// <summary>
        ///// Complete PreStart Checklist
        ///// </summary>
        //public (string introduction, string[] questions) CompletePreStartChecklist(bool[] responses)
        //{
        //    var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
        //    //If PreStart Checklist is presented, then complete PreStart Checklist as per Happy Path
        //    var preStartChecklistPage = new PreStartPage(webDriver);
        //    gblCurrentPage = preStartChecklistPage;
        //    var preStartChecklistIntroduction = preStartChecklistPage.GetChecklistIntroduction();
        //    var preStartChecklistQuestions = preStartChecklistPage.GetChecklistQuestions(responses);
        //    Assert.AreEqual(expected: $"Good morning {preStartChecklistPage.lnkUserFullName.Text}. Lets complete your Pre Start Checklist for today {DateTime.Now.ToString($"dd'{GenerateDateSuffix()} 'MMMM yyyy")}",
        //        actual: preStartChecklistPage.GetChecklistIntroduction(),
        //        message: "FAILED: PreStart Checklist introduction message is not as expected");
        //    return (introduction: preStartChecklistIntroduction);
        //}
    }
}
