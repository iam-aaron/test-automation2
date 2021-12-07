using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal
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
        List<IWebElement> mnuTopMenuItems;

        /// <summary>
        /// User Full Name
        /// </summary>
        IWebElement lnkUserFullName;

        /// <summary>
        /// User Role Hyperlink
        /// </summary>
        IWebElement lnkRole;

        /// <summary>
        /// Change Role Drop-Down List
        /// </summary>
        IWebElement ddlChangeRole;

        /// <summary>
        /// Change Role Button
        /// </summary>
        IWebElement btnChangeRole;

        /// <summary>
        /// Home hyperlink
        /// </summary>
        IWebElement lnkHome;

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
                mnuTopMenuItems = driver.FindElements(By.XPath("//*[@id=\"ctl0_ctl3_DynamicMenu\"]/ul/li/a")).ToList();
                lnkHome = driver.FindElement(By.XPath("/html/body/form/div[2]/div[2]/div[3]/ul/li[1]/a"));
                lnkLogout = driver.FindElement(By.Id("ctl0_ctl3_logout"));
                lnkUserFullName = driver.FindElement(By.Id("ctl0_ctl2_userFullName"));
                lnkRole = driver.FindElement(By.Id("ctl0_ctl2_Role"));
                ddlChangeRole = driver.FindElement(By.Id("ctl0_MainContent_changeRole_userAccountRoles"));
                btnChangeRole = driver.FindElement(By.Id("ctl0_MainContent_changeRole_userAccountChangeRole"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
            }
        }
        
        /// <summary>
        /// Select Menu Item
        /// </summary>
        public void SelectMenuLink(string menuItem)
        {
            mnuTopMenuItems.Single(s => s.Text.Contains(menuItem)).Click();
        }

        /// <summary>
        /// Home
        /// </summary>
        public void Home()
        {
            lnkHome.Click();
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
                return this.lnkRole.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
                return string.Empty;
            }
        }

        /// <summary>
        /// Get Allotted Roles for User
        /// </summary>
        public List<string> GetAllottedRolesForUser()
        {
            var allottedRolesForUser = new List<string>();
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(this.ddlChangeRole);
            foreach (IWebElement element in selectElement.Options)
            {
                allottedRolesForUser.Add(element.Text);
            }
            return allottedRolesForUser;
        }

        /// <summary>
        /// Change Role if required from Home Page if PreStart Checklist is NOT presented
        /// </summary>
        /// <param name="desiredRole"></param>
        /// <returns></returns>
        public (string role, bool isSuccess) ChangeRole(string desiredRole)
        {
            bool isSuccess = false;
            var userCurrentRole = this.GetUserCurrentRole();
            if (!string.IsNullOrEmpty(userCurrentRole) && !userCurrentRole.Equals("[" + desiredRole + "]"))
            {
                if (this.GetAllottedRolesForUser().Contains(desiredRole))
                {
                    //Select the desired role from the Drop-Down List
                    var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(this.ddlChangeRole);
                    foreach (IWebElement element in selectElement.Options)
                    {
                        if (element.Text.Equals(desiredRole))
                        {
                            element.Click();
                            break;
                        }
                    }
                    //Click the Change Role button
                    this.btnChangeRole.Click();
                    System.Threading.Thread.Sleep(5000);
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            else
            {
                isSuccess = true;
            }

            try
            {
                this.lnkRole = this.driver.FindElement(By.Id("ctl0_ctl2_Role"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.StackTrace}");
            }

            return (lnkRole.Text, isSuccess);
        }
    }
}
