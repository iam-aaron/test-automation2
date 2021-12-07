using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
{
    /// <summary>
    /// Page Object Model for 
    /// https://bsuite.net/login
    /// </summary>
    public class LoginPage
    {
        ///// <summary>
        ///// Web Driver
        ///// </summary>
        IWebDriver driver { set; get; }
        /// <summary>
        /// Username textbox
        /// </summary>
        IWebElement TxtBoxUsername { set; get; }
        /// <summary>
        /// Password textbox
        /// </summary>
        IWebElement TxtBoxPassword { set; get; }
        /// <summary>
        /// Login button
        /// </summary>
        IWebElement BtnLogin { set; get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            //txtBoxUsername = this.driver.FindElement(By.XPath($"//*[@id=\"ctl0_MainContent_username\"]"));
            TxtBoxUsername = driver.FindElement(By.Name("username"));
            //txtBoxPassword = this.driver.FindElement(By.XPath($"//*[@id=\"ctl0_MainContent_password\"]"));
            TxtBoxPassword = driver.FindElement(By.Name("password"));
            //btnLogin = this.driver.FindElement(By.XPath($"//*[@id=\"ctl0_MainContent_ctl4\"]"));
            BtnLogin = driver.FindElement(By.XPath("//input[@value='Login']"));
            //btnForgotPassword = driver.FindElement(By.XPath($"//*[@id=\"ctl0_MainContent_mainLoginPanel\"]/table/tbody/tr[4]/td/div/input[2]"));
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void Login(string username, string password)
        {
            TxtBoxUsername = driver.FindElement(By.Name("username"));
            TxtBoxPassword = driver.FindElement(By.Name("password"));
            BtnLogin = driver.FindElement(By.XPath("//input[@value='Login']"));
            //Enter User Name
            TxtBoxUsername.Click();
            if(TxtBoxUsername.Enabled)
            {
                TxtBoxUsername.SendKeys(username);
            }
            //Enter Password
            TxtBoxPassword.Click();
            if (TxtBoxPassword.Enabled)
            {
                TxtBoxPassword.SendKeys(password);
            }
            //Click Login button
            BtnLogin.Click();
            System.Threading.Thread.Sleep(2000);
        }
    }
}
