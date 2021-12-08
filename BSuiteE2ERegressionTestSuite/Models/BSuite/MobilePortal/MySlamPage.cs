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
    public class MySlamPage
    {
        /// <summary>
        /// Web Driver
        /// </summary>
        public IWebDriver driver { get; set; }
        /// <summary>
        /// Page URL
        /// </summary>
        //public string url = "/mobile?siteSafeCheck=1";

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

        public MySlamPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        /// <summary>
        /// Get Mam Checklist Introduction message
        /// </summary>
        /// <returns></returns>
        public string GetChecklistIntroduction()
        {
            var main_container = this.driver.FindElement(By.ClassName("main-container"));
            var intro_container = main_container.FindElement(By.Id("mySlamFormContainer"));
            List<string> introduction = new List<string>();
            foreach (var element in intro_container.FindElements(By.TagName("div")))
            {
                foreach (var subElement in element.FindElements(By.TagName("div")))
                {
                    if (!string.IsNullOrEmpty(subElement.Text))
                    {
                        if (!introduction.Contains(element.Text)) introduction.Add(element.Text);
                        if (!introduction.Contains(subElement.Text)) introduction.Add(subElement.Text);
                    }
                }
            }
            return introduction[0] + ". " + introduction[2];
        }

        /// <summary>
        /// Get MySlamm Checklist Question
        /// </summary>
        /// <returns></returns>
        public (int questionNumber, string question) GetChecklistQuestion(int questionNumber)
        {
            var actualQuestionNumber = 0;
            var actualQuestion = "";
            
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
            //Get the list of all MySlamm Checklist questions
            var questionSetWrappers = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.Id("mySlamFormContainer")));
            var questionSet = questionSetWrappers[questionNumber+1].FindElement(By.TagName("div"));
            actualQuestionNumber = int.Parse(questionSet.FindElement(By.TagName("span")).Text.Replace(")", ""));
            actualQuestion = questionSet.Text;
            return (actualQuestionNumber, actualQuestion);
        }


        /// <summary>
        /// Respond to all PreStart Checklist questions
        /// </summary>
        /// <param name="userResponse"></param>
        /// <returns></returns>
       

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
