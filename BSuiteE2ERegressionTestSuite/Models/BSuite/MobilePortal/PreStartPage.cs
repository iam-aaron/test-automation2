using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;



namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
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
            //this.lnkUserFullName = driver.FindElement(By.Id("ctl0_ctl2_userFullName"));
            //this.lnkRole = driver.FindElement(By.Id("ctl0_ctl2_Role"));
            //this.btnSubmit = driver.FindElement(By.Id("ctl0_MainContent_SubmitButton"));
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
            IWebElement actualQuestionList;
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            //Get the list of all PreStart Checklist questions
            var questionSetWrappers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("question-set")));
            var questionSet = questionSetWrappers[questionNumber].FindElement(By.ClassName("ques-text"));
            actualQuestionNumber = int.Parse(questionSet.FindElement(By.ClassName("ques-number")).Text.Replace(".", ""));
            actualQuestionList = questionSet.FindElement(By.ClassName("ques-number"));
            actualQuestion = actualQuestionList.FindElement(By.XPath("following::span")).Text;



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
            IWebElement actualQuestionList;
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));



            //Get the list of all PreStart Checklist questions
            var questionSetWrappers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.ClassName("question-set")));
            var questionSet = questionSetWrappers[questionNumber].FindElement(By.ClassName("ques-text"));
            actualQuestionNumber = int.Parse(questionSet.FindElement(By.ClassName("ques-number")).Text.Replace(".", ""));
            actualQuestionList = questionSet.FindElement(By.ClassName("ques-number"));
            actualQuestion = actualQuestionList.FindElement(By.XPath("following::span")).Text;




            var yesResponseInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("(//div[@class='input-box'])[" + actualQuestionNumber + "]/span[1]/input"))).FirstOrDefault();
            var noResponseInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.XPath("(//div[@class='input-box'])[" + actualQuestionNumber + "]/span[2]/input"))).FirstOrDefault();




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
            var expNumQuestionsInPreStartChecklist = 5;
            for (int i = 0; i < expNumQuestionsInPreStartChecklist; i++)
            {
                RespondToPreStartChecklistQuestion(userResponses[i], i);
            }



        }



        public void validatePromptMessage(int promptNo, string expQuestionStr)
        {
            string alertMessage = this.driver.FindElement(By.XPath("//div[@class='stop-alert-section']/div/span")).Text;
            Assert.IsTrue(alertMessage.Equals(expQuestionStr));
        }



        /// <summary>
        /// Click the Submit button
        /// </summary>
        public void Submit()
        {
            this.btnSubmit = driver.FindElement(By.Id("ctl0_MainContent_SubmitButton"));
            this.btnSubmit.Click();
        }



        ///// <summary>
        ///// Complete PreStart Checklist
        ///// </summary>
        //public (string introduction, string[] questions) CompletePreStartChecklist(bool[] responses)
        //{
        //}
    }
}
