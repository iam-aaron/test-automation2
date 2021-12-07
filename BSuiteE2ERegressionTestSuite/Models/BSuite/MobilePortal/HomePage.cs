using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
{
    /// <summary>
    /// Page Object Model for 
    /// https://bsuite.net/ home page
    /// </summary>
    public class HomePage : IPage
    {
        /// <summary>
        /// Web Driver
        /// </summary>
        IWebDriver driver;

        /// <summary>
        /// Items in the Top Menu
        /// </summary>
        ///List<IWebElement> mnuTopMenuItems;

        /// <summary>
        /// User Full Name
        /// </summary>
        IWebElement txtUserFullName;

        /// <summary>
        /// User Role Hyperlink
        /// </summary>
        IWebElement lnkRole;

        /// <summary>
        /// Change Role Drop-Down List
        /// </summary>
        ///IWebElement ddlChangeRole;

        /// <summary>
        /// Change Role Button
        /// </summary>
        ////IWebElement btnChangeRole;

        /// <summary>
        /// Home hyperlink
        /// </summary>
        ///IWebElement lnkHome;

        /// <summary>
        /// Logout hyperlink
        /// </summary>
        IWebElement lnkLogout;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver"></param>
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            try
            {           
                lnkLogout = driver.FindElement(By.XPath("//a[text()='Logout']"));
                txtUserFullName = driver.FindElement(By.XPath("//form[@id='updateTechStatus']/p"));
                lnkRole = driver.FindElement(By.XPath("(//form[@id='updateTechStatus']/p/text())[1]"));
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
            }
        }
        
        public string ValidateLoggedIn()
         {
            try
            {
                this.txtUserFullName = driver.FindElement(By.XPath("//form[@id='updateTechStatus']/p"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
            }
            return this.txtUserFullName.Text;
        }

        /// <summary>
        /// Logout
        /// </summary>
        public void Logout()
        {
            lnkLogout.Click();
        }

        /// <summary>
        /// Get User Current Role
        /// </summary>
        public string GetUserCurrentRole()
        {
            try
            {
                this.lnkRole = driver.FindElement(By.Id("ctl0_ctl2_Role"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
            }
            return this.lnkRole.Text;
        }

        public void SelectMenuLink(string menuItem)
        {
            throw new NotImplementedException();
        }

        public void Home()
        {
            throw new NotImplementedException();
        }

        internal object ChangeRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
