using BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Linq;
using TechTalk.SpecFlow;
using FluentAssertions;
using NUnit.Framework;

namespace BSuiteE2ERegressionTest
{
    public sealed partial class StepDefinitions
    {
        [Given(@"I have opened the BSuite Desktop Portal")]
        [When(@"I have opened the BSuite Desktop Portal")]
        [Then(@"I have opened the BSuite Desktop Portal")]
        public void GivenIHaveOpenedTheBSuiteDesktopPortal()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = gblConfig.BSuiteURL;
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Title.Contains("BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains("BSuite", StringComparison.InvariantCultureIgnoreCase));
            //Add Login Page to the container, if not already registered.
            if (!gblOjectContainer.IsRegistered<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>())
            {
                var loginPage = new BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>(loginPage);
            }
            gblCurrentPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>();
        }


        [Given(@"I have opened the BSuite Mobile Portal")]
        [When(@"I have opened the BSuite Mobile Portal")]
        [Then(@"I have opened the BSuite Mobile Portal")]
        public void GivenIHaveOpenedTheBSuiteMobilePortal()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = gblConfig.BSuiteURL + "/mobile";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(50));
            wait.Until(localDriver => localDriver.Title.Contains("BSuite", StringComparison.InvariantCultureIgnoreCase));
            //Add Login Page to the container
            //Add Login Page to the container, if not already registered.
            if (!gblOjectContainer.IsRegistered<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>())
            {
                var loginPage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>(loginPage);
            }
            gblCurrentPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
        }

        [When(@"I login as a User with User Profile as follows")]
        [Given(@"I login as a User with User Profile as follows")]

        public void WhenILoginAsAUserWithUserProfileAsFollows(Table userProfile)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            //var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
            if (webDriver.Title.Contains("BSuite on WAP"))
            {
                var loginPageMobile = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
            }
            else
            {
                var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>();
            }

            var role = userProfile.Rows[0].Values.ToArray()[0].Trim();
            var username = userProfile.Rows[0].Values.ToArray()[1].Trim();
            var password = userProfile.Rows[0].Values.ToArray()[2].Trim();
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            Login(username, password, role);
        }

        [Given(@"I login as a User with role '([^']*)'")]
        [When(@"I login as a User with role '([^']*)'")]
        [Then(@"I login as a User with role '([^']*)'")]
        public void WhenILoginAsAUserWithRole(string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<LoginPage>();
            var username = gblConfig.Users[role].UserName;
            var password = gblConfig.Users[role].UserPassword;
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            Login(username, password, role);
        }

        [Given(@"login is successful")]
        [Then(@"login is successful")]
        [When(@"login is successful")]
        public void ThenLoginIsSuccessful()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            if (webDriver.Title.Contains("BSuite on WAP"))
            {
                if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase))
                {
                    Assert.IsTrue(webDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase));
                }
                else
                {
                    var homePageMobile = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage>();
                    Assert.IsTrue(homePageMobile.ValidateLoggedIn().Contains("Logged in"));
                }
            }
            else
            {
                var homePage = gblOjectContainer.Resolve<HomePage>();
                Assert.IsTrue(webDriver.Title.Contains("Home - BSuite", StringComparison.InvariantCultureIgnoreCase));
                var userCurrentRole = homePage.GetUserCurrentRole();
                Assert.IsTrue(userCurrentRole.Equals("[" + gblCurrentUser.Role + "]"));
                Metrics.BSuiteSoftwareVersion = webDriver.Title.Replace("Home - BSuite - ", "");
            }

        }

        [Given(@"I have logged into '([^']*)' portal as a User with following User Profile")]
        [When(@"I have logged into '([^']*)' portal as a User with following User Profile")]
        public void GivenIHaveLoggedIntoPortalAsAUserWithFollowingUserProfile(string bsuitePortal, Table userProfile)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            if (bsuitePortal.Equals("BSuite Desktop"))
            {
                GivenIHaveOpenedTheBSuiteDesktopPortal();
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>();
                var role = userProfile.Rows[0].Values.ToArray()[0].Trim();
                var username = userProfile.Rows[0].Values.ToArray()[1].Trim();
                var password = userProfile.Rows[0].Values.ToArray()[2].Trim();
                gblCurrentUser.UserName = username;
                gblCurrentUser.Password = password;
                gblCurrentUser.Role = role;
                LoginForTheFirstTIme(username, password, role);
                //WhenILoginAsAUserWithUserProfileAsFollows(userProfile);
                ThenLoginIsSuccessful();
            }
            else if (bsuitePortal.Equals("BSuite Mobile"))
            {
                GivenIHaveOpenedTheBSuiteMobilePortal();
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
                var role = userProfile.Rows[0].Values.ToArray()[0].Trim();
                var username = userProfile.Rows[0].Values.ToArray()[1].Trim();
                var password = userProfile.Rows[0].Values.ToArray()[2].Trim();
                gblCurrentUser.UserName = username;
                gblCurrentUser.Password = password;
                gblCurrentUser.Role = role;
                LoginForTheFirstTImeInMobile(username, password, role);
            }
        }

        [When(@"I login as a User with role '([^']*)' for the first time in a day")]
        [Given(@"I login as a User with role '([^']*)' for the first time in a day")]
        [Then(@"I login as a User with role '([^']*)' for the first time in a day")]
        public void WhenILoginAsAUserWithRoleForTheFirstTimeInADay(string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<LoginPage>();
            var username = gblConfig.Users[role].UserName;
            var password = gblConfig.Users[role].UserPassword;
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            LoginForTheFirstTIme(username, password, role);
        }

        [Given(@"I login as a User for the first time in a day with user details as follows")]
        public void GivenILoginAsAUserForTheFirstTimeInADayWithUserDetailsAsFollows(Table userProfile)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            //var loginPage = gblOjectContainer.Resolve<LoginPage>();
            //var username = gblConfig.Users[role].UserName;
            //var password = gblConfig.Users[role].UserPassword;
            if (webDriver.Title.Contains("BSuite on WAP"))
            {
                var loginPageMobile = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
            }
            else
            {
                var loginPage = gblOjectContainer.Resolve<LoginPage>();
            }

            var role = userProfile.Rows[0].Values.ToArray()[0].Trim();
            var username = userProfile.Rows[0].Values.ToArray()[1].Trim();
            var password = userProfile.Rows[0].Values.ToArray()[2].Trim();
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            LoginForTheFirstTIme(username, password, role);
        }

        [When(@"I login as a User with role '([^']*)' for the first time in a day in mobile portal")]
        [Then(@"I login as a User with role '([^']*)' for the first time in a day in mobile portal")]
        [Given(@"I login as a User with role '([^']*)' for the first time in a day in mobile portal")]
        public void WhenILoginAsAUserWithRoleForTheFirstTimeInADayInMobilePortal(string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
            var username = gblConfig.Users[role].UserName;
            var password = gblConfig.Users[role].UserPassword;
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            LoginForTheFirstTImeInMobile(username, password, role);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        public void Login(string username, string password, string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            if (webDriver.Title.Contains("BSuite on WAP"))
            {
                var loginPageMobile = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
                loginPageMobile.Login(username, password);
            }
            else
            {
                var loginPage = gblOjectContainer.Resolve<LoginPage>();
                loginPage.Login(username, password);
                wait.Until(localDriver =>
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/prestart", StringComparison.InvariantCultureIgnoreCase) ||
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))));
            }


            //If PreStart Checklist is NOT presented, change user role to the desired role
            if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add HomePage to the container
                var homePage = new HomePage(webDriver);
                gblOjectContainer.RegisterInstanceAs<HomePage>(homePage);
                Assert.IsTrue(homePage.ChangeRole(role).isSuccess, $"Error: The User {gblCurrentUser.UserName} does not have the role {gblCurrentUser.Role} allocated in the BSuite system");
                Assert.IsTrue(homePage.GetUserCurrentRole().Equals("[" + gblCurrentUser.Role + "]"));
                Metrics.BSuiteSoftwareVersion = webDriver.Title.Replace("Home - BSuite - ", "");
                gblOjectContainer.RegisterInstanceAs<HomePage>(homePage);
            }
            else if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/prestart", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add PreStart Checklist page to the container
                var preStartChecklistPage = new PreStartPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<PreStartPage>(preStartChecklistPage);
                preStartChecklistPage.CompletePreStartChecklist(new bool[] { true, true, true, true });
                preStartChecklistPage.Submit();
                System.Threading.Thread.Sleep(3000);
            }
            else if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase))//If PreStart Checklist is presented
            {
                //Add PreStart Checklist page to the container
                var preStartChecklistPage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage>(preStartChecklistPage);
                preStartChecklistPage.CompletePreStartChecklist(new bool[] { true, true, true, true, true });
                var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.elementName.Equals("Submit"))).elementId;
                webDriver.FindElement(By.Id(id)).Click();
                System.Threading.Thread.Sleep(3000);
            }
        }


        /// <summary>
        /// Logging in for the first time in a day
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        public void LoginForTheFirstTIme(string username, string password, string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<LoginPage>();
            loginPage.Login(username, password);

            wait.Until(localDriver =>
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/prestart", StringComparison.InvariantCultureIgnoreCase) ||
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))));

            //If PreStart Checklist is NOT presented, change user role to the desired role
            if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add HomePage to the container
                var homePage = new HomePage(webDriver);
                gblOjectContainer.RegisterInstanceAs<HomePage>(homePage);
                Assert.IsTrue(homePage.ChangeRole(role).isSuccess, $"Error: The User {gblCurrentUser.UserName} does not have the role {gblCurrentUser.Role} allocated in the BSuite system");
                Assert.IsTrue(homePage.GetUserCurrentRole().Equals("[" + gblCurrentUser.Role + "]"));
                Metrics.BSuiteSoftwareVersion = webDriver.Title.Replace("Home - BSuite - ", "");
                gblOjectContainer.RegisterInstanceAs<HomePage>(homePage);
            }
        }

        public void LoginForTheFirstTImeInMobile(string username, string password, string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();
            loginPage.Login(username, password);

            wait.Until(localDriver =>
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase) ||
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))));

            //If PreStart Checklist is NOT presented, change user role to the desired role

            if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add HomePage to the container
                var homePage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage(webDriver); //HomePage name changed by veera 25OCt21
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage>(homePage);  //HomePage name changed by veera 25OCt21
                                                                                                                              //Assert.IsTrue(homePage.ChangeRole(role).isSuccess, $"Error: The User {gblCurrentUser.UserName} does not have the role {gblCurrentUser.Role} allocated in the BSuite system"); //Commented by veera 25Oct21
                                                                                                                              //Assert.IsTrue(homePage.GetUserCurrentRole().Equals("[" + gblCurrentUser.Role + "]"));
                                                                                                                              //Metrics.BSuiteSoftwareVersion = webDriver.Title.Replace("Home - BSuite - ", "");
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage>(homePage);  //HomePage name changed by veera 25OCt21
            }

        }

        /// <summary>
        /// Logging in to BSuite Desktop Portal
        /// </summary>
        /// <param name="role"></param>
        public void LoginToBSuiteDesktopPortal(string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.LoginPage>();

            var username = gblConfig.Users[role].UserName;
            var password = gblConfig.Users[role].UserPassword;
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            loginPage.Login(username, password);

            //If User is logging in for the first time, based on their role, a PreStart Checklist form will be presented.
            wait.Until(localDriver =>
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/prestart", StringComparison.InvariantCultureIgnoreCase) ||
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))));

            //If PreStart Checklist is NOT presented, change user role to the desired role
            if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add HomePage to the container
                var homePage = new BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.HomePage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.HomePage>(homePage);
                Assert.IsTrue(homePage.ChangeRole(role).isSuccess, $"Error: The User {gblCurrentUser.UserName} does not have the role {gblCurrentUser.Role} allocated in the BSuite system");
                Assert.IsTrue(homePage.GetUserCurrentRole().Equals("[" + gblCurrentUser.Role + "]"));
                Metrics.BSuiteSoftwareVersion = webDriver.Title.Replace("Home - BSuite - ", "");
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.HomePage>(homePage);
            }
            //If PreStart Checklist is presented
            else if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/prestart", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add PreStart Checklist page to the container
                var preStartChecklistPage = new BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.PreStartPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal.PreStartPage>(preStartChecklistPage);
                preStartChecklistPage.CompletePreStartChecklist(new bool[] { true, true, true, true, true });
                preStartChecklistPage.Submit();
            }
        }

        /// <summary>
        /// Logging in to BSuite Mobile Portal
        /// </summary>
        /// <param name="role"></param>
        public void LoginToBSuiteMobilePortal(string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var loginPage = gblOjectContainer.Resolve<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.LoginPage>();

            var username = gblConfig.Users[role].UserName;
            var password = gblConfig.Users[role].UserPassword;
            gblCurrentUser.UserName = username;
            gblCurrentUser.Password = password;
            gblCurrentUser.Role = role;
            loginPage.Login(username, password);

            //If User is logging in for the first time, based on their role, a PreStart Checklist form will be presented.
            wait.Until(localDriver =>
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase) ||
                (localDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile", StringComparison.InvariantCultureIgnoreCase))));

            //If PreStart Checklist is NOT presented, change user role to the desired role
            if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile", StringComparison.InvariantCultureIgnoreCase))
            {
                //Add HomePage to the container
                var homePage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.HomePage>(homePage);
            }
            //If PreStart Checklist is presented
            else if (webDriver.Url.Equals(gblConfig.BSuiteURL + "/mobile?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase))//If PreStart Checklist is presented
            {
                //Add PreStart Checklist page to the container
                /*var preStartChecklistPage = new BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage(webDriver);
                gblOjectContainer.RegisterInstanceAs<BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.PreStartPage>(preStartChecklistPage);
                preStartChecklistPage.CompletePreStartChecklist(new bool[] { true, true, true, true, true });
                var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.elementName.Equals("Submit"))).elementId;
                webDriver.FindElement(By.Id(id)).Click();
                System.Threading.Thread.Sleep(2000);*/
            }
        }

        [Given(@"I log off from Bsuite '([^']*)' portal")]
        [When(@"I log off from Bsuite '([^']*)' portal")]
        [Then(@"I log off from Bsuite '([^']*)' portal")]
        public void ThenILogOffFromBsuitePortal(string mobile)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            if (webDriver.Title.Contains("BSuite on WAP"))
            {
                if (webDriver.Url.Contains("mobile?AJAX=preStartChecklList"))
                {
                    webDriver.Url = gblConfig.BSuiteURL;
                    wait.Until(localDriver => localDriver.Title.Contains("BSuite", StringComparison.InvariantCultureIgnoreCase));
                    Assert.IsTrue(webDriver.Title.Contains("BSuite", StringComparison.InvariantCultureIgnoreCase));
                    webDriver.FindElement(By.Id("ctl0_ctl3_logout")).Click();
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    //webDriver.FindElement(By.LinkText("Logout")).Click();
                    var actualElement = webDriver.FindElement(By.LinkText("Logout"));
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
                    executor.ExecuteScript("arguments[0].click();", actualElement);
                }
            }
            else
            {
                wait.Until(localDriver => localDriver.FindElement(By.Id("ctl0_ctl3_logout")).Text.Contains("Logout", StringComparison.InvariantCultureIgnoreCase));
                if (webDriver.Url.Contains("prestart-management"))
                {
                    webDriver.FindElement(By.LinkText("Home")).Click();
                    webDriver.FindElement(By.Id("ctl0_ctl3_logout")).Click();
                }
                else
                {
                    webDriver.FindElement(By.Id("ctl0_ctl3_logout")).Click();
                }

            }
            System.Threading.Thread.Sleep(3000);

        }

        [Given(@"I have logged into BSuite '(.*)' portal as a User with role '(.*)'")]
        [When(@"I have logged into BSuite '(.*)' portal as a User with role '(.*)'")]
        [Then(@"I have logged into BSuite '(.*)' portal as a User with role '(.*)'")]
        public void GivenIHaveLoggedIntoBSuitePortalAsAUserWithRole(string portal, string role)
        {
            if (portal.Equals("Desktop", StringComparison.InvariantCultureIgnoreCase))
            {
                GivenIHaveOpenedTheBSuiteDesktopPortal();
                LoginToBSuiteDesktopPortal(role);
            }
            else if (portal.Equals("Mobile", StringComparison.InvariantCultureIgnoreCase))
            {
                GivenIHaveOpenedTheBSuiteMobilePortal();
                LoginToBSuiteMobilePortal(role);
            }
        }
    }
}
