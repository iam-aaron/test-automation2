using BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal;
using ExcelDataReader;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;



namespace BSuiteE2ERegressionTest
{
    //Commonly used functions
    public sealed partial class StepDefinitions
    {

        /// <summary>
        /// Perform multiple actions on web elements on the webpage
        /// </summary>
        /// <param name="testVectorDataTable"></param>
        public void PerformActions(Table testVectorDataTable)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var pageData = string.Empty;
            Dictionary<string, string> testVectorData = new Dictionary<string, string>();
            foreach (var row in testVectorDataTable.Rows)
            {
                testVectorData.Add(row.Values.ToArray()[0].Trim(), row.Values.ToArray()[1].Trim());
            }
            PerformAction(testVectorData);
        }

        /// <summary>
        /// Perform an action on a web element on the webpage
        /// </summary>
        /// <param name="testVectorDataTable"></param>
        public void PerformAction(Dictionary<string, string> testVectorData)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var pageData = string.Empty;
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;

            IWebElement webElement = null;
            foreach (var kvp in testVectorData)
            {
                var id = "";
                if (webDriver.Url.Contains("mobile"))
                {
                    gblMenuItemSelected = "?AJAX=preStartChecklList";
                    id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(kvp.Key))).elementId;
                }
                else
                {
                    id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(kvp.Key))).elementId;
                }
                webElement = null;

                if ((kvp.Key.Equals("Yes")) && (webDriver.Url.Contains("bulkload")))
                {
                  
                    webElement = wait.Until(drv => drv.FindElement(By.XPath(id)));
                }
                else if((kvp.Key.Equals("Upload")) && (webDriver.Url.Contains("bulkload")))
                {                    
                    webElement = wait.Until(drv => drv.FindElement(By.Name(id)));
                }
                else
                {
                    webElement = wait.Until(drv => drv.FindElement(By.Id(id)));
                }
                if (webElement.TagName.Equals("input") && webElement.GetProperty("type").Equals("text") && webElement.Enabled)
                {
                    webElement.Click();
                    webElement.Clear();
                    if (kvp.Key.Equals("Serial Number") || kvp.Key.Equals("Client Ref #"))
                    {
                        webElement.SendKeys(kvp.Value.Trim() + System.DateTime.Now.ToString("yyyyMMddHHmm"));
                    }
                    else if (kvp.Key.Equals("Part"))
                    {
                        System.Threading.Thread.Sleep(1000);
                        webElement.SendKeys(kvp.Value.Trim());
                    }

                    else
                    {
                       webElement.SendKeys(kvp.Value.Trim());
                    }
                    if (kvp.Key.Equals("Site") || kvp.Key.Equals("Contact") || kvp.Key.Equals("Part"))
                    {
                        System.Threading.Thread.Sleep(4000);
                    }

                    var searchResultDivBox = FindWebElement(By.Id($"{id}_result"));
                    if (searchResultDivBox != null)
                    {
                        var searchResultsList = wait.Until(drv => searchResultDivBox.FindElements(By.TagName("ul")).ToList());
                        if (searchResultsList.Count != 0)
                        {
                            List<IWebElement> searchResults = wait.Until(drv => searchResultsList.FirstOrDefault().FindElements(By.TagName("li")).ToList());
                            if (searchResults.Count != 0)
                            {
                                foreach (IWebElement searchResult in searchResults)
                                {
                                    if (searchResult.Text.Contains(kvp.Value))
                                    {
                                        searchResult.Click();
                                    }
                                }
                            }
                        }
                    }
                }

                else if (webElement.TagName.Equals("textarea")  && webElement.Enabled)
                {
                    webElement.Click();
                    if (kvp.Key.Equals("Problem Desc")) 
                    {
                        webElement.SendKeys(kvp.Value.Trim());
                    }
                }                
                else if (webElement.TagName.Equals("input") && webElement.GetProperty("type").Equals("file") && webElement.Enabled)
                {
                    var filePath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\testData\"+ kvp.Value.Trim();
                    webElement.SendKeys(filePath);
                }

                else if (webElement.TagName.Equals("input") && webElement.GetProperty("type").Equals("submit") && webElement.Enabled)
                {
                    if (webElement.GetProperty("value").Equals(kvp.Key.Trim()))
                    {
                        webElement.Click();
                        break;
                    }
                    else if (webElement.GetProperty("value").Equals("→") || webElement.GetProperty("value").Equals("←"))
                    {
                        webElement.Click();
                        break;
                    }


                }
                
                else if (webElement.TagName.Equals("button") && webElement.Enabled)
                {
                    if (webElement.GetProperty("value").Equals(kvp.Key.Trim()))
                    {
                        IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
                        executor.ExecuteScript("arguments[0].click();", webElement);
                        //webElement.Click();
                        // break;
                    }
                }
                else if ((kvp.Key.Equals("Yes")) && (webDriver.Url.Contains("bulkload")) && webElement.Enabled)
                {
                    webElement.Click();
                    System.Threading.Thread.Sleep(2000);
                    var waitAlert = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(50));
                    System.Threading.Thread.Sleep(3000);
                    waitAlert.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
                    IAlert simpleAlert = webDriver.SwitchTo().Alert();
                    String alertText = simpleAlert.Text;
                    Console.WriteLine("Alert Text is :" + alertText);
                    simpleAlert.Accept();
                    

                    List<IWebElement> resultRows = webDriver.FindElements(By.XPath("//div[@id='ctl0_MainContent_bar_resultTable']/table//tr")).ToList();
                    int r = resultRows.Count();
                    String firstRow = webDriver.FindElement(By.XPath("//div[@id='ctl0_MainContent_bar_resultTable']/table//tr[2]/td[2]")).Text;
                    String lastRow = webDriver.FindElement(By.XPath("//div[@id='ctl0_MainContent_bar_resultTable']/table//tr[" + (r - 1) + "]/td[2]")).Text;
                    List<String> rowValues = new List<String>();
                    rowValues.Add(firstRow);
                    rowValues.Add(lastRow);
                    string taskNum = string.Empty;
                    int taskNumIncrement = 0;
                    foreach (String eachNumber in rowValues)
                    {
                        for (int i = 0; i < eachNumber.Length; i++)
                        {
                            if (Char.IsDigit(eachNumber[i]))
                            {
                                taskNum += eachNumber[i];

                            }
                        }
                        gblTaskNumberForBulkUpload[taskNumIncrement] = taskNum;
                        taskNumIncrement++;
                        Console.WriteLine(taskNum);
                        taskNum = "";
                    }
                }
                else if (webElement.TagName.Equals("select") && webElement.Enabled)
                {
                    var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
                    foreach (IWebElement element in selectElement.Options)
                    {
                        if (element.Text == kvp.Value.Trim())
                        {
                            element.Click();
                            break;
                        }
                    }
                }
                else if (kvp.Value.Trim().Equals("Exist"))
                {
                    Assert.IsTrue(webElement.Displayed);
                }
                System.Threading.Thread.Sleep(3000);    
            }
        }

       /// <summary>
       /// To verify email status for project bulk load
       /// </summary>
       /// <returns></returns>
        public string verifyNewlyOpenedWindowDetailsForProjectBulkLoad()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            System.Threading.Thread.Sleep(40000);
            webDriver.FindElement(By.Id("ctl0_MainContent_AuditLogButton")).Click();
            System.Threading.Thread.Sleep(10000);
            IWebElement webElementViewAuditLog = webDriver.FindElement(By.XPath("//div[@id='ctl0_MainContent_SearchAddPanel']/following::table//tr/td[2]/input"));
            webElementViewAuditLog.Click();
            List<IWebElement> rows = webDriver.FindElements(By.XPath("//table[@id='ctl0_MainContent_DataList']/tbody/tr")).ToList();
            int rowCount = rows.Count;
            String actionMessage = webDriver.FindElement(By.XPath("//table[@id='ctl0_MainContent_DataList']/tbody/tr[" + rowCount + "]//table//tr/td[3]")).Text;
            return actionMessage;
        }

        /// <summary>
        /// Search task using task number in Call Centre->Task Status Screen
        /// </summary>
        /// <returns></returns>
        public IWebElement searchTaskInTaskStatusScreen()
        {
            IWebElement webElementTaskNumber = null;
            for (int i = 0; i < gblTaskNumberForBulkUpload.Length; i++)
            {
                var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();               
                PerformAction(new Dictionary<string, string>() { { "Task No", gblTaskNumberForBulkUpload[i] } });
                PerformAction(new Dictionary<string, string>() { { "Search Field Tasks", "Click" } });
                webElementTaskNumber = webDriver.FindElement(By.XPath("//table[@class='DataList']/tbody/tr[1]/td[1]"));
                string actualTaskNum = webElementTaskNumber.Text;
                Assert.IsTrue(actualTaskNum.Contains(gblTaskNumberForBulkUpload[i]));
            }

            return webElementTaskNumber;
        }

        /// <summary>
        /// To check whether the user is already in watch list
        /// </summary>
        public void userExistsInToList(string name,string toList)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(toList))).elementId;
            IWebElement webElement = wait.Until(drv => drv.FindElement(By.Id(id)));
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
            foreach (IWebElement element in selectElement.Options)
            {
                if (element.Text == name)
                {
                    PerformAction(new Dictionary<string, string>() { { toList, name } });
                    if(toList.Contains("Agents"))
                    {
                        PerformAction(new Dictionary<string, string>() { { "Remove Agents", "Click" } });
                    }
                    else
                    {
                        PerformAction(new Dictionary<string, string>() { { "Remove Technicians", "Click" } });
                    }
                    
                    System.Threading.Thread.Sleep(2000);
                    break;
                }
            }
        }

        public string fetchUserFullNameFromEditReferenceWatchList(string name, string fromList)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(fromList))).elementId;
            IWebElement webElement = wait.Until(drv => drv.FindElement(By.Id(id)));
            var userFullName = "";
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
            foreach (IWebElement element in selectElement.Options)
            {
                var actualName = element.Text;
                if (actualName.Contains(name))
                {
                    var nameAfterSplit=actualName.Split(" ");
                    var firstName = nameAfterSplit[0];
                    if(firstName.Equals(name))
                    {
                    userFullName = element.Text;
                    break;
                    }
                }
            }
            return userFullName;
        }

        /// <summary>
        /// Read page elements
        /// </summary>
        /// <param name="testVectorDataTable"></param>
        public Dictionary<string, List<string>> ReadPageElement(string fieldName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var fieldValue = new Dictionary<string, List<string>>();

            IWebElement webElement = null;
            //gblLog += $"<p>Web Element: {fieldName}</p> <br>";
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Contains(fieldName))).elementId;
            webElement = wait.Until(drv => drv.FindElement(By.Id(id)));
            if (webElement.TagName.Equals("span") && webElement.Enabled && webElement.Displayed)
            {
                var subElements = webElement.FindElements(By.TagName("a"));
                fieldValue.Add(fieldName, new List<string>());
                if (subElements != null && subElements.Count > 0)
                {
                    foreach (var subElement in subElements)
                    {
                        fieldValue[fieldName].Add(subElement.Text);
                    }
                }
            }
            return fieldValue;
        }

        /// <summary>
        /// Same as FindElement only returns null when not found instead of an exception.
        /// </summary>
        /// <param name="driver">current browser instance</param>
        /// <param name="by">The search string for finding element</param>
        /// <returns>Returns element or null if not found</returns>
        public IWebElement FindWebElement(By by)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 10));
            try
            {
                return webDriver.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
        
        /// <summary>
         /// Capture Screenshot after each Test Step for Test Evidence
         /// </summary>
        public void CaptureScreenShot()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            try
            {
                if (!System.IO.Directory.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestResults"))
                {
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\TestResults");
                }

                ////Take Screenshot for Browser window for Test Evidence
                var takesScreenshot = (OpenQA.Selenium.ITakesScreenshot)webDriver;
                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    var tempFileName = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileNameWithoutExtension(Path.GetTempFileName())) + ".png";
                    screenshot.SaveAsFile(tempFileName, OpenQA.Selenium.ScreenshotImageFormat.Png);

                    Console.WriteLine($"SCREENSHOT[ file:///{tempFileName} ]SCREENSHOT");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.StackTrace}");
            }
        }

        //static void SampleTestCase(String browser, String version, String os, String os_version, String test_name, String build_name)
        //{
        //    switch (browser)
        //    {
        //        case "safari": //If browser is Safari, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Safari.SafariOptions safariCapability = new OpenQA.Selenium.Safari.SafariOptions();
        //            safariCapability.AddAdditionalCapability("browserstack.local", "true");
        //            safariCapability.AddAdditionalCapability("os_version", os_version);
        //            safariCapability.AddAdditionalCapability("browser", browser);
        //            safariCapability.AddAdditionalCapability("browser_version", version);
        //            safariCapability.AddAdditionalCapability("os", os);
        //            safariCapability.AddAdditionalCapability("name", test_name); // test name
        //            safariCapability.AddAdditionalCapability("build", build_name); // Your tests will be organized within this build
        //            safariCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj");
        //            safariCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55");
        //            ExecuteTestWithCaps(safariCapability);
        //            break;
        //        case "chrome": //If browser is Chrome, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Chrome.ChromeOptions chromeCapability = new OpenQA.Selenium.Chrome.ChromeOptions();
        //            chromeCapability.AddAdditionalCapability("browserstack.local", "true", true);
        //            chromeCapability.AddAdditionalCapability("os_version", os_version, true);
        //            chromeCapability.AddAdditionalCapability("browser", browser, true);
        //            chromeCapability.AddAdditionalCapability("browser_version", version, true);
        //            chromeCapability.AddAdditionalCapability("os", os, true);
        //            chromeCapability.AddAdditionalCapability("name", test_name, true);
        //            chromeCapability.AddAdditionalCapability("build", build_name, true);
        //            chromeCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj", true);
        //            chromeCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55", true);
        //            ExecuteTestWithCaps(chromeCapability);
        //            break;
        //        case "firefox": //If browser is Firefox, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Firefox.FirefoxOptions firefoxCapability = new OpenQA.Selenium.Firefox.FirefoxOptions();
        //            firefoxCapability.AddAdditionalCapability("browserstack.local", "true", true);
        //            firefoxCapability.AddAdditionalCapability("os_version", os_version, true);
        //            firefoxCapability.AddAdditionalCapability("browser", browser, true);
        //            firefoxCapability.AddAdditionalCapability("browser_version", version, true);
        //            firefoxCapability.AddAdditionalCapability("os", os, true);
        //            firefoxCapability.AddAdditionalCapability("name", test_name, true);
        //            firefoxCapability.AddAdditionalCapability("build", build_name, true);
        //            firefoxCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj", true);
        //            firefoxCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55", true);
        //            ExecuteTestWithCaps(firefoxCapability);
        //            break;
        //        case "edge": //If browser is Edge, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Edge.EdgeOptions edgeCapability = new OpenQA.Selenium.Edge.EdgeOptions();
        //            edgeCapability.AddAdditionalCapability("browserstack.local", "true");
        //            edgeCapability.AddAdditionalCapability("os_version", os_version);
        //            edgeCapability.AddAdditionalCapability("browser", browser);
        //            edgeCapability.AddAdditionalCapability("browser_version", version);
        //            edgeCapability.AddAdditionalCapability("os", os);
        //            edgeCapability.AddAdditionalCapability("name", test_name);
        //            edgeCapability.AddAdditionalCapability("build", build_name);
        //            edgeCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj");
        //            edgeCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55");
        //            ExecuteTestWithCaps(edgeCapability);
        //            break;
        //        case "ie": //If browser is IE, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.IE.InternetExplorerOptions ieCapability = new OpenQA.Selenium.IE.InternetExplorerOptions();
        //            ieCapability.AddAdditionalCapability("browserstack.local", "true", true);
        //            ieCapability.AddAdditionalCapability("os_version", os_version, true);
        //            ieCapability.AddAdditionalCapability("browser", browser, true);
        //            ieCapability.AddAdditionalCapability("browser_version", version, true);
        //            ieCapability.AddAdditionalCapability("os", os, true);
        //            ieCapability.AddAdditionalCapability("name", test_name, true);
        //            ieCapability.AddAdditionalCapability("build", build_name, true);
        //            ieCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj", true);
        //            ieCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55", true);
        //            ExecuteTestWithCaps(ieCapability);
        //            break;
        //        default:
        //            break;
        //    }
        //    switch (os)
        //    {
        //        case "ios": //If OS is ios, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Safari.SafariOptions iosCapability = new OpenQA.Selenium.Safari.SafariOptions();
        //            iosCapability.AddAdditionalCapability("real_mobile", "true");
        //            iosCapability.AddAdditionalCapability("browser", "iPhone");
        //            iosCapability.AddAdditionalCapability("os_version", version);
        //            iosCapability.AddAdditionalCapability("device", browser);
        //            iosCapability.AddAdditionalCapability("name", test_name); // test name
        //            iosCapability.AddAdditionalCapability("build", build_name); // Your tests will be organized within this build
        //            iosCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj");
        //            iosCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55");
        //            ExecuteTestWithCaps(iosCapability);
        //            break;
        //        case "android": //If OS is android, following capabilities will be passed to 'executeTestWithCaps' function
        //            OpenQA.Selenium.Chrome.ChromeOptions androidCapability = new OpenQA.Selenium.Chrome.ChromeOptions();
        //            androidCapability.AddAdditionalCapability("real_mobile", "true", true);
        //            androidCapability.AddAdditionalCapability("browser", "Android", true);
        //            androidCapability.AddAdditionalCapability("os_version", version, true);
        //            androidCapability.AddAdditionalCapability("device", browser, true);
        //            androidCapability.AddAdditionalCapability("name", test_name, true); // test name
        //            androidCapability.AddAdditionalCapability("build", build_name, true); // Your tests will be organized within this build
        //            androidCapability.AddAdditionalCapability("browserstack.user", "ovidiuchirila_EfuKlj", true);
        //            androidCapability.AddAdditionalCapability("browserstack.key", "U5CNQSP7YZsv8nHbCT55", true);
        //            ExecuteTestWithCaps(androidCapability);
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //executeTestWithCaps function takes capabilities from 'sampleTestCase' function and searches for 'BrowserStack' on google.com

        static void ExecuteTestWithCaps(OpenQA.Selenium.DriverOptions capability)
        {
            var user = System.Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
            var key = System.Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
            //var key = ENV['BROWSERSTACK_ACCESS_KEY'];
            OpenQA.Selenium.IWebDriver driver = new OpenQA.Selenium.Remote.RemoteWebDriver(
              new Uri("https://" + user + ":" + key + "@hub-cloud.browserstack.com/wd/hub/"), capability
            );

            driver.Navigate().GoToUrl("http://tstingbsuite.net/login");
            driver.FindElement(By.Id("ctl0_MainContent_username")).SendKeys("kizhakka");
            driver.FindElement(By.Id("ctl0_MainContent_password")).SendKeys("aJj77Q");
            driver.FindElement(By.Name("ctl0$MainContent$ctl4")).Click();
            try
            {
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(localDriver => localDriver.Title.Contains("Home - BSuite - 3.62.0", StringComparison.InvariantCultureIgnoreCase));
                // Setting the status of test as 'passed' or 'failed' based on the condition; if title of the web page starts with 'BrowserStack'
                ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"passed\", \"reason\": \" Title matched!\"}}");
            }
            catch (WebDriverTimeoutException)
            {
                ((IJavaScriptExecutor)driver).ExecuteScript("browserstack_executor: {\"action\": \"setSessionStatus\", \"arguments\": {\"status\":\"failed\", \"reason\": \" Title not matched \"}}");
            }
            Console.WriteLine(driver.Title);
            driver.Quit();
        }

        /// <summary>
        /// Start the web browser
        /// </summary>
        public IWebDriver SetupWebDriver()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
            var options = new OpenQA.Selenium.Chrome.ChromeOptions()
            {
                AcceptInsecureCertificates = true,
                PageLoadStrategy = PageLoadStrategy.Normal,
                //UnhandledPromptBehavior = OpenQA.Selenium.UnhandledPromptBehavior.AcceptAndNotify,
            };
            options.AddArguments("--no-sandbox");
            //options.AddArguments("--headless");
            options.AddArguments("--disable-gpu");
            options.AddArguments("−−incognito");
            options.AddArguments("--disable-extensions");
            options.AddArguments("start-maximized");
            //options.AddArguments("--dump - dom https://www.chromestatus.com/");

            try
            {
                if (!System.IO.Directory.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestResults\Downloads"))
                {
                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TestResults\Downloads");
                    
                }
                options.AddUserProfilePreference("download.default_directory", System.IO.Directory.GetCurrentDirectory() + @"\Downloads");
                options.AddUserProfilePreference("intl.accept_languages", "nl");
                options.AddUserProfilePreference("disable-popup-blocking", "true");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.StackTrace}");
            }

            object path;
            var chromeExecutableVersion = "";
            var chromeDriverPath = "";
            path = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            if (path != null)
                chromeExecutableVersion = FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion;

            if (chromeExecutableVersion.StartsWith("89."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V89";
            }
            else if (chromeExecutableVersion.StartsWith("90."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V90";
            }
            else if (chromeExecutableVersion.StartsWith("91."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V91";
            }
            else if (chromeExecutableVersion.StartsWith("92."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V92";
            }
            else if (chromeExecutableVersion.StartsWith("93."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V93";
            }
            else if (chromeExecutableVersion.StartsWith("94."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V94";
            }
            else if (chromeExecutableVersion.StartsWith("95."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V95";
            }
            else if (chromeExecutableVersion.StartsWith("96."))
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V96";
            }
            else
            {
                chromeDriverPath = System.IO.Directory.GetCurrentDirectory() + @"\Drivers\chromedriver\V95";
            }

            var webDriver = new OpenQA.Selenium.Chrome.ChromeDriver(chromeDriverPath, options);
            Console.WriteLine($"Chrome executable version: {chromeExecutableVersion}");
            Console.WriteLine($"Chromedriver Path: {chromeDriverPath}");
            webDriver.Navigate().Refresh();
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }

        ///// <summary>
        ///// Configure NLog Targets for output
        ///// </summary>
        //public void ConfigureLogger()
        //{
        //    if (NLog.LogManager.IsLoggingEnabled())
        //    {
        //        NLog.LogManager.Shutdown(); // Flush and close down internal threads and timers
        //    }
        //    var config = new NLog.Config.LoggingConfiguration();
        //    // Targets where to log to: File and Console
        //    var logfile = new NLog.Targets.FileTarget("logfile")
        //    {
        //        FileName = "TestResults\\" + $"BSuite.E2E.{gblTestCaseId}." +
        //                    $"{gblScenarioContext.ScenarioInfo.Title}." +
        //                    $"{TestContext.CurrentContext.Test.ID}." +
        //                    $"{System.DateTime.Now.ToString("yyyyMMdd")}.html",
        //        Layout = "${message}",
        //        DeleteOldFileOnStartup = true,
        //        KeepFileOpen = true,
        //        Encoding = Encoding.UTF8
        //    };
        //    var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
        //    // Rules for mapping loggers to targets            
        //    config.AddRule(NLog.LogLevel.Info, NLog.LogLevel.Fatal, logconsole);
        //    config.AddRule(NLog.LogLevel.Debug, NLog.LogLevel.Fatal, logfile);
        //    // Apply config           
        //    NLog.LogManager.Configuration = config;
        //    NLog.LogManager.ThrowConfigExceptions = false;
        //}

        /// <summary>
        /// Date suffix
        /// </summary>
        /// <returns></returns>
        public static string GenerateDateSuffix()
        {
            var ordinal = "";
            switch (DateTime.Now.Day)
            {
                case 1:
                case 21:
                case 31:
                    ordinal = "st";
                    break;
                case 2:
                case 22:
                    ordinal = "nd";
                    break;
                case 3:
                case 23:
                    ordinal = "rd";
                    break;
                default:
                    ordinal = "th";
                    break;
            }
            return ordinal;
        }

        /// <summary>
        /// Fetch the warehouse details to validate the location and details about warehouse
        /// </summary>
        public void fetchWarehouseIdAndAddress()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            System.Threading.Thread.Sleep(5000);
            var wareHouseId = webDriver.FindElement(By.XPath("//span[@id='ctl0_MainContent_storageLocationList']/table/tbody/tr/td")).GetAttribute("onclick");
            string id = string.Empty;
            for (int i = 0; i < wareHouseId.Length; i++)
            {
                if (Char.IsDigit(wareHouseId[i]))
                {
                    id += wareHouseId[i];
                }
            }
            gblWareHouseId = id;
        }

        /// <summary>
        /// To select the value of 'Please Select' drop down in Admin Warehouse pages
        /// </summary>
        /// <param name="textToVerify"></param>
        /// <returns></returns>
        public List<string> verifyNewlyOpenedWindowDetailsForWarehouse(string textToVerify)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            List<string> actualText = new List<string>();
            actualText.Clear();

            if (textToVerify.Contains("List Of Location Alias(es)"))
            {
                var toAliasText = webDriver.FindElements(By.XPath("//div[@id='ctl0_MainContent_StorageLocationAliasPanel']/table/tbody/tr/th"));
                foreach (var textElement in toAliasText)
                {
                    actualText.Add(textElement.Text);
                }
            }
            else if (textToVerify.Contains("Setting Warehouse MSL"))
            {
                var toMSLText = webDriver.FindElement(By.XPath("//span[@id='ctl0_InfoMessage']/table/tbody/tr[1]"));
                actualText.Add(toMSLText.Text);
            }
            else if (textToVerify.Contains("Set Group MSL"))
            {
                var toGroupMSL = webDriver.FindElement(By.XPath("//div[@id='ctl0_MessagePanel']/span[2]"));
                actualText.Add(toGroupMSL.Text);

            }

            return actualText;

        }

        public void clickPreStartLinkToProvideResponseAndReactivate(string userFullName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            System.Threading.Thread.Sleep(2000);
            List<IWebElement> pendingTechniciansList = webDriver.FindElements(By.XPath("//div[@id='ctl0_MainContent_TechPanel']/table/tbody/tr")).ToList();
            int count = pendingTechniciansList.Count();
            var flag = 0;
           // string username = gblConfig.Users[role].UserName;
            for (int i = 1; i <= count; i++)
            {
                var pendingTechnicianRow = pendingTechniciansList[i].FindElements(By.TagName("td")).ToList();
                foreach (var pendingTechnicianRowData in pendingTechnicianRow)
                {
                    var rowDataText = pendingTechnicianRowData.Text;
                    if (rowDataText.Contains(userFullName))
                    {
                        int num = i + 1;
                        pendingTechnicianRowData.FindElement(By.XPath("//div[@id='ctl0_MainContent_TechPanel']/table/tbody/tr[" + num + "]/td[2]/a")).Click();
                        flag = 1;
                        break;
                    }
                    else
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
        }

        public void enterValueToResponseAndCheckReactivate(string response, int expectedResponseNumber)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var responseLabel = webDriver.FindElement(By.XPath("//div[@id='content']/div/div[3]/div[" + expectedResponseNumber + "]/span[3]"));
            responseLabel.FindElement(By.TagName("textarea")).SendKeys(response);
            if ((expectedResponseNumber != 5) && (expectedResponseNumber != 4) && (expectedResponseNumber != 3))
            {
                webDriver.FindElement(By.XPath("(//span[@class='ques-checkbox ques-col'])[" + expectedResponseNumber + "]/input")).Click();
            }
            var saveButton = webDriver.FindElement(By.Id("ctl0_MainContent_submitButton"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
            executor.ExecuteScript("arguments[0].click();", saveButton);
        }
        /// <summary>
        /// To read and verify PreStart Checklist - Daily Report excel
        /// </summary>
        public void ReadExcel(string role)
        {
            var excelFileName = DateTime.Now.Date.ToString("yyyy-MM-dd_00_00_00") + "-" + DateTime.Now.Date.ToString("yyyy-MM-dd_23_59_59");
            var filePath = System.IO.Directory.GetCurrentDirectory() + @"\Downloads\PreStart_Desktop_" + excelFileName + ".csv";
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (var reader = ExcelReaderFactory.CreateCsvReader(stream))
                {

                    // Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    // The result of each spreadsheet is in result.Tables
                    char[] trimChars = { '"' };

                    //Validate structure of the excel report
                    Assert.AreEqual("MAX Technical Services", result.Tables[0].Rows[0][0]);
                    Assert.AreEqual("PreStart Checklist - Daily Report Supply Chain", result.Tables[0].Rows[1][0]);
                    Assert.AreEqual("Detailed", result.Tables[0].Rows[2][0]);
                    Assert.AreEqual("Time Zone:", result.Tables[0].Rows[4][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("AEST", result.Tables[0].Rows[4][0].ToString().Split(",").ToList().Last());
                    Assert.AreEqual("Date Generated:", result.Tables[0].Rows[5][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Period:", result.Tables[0].Rows[6][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Number of forms completed:", result.Tables[0].Rows[7][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Number completed successfully:", result.Tables[0].Rows[8][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Number unsuccessful:", result.Tables[0].Rows[9][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Date", result.Tables[0].Rows[13][0].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Form ID", result.Tables[0].Rows[13][0].ToString().Split(",").ToList().Skip(1).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Name", result.Tables[0].Rows[13][0].ToString().Split(",").ToList().Skip(2).FirstOrDefault());
                    Assert.AreEqual("Employee", result.Tables[0].Rows[13][0].ToString().Split(",").ToList().Skip(3).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().FirstOrDefault());
                    Assert.AreEqual("Role", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(1).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Time Submitted(AEST)", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(2).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Location", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(3).FirstOrDefault());
                    Assert.AreEqual("State", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(4).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Are all licenses that you require for your duties/role currently valid? E.G. drivers licence", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(5).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual(" gaming licence/forklift licence?", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(6).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Are your tools and equipment in good condition and do you have sufficient/enough PPE?", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(7).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("Have you completed all mandatory training relevant to your Field Technicians Role - (e.g. Electrical safety/lifting/ladders etc.) OR are you familiar with all of the SWP (Safe Work Practice) documents relevant to your role?", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(8).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("I am fit for work and can perform my work without compromising the safety or health of myself or others.", result.Tables[0].Rows[13][1].ToString().Split(",").ToList().Skip(9).FirstOrDefault().Trim(trimChars));


                    //Validate the Day 1 Responses on report
                    int i = 0;
                    var rowCount = result.Tables[0].Rows.Count;
                    //string role = "Logistics Technician";
                    var username = gblConfig.Users[role].UserName;
                    for (i = 13; i <= rowCount; i++)
                    {
                        string actualRoleRow = result.Tables[0].Rows[i][0].ToString();
                        if (actualRoleRow.Contains(username))
                        {

                            break;
                        }

                    }
                    Assert.AreEqual("yes", result.Tables[0].Rows[i][0].ToString().Split(",").ToList().Skip(8).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("yes", result.Tables[0].Rows[i][0].ToString().Split(",").ToList().Skip(9).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("yes", result.Tables[0].Rows[i][0].ToString().Split(",").ToList().Skip(10).FirstOrDefault().Trim(trimChars));
                    Assert.AreEqual("yes", result.Tables[0].Rows[i][0].ToString().Split(",").ToList().Skip(11).FirstOrDefault().Trim(trimChars));
                    reader.Close();
                }
            }
        }
    }
}
