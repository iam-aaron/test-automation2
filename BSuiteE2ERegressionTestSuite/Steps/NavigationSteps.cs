﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal;
using FluentAssertions;
using NUnit.Framework;
using System.IO;
using System.Configuration;
using System.Globalization;
using System.Drawing;

namespace BSuiteE2ERegressionTest
{
    public partial class StepDefinitions
    {
        public class TestVectorField
        {
            public string Field { get; set; }
        }

        [Given(@"I have navigated to '([^']*)' page from the top menu")]
        [Then(@"I can navigate to '([^']*)' page from the top menu")]
        [When(@"I can navigate to '([^']*)' page from the top menu")]
        public void GivenIHaveNavigatedToPageFromTheTopMenu(string topMenuItem)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[topMenuItem].resourceName}";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[topMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[topMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[topMenuItem].resourceName;
        }

        [Then(@"I cannot navigate to '([^']*)' page from the top menu")]
        public void ThenICannotNavigateToPageFromTheTopMenu(string topMenuItem)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[topMenuItem].resourceName}";
            Assert.Throws<OpenQA.Selenium.WebDriverTimeoutException>(() =>
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[topMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase)));
        }

        [Given(@"I have navigated to '([^']*)' page and entered details as follows")]
        public void GivenIHaveNavigatedToPageAndEnteredDetailsAsFollows(string subMenuItem, Table testVectorDataTable)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[subMenuItem].resourceName}";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[subMenuItem].resourceName;
            PerformActions(testVectorDataTable);
        }

        [Given(@"I have entered the following details in the '([^']*)' page")]
        [Given(@"I enter the following details in the '([^']*)' page")]
        [When(@"I enter the following details in the '([^']*)' page")]
        [Then(@"I enter the following details in the '([^']*)' page")]
        public void GivenIHaveEnteredTheFollowingDetailsInThePage(string pageTitle, Table testVectorDataTable)
        {
            PerformActions(testVectorDataTable);
        }

        [Then(@"a new Field Task is saved with the following Client Targets")]
        public void ThenANewFieldTaskIsSavedWithTheFollowingClientTargets(Table testVectorDataTable)
        {
            //Check if new field task has been added
            gblLog += $"New Saved Task: {ReadPageElement("Task ##")["Task ##"].FirstOrDefault()}";

            Assert.IsTrue(ReadPageElement("Task ##")["Task ##"].Count == 1,
                message: "New Task/Job was not created.");
        }

        [Given(@"I click the '([^']*)' button")]
        [When(@"I click the '([^']*)' button")]
        [Then(@"I click the '([^']*)' button")]
        public void WhenIClickTheButton(string buttonName)
        {

            PerformAction(new Dictionary<string, string>() { { buttonName, "Click" } });
        }

        [Given(@"I have clicked '(.*)' link and entered details as follows")]
        public void GivenIHaveClickedLinkAndEnteredDetailsAsFollows(string subMenuItem, Table testVectorDataTable)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[subMenuItem].resourceName}";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle}", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle}", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[subMenuItem].resourceName;
            PerformActions(testVectorDataTable);
        }

        [Then(@"New Tasks should be created and verify the task numbers in '(.*)'")]
        public void ThenNewTasksShouldBeCreatedAndVerifyTheTaskNumbersIn(string pageLink)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[pageLink].resourceName}";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[pageLink].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[pageLink].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[pageLink].resourceName;
            IWebElement webElementTaskNumber = null;
            for (int i = 0; i < 2; i++)
            {
                PerformAction(new Dictionary<string, string>() { { "Task No", gblTaskNumberForBulkUpload[i] } });
                PerformAction(new Dictionary<string, string>() { { "Search Field Tasks", "Click" } });
                webElementTaskNumber = webDriver.FindElement(By.XPath("//table[@class='DataList']/tbody/tr[1]/td[1]"));
                string actualTaskNum = webElementTaskNumber.Text;
                Assert.IsTrue(actualTaskNum.Contains(gblTaskNumberForBulkUpload[i]));
            }
            webElementTaskNumber.Click();
            wait.Until(localDriver => webDriver.WindowHandles.Count > 1);
            int windowCount = webDriver.WindowHandles.Count();
            if (windowCount > 1)
            {
                IList<string> totWindowHandles = new List<string>(webDriver.WindowHandles);
                webDriver.SwitchTo().Window(totWindowHandles[1]);
                var actionMessage = verifyNewlyOpenedWindowDetailsForProjectBulkLoad();
                Assert.IsTrue(actionMessage.Contains(gblTaskNumberForBulkUpload[1] + "\' At Status \'QUEUED\' Via Email"));
                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]).Close();
                webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            }
        }

        [Given(@"I click the '([^']*)' link")]
        [When(@"I click the '([^']*)' link")]
        [Then(@"I click the '([^']*)' link")]
        public void GivenIClickTheLink(string linkTextName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(linkTextName)));
            webDriver.FindElement(By.LinkText(linkTextName)).Click();
            System.Threading.Thread.Sleep(3000);
        }

        [Given(@"Daily preStartChecklList Should not be displayed")]
        [When(@"Daily preStartChecklList Should not be displayed")]
        [Then(@"Daily preStartChecklList Should not be displayed")]
        public void DailyPrestartChecklistShouldnotbedisplayed()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            Assert.IsFalse(webDriver.Url.Contains("?AJAX=preStartChecklList", StringComparison.InvariantCultureIgnoreCase));

        }

        [Given(@"I click the '([^']*)' button to load details")]
        public void GivenIClickTheButtonToLoadDetails(string buttonName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var id = UIMap.UIElementMap.Find(z => (z.elementName.Equals(buttonName))).elementId;
            if (id.Contains("/"))
            {
                webDriver.FindElement(By.XPath(id)).Click();
            }
            else
            {
                webDriver.FindElement(By.Id(id)).Click();

            }
            System.Threading.Thread.Sleep(3000);
        }

        [Given(@"I fetch the warehouse details")]
        public void GivenIFetchTheWarehouseDetails()
        {
            fetchWarehouseIdAndAddress();
        }

        [Then(@"I fetch the task number")]
        public void ThenIFetchTheTaskNumber()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(50));
            var taskNumber = UIMap.UIElementMap.Find(z => (z.elementName.Equals("TaskNumber"))).elementId;
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(taskNumber)));
            gblTaskNumber = webDriver.FindElement(By.XPath(taskNumber)).Text;
            Console.WriteLine(gblTaskNumber);
        }

        [Given(@"I have navigated to '([^']*)' page from '([^']*)' in '([^']*)' top menu")]
        public void GivenIHaveNavigatedToPageFromInTopMenu(string actualPage, string subMenuItem, string topMenuItem)
        {
            GivenIHaveNavigatedToPageFromTheTopMenu(actualPage);
        }

        [Given(@"I enter '([^']*)' as '([^']*)'")]
        [When(@"I enter '([^']*)' as '([^']*)'")]
        [Then(@"I enter '([^']*)' as '([^']*)'")]
        public void GivenIEnterAs(string textBoxName, string textValue)
        {
            PerformAction(new Dictionary<string, string>() { { textBoxName, textValue } });
        }

        [Given(@"I select the '([^']*)' drop down value as '([^']*)' in '([^']*)' page")]
        [When(@"I select the '([^']*)' drop down value as '([^']*)' in '([^']*)' page")]
        [Then(@"I select the '([^']*)' drop down value as '([^']*)' in '([^']*)' page")]
        public void GivenISelectTheValueAsInPage(string elementName, string elementValue, string pageName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            int previousCount = webDriver.WindowHandles.Count();
            gblMenuItemSelected = UIMap.UIPageMap[pageName].resourceName;
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(elementName))).elementId;
            System.Threading.Thread.Sleep(3000);
            var webElement = webDriver.FindElement(By.XPath(id));
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
            foreach (IWebElement element in selectElement.Options)
            {
                if (element.Text == elementValue)
                {
                    element.Click();
                    System.Threading.Thread.Sleep(3000);
                    break;
                }
            }
        }

        [Then(@"I verify the warehouse details")]
        public void ThenWarehouseDetailsIsDisplayed()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var hiddenId = webDriver.FindElement(By.Id("ctl0_MainContent_EditWarehouseId")).GetAttribute("value");
            Assert.AreEqual(hiddenId, gblWareHouseId);
            var pageName = "Admin Warehouse";
            gblMenuItemSelected = UIMap.UIPageMap[pageName].resourceName;
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Cancel"))).elementId;
            webDriver.FindElement(By.Name(id)).Click();
        }

        [Then(@"A new window is displayed  for '([^']*)'")]
        public void ThenANewWindowIsDisplayedFor(string textToVerify)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            int windowCount = webDriver.WindowHandles.Count();
            if (windowCount > 1)
            {
                IList<string> totWindowHandles = new List<string>(webDriver.WindowHandles);
                webDriver.SwitchTo().Window(totWindowHandles[1]);

                

                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]).Close();
                webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            }
        }

        [Given(@"I select the '([^']*)' location in the Select a Warehouse Location tree")]
        public void GivenSelectTheLocationInTheSelectAWarehouseLocationTree(string locationTree)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            IList<string> locationTreeList = locationTree.Split("/");
            for (int i = 1; i < locationTreeList.Count; i++)
            {
                IList<IWebElement> rowList = webDriver.FindElements(By.XPath("//div[@id='ctl0_MainContent_whTree']/div/div/div[2]//table/tbody/tr")).ToList();
                for (int j = 2; j < rowList.Count; j++)
                {
                    var actualElementGrandParent = rowList[j].FindElement(By.TagName("td"));
                    var actualElementParent = actualElementGrandParent.FindElement(By.TagName("div"));
                    string actualFolderName = actualElementParent.Text;
                    if (actualFolderName.Equals(locationTreeList[i]))
                    {
                        var actualElements = actualElementParent.FindElements(By.TagName("img")).ToList();
                        var actualElement = actualElements[i];
                        IJavaScriptExecutor executor = (IJavaScriptExecutor)webDriver;
                        executor.ExecuteScript("arguments[0].click();", actualElement);
                        System.Threading.Thread.Sleep(3000);
                        break;
                    }

                }
            }
        }

        [Given(@"I click the '([^']*)' button to load storage locations")]
        public void GivenIClickTheButtonToLoadStorageLocations(string reset)
        {
            throw new PendingStepException();
        }

        [When(@"I have clicked '([^']*)' link")]
        [Then(@"I have clicked '([^']*)' link")]
        [Given(@"I have clicked '([^']*)' link")]
        public void WhenIHaveClickedLink(string linkText)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.FindElement(By.LinkText(linkText)).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I select DateTime range for current day")]
        [Then(@"I select DateTime range for current day")]
        [Given(@"I select DateTime range for current day")]
        public void WhenIEnterPreviousDayDate()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            IWebElement fromDateWebElement = webDriver.FindElement(By.Id("ctl0_MainContent_fromDateReport"));
            IWebElement toDateWebElement = webDriver.FindElement(By.Id("ctl0_MainContent_toDateReport"));
            var today = DateTime.Now.Date;
            fromDateWebElement.Clear();
            toDateWebElement.Clear();
            System.Threading.Thread.Sleep(2000);
            string todayFrom = today.ToString("yyyy-MM-dd 00:00:00");
            string todayTo = today.ToString("yyyy-MM-dd 23:59:59");
            fromDateWebElement.SendKeys(todayFrom);
            System.Threading.Thread.Sleep(1000);
            toDateWebElement.SendKeys(todayTo);
            System.Threading.Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//div[@id='content']")).Click();
            System.Threading.Thread.Sleep(1000);
        }

        [When(@"I click 'Output To CSV' button to download the Prestart Report")]
        [Then(@"I click 'Output To CSV' button to download the Prestart Report")]
        [Given(@"I click 'Output To CSV' button to download the Prestart Report")]
        public void WhenReportGetsDowloaded()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var Path = System.IO.Directory.GetCurrentDirectory() + @"\Downloads";
            var fileName = DateTime.Now.Date.ToString("yyyy-MM-dd_00_00_00") + "-" + DateTime.Now.Date.ToString("yyyy-MM-dd_23_59_59");
            string[] filePaths = System.IO.Directory.GetFiles(Path);
            foreach (string p in filePaths)
            {
                if (p.Contains(fileName))
                {
                    FileInfo thisFile = new FileInfo(p);


                    File.Delete(p);

                }
            }
            System.Threading.Thread.Sleep(3000);
            webDriver.FindElement(By.XPath("//input[@value='Output To CSV']")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"Open the downloaded Prestart Report to verify structure and Prestart Checklist responses of '([^']*)' are recorded accurately")]
        [When(@"Open the downloaded Prestart Report to verify structure and Prestart Checklist responses of '([^']*)' are recorded accurately")]
        public void ThenOpenTheDownloadedPrestartDesktopReportToVerifyStructureAndPrestartChecklistResponsesOfAreRecordedAccurately(string role)
        {
            ReadExcel(role);
        }

        [Given(@"I have navigated to '([^']*)' page from '([^']*)' top menu")]
        [When(@"I have navigated to '([^']*)' page from '([^']*)' top menu")]
        [Then(@"I have navigated to '([^']*)' page from '([^']*)' top menu")]
        public void GivenIHaveNavigatedToPageFromCallCentreTopMenu(string subMenuItem, string topMenuItem)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            IWebElement linkName = webDriver.FindElement(By.LinkText(topMenuItem));
            Actions ac = new Actions(webDriver);
            ac.MoveToElement(linkName).Perform();
            webDriver.FindElement(By.LinkText(subMenuItem)).Click();
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[subMenuItem].resourceName;
        }

        [Given(@"I add '([^']*)' from '([^']*)' to '([^']*)' in '([^']*)' page")]
        public void GivenIAddFromToInPage(string userRole, string fromList, string toList, string subMenuItem)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[subMenuItem].resourceName;            
            userExistsInToList(gbluserFullName, toList);
            PerformAction(new Dictionary<string, string>() { { fromList, gbluserFullName } });
            PerformAction(new Dictionary<string, string>() { { "Add Technicians", "Click" } });
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"I add the technician '([^']*)' from '([^']*)' to '([^']*)' in '([^']*)' page")]
        public void GivenIAddTheTechnicianFromToInPage(string technicianName, string fromList, string toList, string subMenuItem)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            var userFullName = "";
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[subMenuItem].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[subMenuItem].resourceName;
            userFullName=fetchUserFullNameFromEditReferenceWatchList(technicianName, fromList);
            if(userFullName.Equals(""))
            {
                userFullName = fetchUserFullNameFromEditReferenceWatchList(technicianName, toList);
                gbluserFullName = userFullName;
            }
            userExistsInToList(userFullName, toList);
            PerformAction(new Dictionary<string, string>() { { fromList, userFullName } });
            if (toList.Contains("Agents"))
            {
                PerformAction(new Dictionary<string, string>() { { "Add Agents", "Click" } });
            }
            else
            {
                PerformAction(new Dictionary<string, string>() { { "Add Technicians", "Click" } });
            }  
            System.Threading.Thread.Sleep(2000);
        }


        [Given(@"I add state as '([^']*)' and worktype as '([^']*)' to watch list")]
        public void GivenIAddStateAsAndWorktypeAsToWatchList(string stateId, string workType)
        {
            PerformAction(new Dictionary<string, string>() { { "Unassigned Tasks By State", stateId } });
            PerformAction(new Dictionary<string, string>() { { "Unassigned Tasks By WorkType", workType } });
            PerformAction(new Dictionary<string, string>() { { "Unassigned Add State WorkType", "Click" } });
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"I add state as '([^']*)' and worktype as '([^']*)' to watch list for pending tasks")]
        public void GivenIAddStateAsAndWorktypeAsToWatchListForPendingTasks(string stateId, string workType)
        {
            PerformAction(new Dictionary<string, string>() { { "Pending Tasks By State", stateId } });
            PerformAction(new Dictionary<string, string>() { { "Pending Tasks By WorkType", workType } });
            PerformAction(new Dictionary<string, string>() { { "Pending Add State WorkType", "Click" } });
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"I select the task number fetched for the state '([^']*)' and the worktype '([^']*)'")]
        public void GivenISelectTheTaskNumberForTheStateAndTheWorktype(string stateId, string workType)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            var id = UIMap.UIElementMap.Find(z => (z.elementName.Equals("Unassigned Panel"))).elementId;
            var flag = 0;
            IWebElement unAssignedPanelTable=webDriver.FindElement(By.XPath(id));
            var unAssignedPanelTableRow=unAssignedPanelTable.FindElements(By.TagName("tr")).ToList();
            for(int i=1;i<= unAssignedPanelTableRow.Count;i++)
            {
                var unAssignedPanelTableRowColumn= unAssignedPanelTableRow[i].FindElements(By.TagName("td"));
                var unAssignedPanelTableRowStateValue=unAssignedPanelTableRowColumn[0].Text;
                if (unAssignedPanelTableRowStateValue.Equals(stateId))
                {
                    var unAssignedPanelTableRowWorkType=unAssignedPanelTableRowColumn[1].Text;
                    if(unAssignedPanelTableRowWorkType.Equals(workType))
                    {
                        var unAssignedTasks=unAssignedPanelTableRowColumn[2].FindElement(By.TagName("div"));
                        var actualTasks=unAssignedTasks.FindElements(By.TagName("div"));
                        foreach(var eachTask in actualTasks)
                        {
                            var actualTaskNumberLink=eachTask.FindElement(By.TagName("a"));
                            var actualTaskNumber = actualTaskNumberLink.Text;
                            if(actualTaskNumber.Equals(gblTaskNumber))
                            {
                                actualTaskNumberLink.Click();
                                System.Threading.Thread.Sleep(2000);
                                flag = 1;
                                break;
                            }
                        }
                    }
                }
                if(flag==1)
                {
                    flag = 0;
                    break;
                }
            }
        }

        [Given(@"I select '([^']*)' from the '([^']*)' drop down box for '([^']*)'")]
        public void GivenISelectFromTheDropDownBoxFor(string dropDownValue, string elementName, string role)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => webDriver.WindowHandles.Count > 1);
            gblMenuItemSelected = "fieldtaskstatus/edit";
            int windowCount = webDriver.WindowHandles.Count();
            if (windowCount > 1)            {
                IList<string> totWindowHandles = new List<string>(webDriver.WindowHandles);
                webDriver.SwitchTo().Window(totWindowHandles[1]);
                var taskId = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Task No Status"))).elementId;
                gblTaskNumber = webDriver.FindElement(By.Id(taskId)).Text;
                PerformAction(new Dictionary<string, string>() { { elementName, dropDownValue } });
                PerformAction(new Dictionary<string, string>() { { "Technician", gbluserFullName } });
                PerformAction(new Dictionary<string, string>() { { "Save", "Click" } });
                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]).Close();
                webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            }
        }


        [Given(@"I select '([^']*)' from the '([^']*)' drop down box")]
        [When(@"I select '([^']*)' from the '([^']*)' drop down box")]
        [Then(@"I select '([^']*)' from the '([^']*)' drop down box")]
        public void GivenISelectFromTheDropDownBox(string dropDownValue, string elementName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => webDriver.WindowHandles.Count > 1);
            gblMenuItemSelected = "fieldtaskstatus/edit";
            int windowCount = webDriver.WindowHandles.Count();
            if (windowCount > 1)
            {
                IList<string> totWindowHandles = new List<string>(webDriver.WindowHandles);
                webDriver.SwitchTo().Window(totWindowHandles[1]);
                var taskId= UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Task No Status"))).elementId;
                gblTaskNumber = webDriver.FindElement(By.Id(taskId)).Text;
                PerformAction(new Dictionary<string, string>() { { elementName, dropDownValue } });
                if (dropDownValue.Equals("TAKEN"))
                {
                    var dropDownTechnician = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Technician"))).elementId;
                    var webElement=webDriver.FindElement(By.Id(dropDownTechnician));                    
                    var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(webElement);
                    selectElement.SelectByIndex(1);
                }
                if (dropDownValue.Equals("CANCEL"))
                {
                    var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Yes"))).elementId;
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));
                    PerformAction(new Dictionary<string, string>() { { "Yes", "Click" } });
                    System.Threading.Thread.Sleep(1000);
                }
                PerformAction(new Dictionary<string, string>() { { "Save", "Click" } });
                System.Threading.Thread.Sleep(1000);
                webDriver.SwitchTo().Window(webDriver.WindowHandles[1]).Close();
                webDriver.SwitchTo().Window(webDriver.WindowHandles[0]);
            }
        }

        [Then(@"I verify the task in My Tasks page on mobile portal")]
        public void ThenIVerifyTheTaskInMyTasksPageOnMobilePortal()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Url.Contains($"{BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIPageMap["My Tasks"].resourceName}", StringComparison.InvariantCultureIgnoreCase));
            var flag = 0;
            var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.elementName.Equals("taskNumber"))).elementId;
            List<IWebElement> taskNumbers = webDriver.FindElements(By.XPath(id)).ToList();
            foreach (IWebElement eachTaskNumber in taskNumbers)
                {
                    var actualTaskNumber = eachTaskNumber.Text;
                    
                    if (actualTaskNumber.Contains(gblTaskNumber))
                    {
                        Assert.IsTrue(actualTaskNumber.Contains(gblTaskNumber));
                        flag = 1;
                        break;
                    }

                }
            if (flag == 0)
            {
                Assert.IsTrue(false);
                Console.WriteLine("Task is not displayed");
            }
        }

        [Then(@"I am NOT able to view the Task number in My Tasks page on mobile portal")]
        public void ThenIAmNOTAbleToViewTheTaskNumberInMyTasksPageOnMobilePortal()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Url.Contains($"{BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIPageMap["My Tasks"].resourceName}", StringComparison.InvariantCultureIgnoreCase));
            var flag = 0;
            var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.elementName.Equals("taskNumber"))).elementId;
            List<IWebElement> taskNumbers = webDriver.FindElements(By.XPath(id)).ToList();
            foreach (IWebElement eachTaskNumber in taskNumbers)
            {
                var actualTaskNumber = eachTaskNumber.Text;

                if (actualTaskNumber.Contains(gblTaskNumber))
                {
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Assert.IsTrue(true);
                Console.WriteLine("Task is not displayed as expected");
            }
        }



        [Given(@"I search the task number in '([^']*)'")]
        [When(@"I search the task number in '([^']*)'")]
        public void GivenISearchTheTaskNumberIn(string pageName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            webDriver.Url = $"{gblConfig.BSuiteURL}/{UIMap.UIPageMap[pageName].resourceName}";
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(localDriver => localDriver.Title.Contains($"{UIMap.UIPageMap[pageName].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(webDriver.Title.Contains($"{UIMap.UIPageMap[pageName].windowTitle} - BSuite", StringComparison.InvariantCultureIgnoreCase));
            gblMenuItemSelected = UIMap.UIPageMap[pageName].resourceName;
            IWebElement webElementTaskNumber = null;            
            PerformAction(new Dictionary<string, string>() { { "Task No", gblTaskNumber } });
            PerformAction(new Dictionary<string, string>() { { "Search Field Tasks", "Click" } });
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Search Tasks Result"))).elementId;
            webElementTaskNumber = webDriver.FindElement(By.XPath(id));
            string actualTaskNum = webElementTaskNumber.Text;
            Assert.IsTrue(actualTaskNum.Contains(gblTaskNumber));
            System.Threading.Thread.Sleep(2000);
            webElementTaskNumber.Click();            
        }

        [Given(@"I click '([^']*)' button")]
        [When(@"I click '([^']*)' button")]
        public void GivenIClickButton(string buttonName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(buttonName))).elementId;
            try 
            {
                webDriver.FindElement(By.Id(id)).Click();                
                System.Threading.Thread.Sleep(5000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        [Given(@"I select the task number with status as '([^']*)'")]
        [When(@"I select the task number with status as '([^']*)'")]
        [Then(@"I select the task number with status as '([^']*)'")]
        public void GivenISelectTheTaskNumberWithStatusAs(string taskStatus)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();            
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Tasks Result Table"))).elementId;
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(id)));
            IWebElement resultTable=webDriver.FindElement(By.XPath(id));
           // var flag = 0;
            var tableRows=resultTable.FindElements(By.TagName("tr")).ToList();
            foreach(var eachRow in tableRows)
            {
                var eachRowData=eachRow.FindElements(By.TagName("td")).ToList();
                if(eachRowData[5].Text.Equals(taskStatus))
                {
                    eachRowData[0].Click();                    
                    break;
                }
                /*foreach(var eachData in eachRowData)
                {
                    var eachDataText=eachData.Text;
                    if(eachDataText.Equals(taskStatus))
                    {
                        eachRowData[0].Click();
                        flag = 1;
                        break;
                    }
                }
                if(flag==1)
                {
                    flag = 0;
                    break;
                }*/
            } 
        }

        [Given(@"I click PreStart link for the '([^']*)' No response and reactivate it for '([^']*)'")]
        [When(@"I click PreStart link for the '([^']*)' No response and reactivate it for '([^']*)'")]
        [Then(@"I click PreStart link for the '([^']*)' No response and reactivate it for '([^']*)'")]
        public void ThenIClickPreStartLinkForTheNoResponseAndReactivateItFor(string responseNumber, string role)
        {
            var response = "approved";
            var userFullName = "";
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(5));
            wait.Until(localDriver => localDriver.Url.Contains($"taskbytech", StringComparison.InvariantCultureIgnoreCase));
            if(responseNumber.Equals("first"))
            {
                WhenIClickTheButton("Edit Preferences");
                var technicianName = gblConfig.Users[role].UserName;
                userFullName = fetchUserFullNameFromEditReferenceWatchList(technicianName, "All Technicians");
                if (userFullName.Equals(""))
                {
                    userFullName = fetchUserFullNameFromEditReferenceWatchList(technicianName, "Technicians currently on watch list");
                }
                userExistsInToList(userFullName, "Technicians currently on watch list");
                PerformAction(new Dictionary<string, string>() { { "All Technicians", userFullName } });
                System.Threading.Thread.Sleep(2000);
                PerformAction(new Dictionary<string, string>() { { "Add Technicians", "Click" } });
                System.Threading.Thread.Sleep(2000);
                gbluserFullName = userFullName;
                WhenIClickTheButton("Save and Update");                
            }            
            clickPreStartLinkToProvideResponseAndReactivate(gbluserFullName);
            var expectedResponseNumber = 0;
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
            enterValueToResponseAndCheckReactivate(response, expectedResponseNumber);
        }


        [Then(@"I fetch the '([^']*)' full name")]
        public void ThenIFetchTheFullName(string role)
        {
            
            ThenILogOffFromBsuitePortal("Desktop");
            GivenIHaveOpenedTheBSuiteDesktopPortal();
            LoginToBSuiteDesktopPortal(role);
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            gbluserFullName = webDriver.FindElement(By.Id("ctl0_ctl2_userFullName")).Text;
            ThenILogOffFromBsuitePortal("Desktop");
            GivenIHaveLoggedIntoBSuitePortalAsAUserWithRole("Desktop", "Call Desk Manager");

        }

        [Given(@"I verify the '([^']*)' page has the following tabs")]
        [When(@"I verify the '([^']*)' page has the following tabs")]
        [Then(@"I verify the '([^']*)' page has the following tabs")]
        public void GivenIVerifyThePageHasTheFollowingTabs(string pageName, Table table)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            gblMenuItemSelected = UIMap.UIPageMap[pageName].resourceName;
            Dictionary<string, string> testVectorData = new Dictionary<string, string>();
            foreach (var row in table.Rows)
            {
                testVectorData.Add(row.Values.ToArray()[0].Trim(), "Exist");
            }
            PerformAction(testVectorData);
            
        }

        [Given(@"I verify the '([^']*)' page has the following buttons")]
        [Then(@"I verify the '([^']*)' page has the following buttons")]
        public void GivenIVerifyThePageHasTheFollowingButtons(string pageName, Table table)
        {
            GivenIVerifyThePageHasTheFollowingTabs(pageName, table);
        }

        [Given(@"I click the '([^']*)' tab")]
        public void GivenIClickTheTab(string tabNameAsLink)
        {
            GivenIClickTheLink(tabNameAsLink);
        }

        [Given(@"I verify '([^']*)' is displayed under '([^']*)' on '([^']*)' tab")]
        [When(@"I verify '([^']*)' is displayed under '([^']*)' on '([^']*)' tab")]
        [Then(@"I verify '([^']*)' is displayed under '([^']*)' on '([^']*)' tab")]
        public void GivenIVerifyTheTechnicianIsDisplayedUnderOnTab(string name, string tableHeaderName, string tabName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var id = "";
            int increment = 0;
            var dataId = "";
            var flag = 0;
            if (tabName.Equals("Assigned to Techs"))
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Assigned to Techs Table"))).elementId;
            }
            else if(tabName.Equals("Assigned to Agents"))
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Assigned to Agents Table"))).elementId;
            }
            else if(tabName.Equals("Unassigned"))
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Unassigned Table"))).elementId;
            }
            else 
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Pending Table"))).elementId;
            }
            
            List<IWebElement> pendingTechniciansList = webDriver.FindElements(By.XPath(id)).ToList();
            var tableHeader = pendingTechniciansList[0].FindElements(By.TagName("th"));
            foreach (var eachData in tableHeader)
            {
                increment++;
                if (eachData.Text == tableHeaderName)
                {
                    break;
                }
            }

            for (int i=2;i<=pendingTechniciansList.Count;i++)
            {
                if ((tableHeaderName.Equals("Technicians")) || (tableHeaderName.Equals("Agents/Clients")))
                {
                    dataId = id + "[" + i + "]" + "/" + "td[" + increment + "]" + "/table/tbody/tr/td";
                    var actualName = webDriver.FindElement(By.XPath(dataId)).Text;
                    var nameAfterSplit = actualName.Split(" ");
                    if (nameAfterSplit[0].Equals(name))
                    {
                        Assert.IsTrue(true);
                        flag = 1;
                        break;
                    }
                }
                else if (tableHeaderName.Equals("Pre Start"))
                {
                    dataId = id + "[" + i + "]" + "/" + "td[" + increment + "]";
                    var preStartStatus = webDriver.FindElement(By.XPath(dataId)).Text;
                    if((preStartStatus.Contains("Not Started"))|| (preStartStatus.Contains("Pre Start")))
                    {
                        Assert.IsTrue(true);
                        flag = 1;
                        break;
                    }
                }
                else
                {
                    int k = i - 1;
                    dataId = id + "[" + k + "]" + "/" + "th[" + increment + "]";
                    var columnName = webDriver.FindElement(By.XPath(dataId)).Text;
                    if (columnName.Equals(tableHeaderName))
                    {
                        Assert.IsTrue(true);
                        flag = 1;
                        break;
                    }

                }
            }
            if(flag==0)
            {
                Assert.IsTrue(false);                
            }
        }

        [Given(@"I verify '([^']*)' status on '([^']*)' tab")]
        [Then(@"I verify '([^']*)' status on '([^']*)' tab")]
        public void GivenIVerifyStatusOnTab(string tableHeaderName, string tabName)
        {
            var name = "";
            GivenIVerifyTheTechnicianIsDisplayedUnderOnTab(name, tableHeaderName, tabName);
        }

        [Given(@"I verify the '([^']*)' '([^']*)' added to watch list under '([^']*)'")]
        [Then(@"I verify the '([^']*)' '([^']*)' added to watch list under '([^']*)'")]
        public void GivenIVerifyTheAddedToWatchListUnder(string tableHeaderName, string stateName, string tabName)        
        {
            int increment = 0;
            var dataId = "";
            var flag = 0;
            var id = "";
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            if(tabName.Equals("Unassigned"))
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Unassigned Table"))).elementId;
            }
            else 
            {
                id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Pending Table"))).elementId;
            }
          
            List<IWebElement> unAssignedTasks = webDriver.FindElements(By.XPath(id)).ToList();
            var tableHeader = unAssignedTasks[0].FindElements(By.TagName("th"));
            foreach (var eachData in tableHeader)
            {
                increment++;
                if (eachData.Text == tableHeaderName)
                {
                    break;
                }
            }
            for (int i = 2; i <= unAssignedTasks.Count; i++)
            {
                dataId = id + "[" + i + "]" + "/" + "td[" + increment + "]";
                var dataValue = webDriver.FindElement(By.XPath(dataId)).Text;
                if (dataValue.Contains(stateName))
                {
                    Assert.IsTrue(true);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Assert.IsTrue(false);
            }
        }

        [Given(@"I verify that a list of all active tasks is displayed")]
        [Then(@"I verify that a list of all active tasks is displayed")]
        public void GivenIVerifyThatAListOfAllActiveTasksIsDisplayed()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Tasks Result Table"))).elementId;
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(id)));
            IWebElement resultTable = webDriver.FindElement(By.XPath(id));           
            var tableRows = resultTable.FindElements(By.TagName("tr")).ToList();
            var eachRowData = tableRows[1].FindElements(By.TagName("td")).ToList();            
            var dataLink=eachRowData[0].FindElement(By.TagName("a"));
            if (dataLink.GetAttribute("href").Contains("fieldtaskstatus/edit"))
            {
                gblTaskNumber = dataLink.Text;
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [Given(@"I select the checkbox '([^']*)'")]
        [When(@"I select the checkbox '([^']*)'")]
        [Then(@"I select the checkbox '([^']*)'")]
        public void GivenISelectTheCheckbox(string checkBoxName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(checkBoxName))).elementId;
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));
            webDriver.FindElement(By.Id(id)).Click();

        }

        [Given(@"I select the checkbox '([^']*)' on Change Column Views")]
        [Then(@"I select the checkbox '([^']*)' on Change Column Views")]
        public void GivenISelectTheCheckboxOnChangeColumnViews(string checkBoxName)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals(checkBoxName))).elementId;
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(id)));
            webDriver.FindElement(By.XPath(id)).Click();
            System.Threading.Thread.Sleep(1000);
        }

        [Given(@"I deselect the checkbox '([^']*)' on Change Column Views")]
        [Then(@"I deselect the checkbox '([^']*)' on Change Column Views")]
        public void GivenIDeselectTheCheckboxOnChangeColumnViews(string checkBoxName)
        {
            GivenISelectTheCheckboxOnChangeColumnViews(checkBoxName);
        }

        [Given(@"I verify for color-coded technician statuses are displayed")]
        [Then(@"I verify for color-coded technician statuses are displayed")]
        public void GivenIVerifyForColor_CodedTechnicianStatusesAreDisplayed()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            Dictionary<string , string> colourMap = new Dictionary<string, string>()            
            {
                {"//div[text()='OnCall']","90ff90"},
                {"//div[text()='OffCall']","c0c0c0"},
                {"//div[text()='Lunch']","2edcce"},
                {"//div[text()='Sick']","516bcc"},
                {"//div[text()='Meeting']","9f4453"},
                {"//div[text()='Remote Depot']","646231"},
                {"//div[text()='Training']","b35c3a"},
            };            
            var id = "";
            foreach(var row in colourMap)
            {
                id = row.Key;
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(id)));
                var bgColourRGBFormat = webDriver.FindElement(By.XPath(id)).GetCssValue("background-color");
                Console.WriteLine(bgColourRGBFormat);
                Color colourName = ParseColor(bgColourRGBFormat);
                Assert.IsTrue(colourName.Name.Contains(row.Value));
            }  
        }

        [Given(@"I verify that the column '([^']*)' is '([^']*)' as desired")]
        [Then(@"I verify that the column '([^']*)' is '([^']*)' as desired")]
        public void GivenIVerifyThatTheColumnIsAsDesired(string columnName, string status)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var flag = 0;
            gblMenuItemSelected = "fieldtaskstatus";                      
            var id = UIMap.UIElementMap.Find(z => (z.screen.Equals(gblMenuItemSelected) && z.elementName.Equals("Tasks Result Table Header"))).elementId;
            var tableHeader = webDriver.FindElement(By.XPath(id));
            var tableHeaderRow = tableHeader.FindElement(By.TagName("tr"));
            var tableHeaders = tableHeaderRow.FindElements(By.TagName("th"));
            foreach(var head in tableHeaders)
            {
                if(status.Equals("viewed"))
                {
                    var actualHead = head.FindElement(By.TagName("a")).Text;
                    if (actualHead.Contains(columnName))
                    {
                        Assert.IsTrue(true);
                        flag = 1;
                        break;
                    }
                }
            }
            if(flag ==0)
            {
                Assert.IsTrue(false);
            }
        }

            public Color ParseColor(string bgColourRGBFormat)
            {
                bgColourRGBFormat = bgColourRGBFormat.Trim();
                if (bgColourRGBFormat.StartsWith("#"))
                {
                    return ColorTranslator.FromHtml(bgColourRGBFormat);
                }
                else if (bgColourRGBFormat.StartsWith("rgb")) //rgb or argb
                {
                    int left = bgColourRGBFormat.IndexOf('(');
                    int right = bgColourRGBFormat.IndexOf(')');

                    if (left < 0 || right < 0)
                        throw new FormatException("rgba format error");
                    string noBrackets = bgColourRGBFormat.Substring(left + 1, right - left - 1);

                    string[] parts = noBrackets.Split(',');

                    int r = int.Parse(parts[0], CultureInfo.InvariantCulture);
                    int g = int.Parse(parts[1], CultureInfo.InvariantCulture);
                    int b = int.Parse(parts[2], CultureInfo.InvariantCulture);

                    if (parts.Length == 3)
                    {
                        return Color.FromArgb(r, g, b);
                    }
                    else if (parts.Length == 4)
                    {
                        float a = float.Parse(parts[3], CultureInfo.InvariantCulture);
                        return Color.FromArgb((int)(a * 255), r, g, b);
                    }
                }
                throw new FormatException("Not rgb, rgba or hexa color string");          

        }


        [Then(@"New tasks should be created and I fetch the task numbers")]
        [When(@"New tasks should be created and I fetch the task numbers")]
        public void ThenNewTasksShouldBeCreatedAndIFetchTheTaskNumbers()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            List<IWebElement> resultRows = webDriver.FindElements(By.XPath("//div[@id='ctl0_MainContent_bar_resultTable']/table//tr")).ToList();
            int r = resultRows.Count();
            List<String> rowValues = new List<String>();
            for (int j = 2; j <= r; j++)
            {
                String taskNumberForEachRow = webDriver.FindElement(By.XPath("//div[@id='ctl0_MainContent_bar_resultTable']/table//tr[" + (j) + "]/td[2]")).Text;
                rowValues.Add(taskNumberForEachRow);
            }
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

        [When(@"I search for the task number and click on the task")]
        public void WhenISearchForTheTaskNumberAndClickOnTheTask()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            List<IWebElement> tableRows = webDriver.FindElements(By.XPath("//table[@class='datalist']/tbody/tr")).ToList();
            var rowTD = 0;
            for (int k = 2; k < tableRows.Count; k++)
            {
                IList<IWebElement> tdAll = tableRows[k].FindElements(By.XPath("//table[@class='datalist']/tbody/tr/td[2]/a")).ToList();
                foreach (IWebElement td in tdAll)
                {
                    var path = td.Text;
                    Console.WriteLine(path);
                    if (path.Contains(gblTaskNumberForBulkUpload[0]))
                    {
                        td.Click();
                        System.Threading.Thread.Sleep(2000);
                        rowTD = 1;
                        break;
                    }
                }
                if (rowTD == 1)
                {
                    rowTD = 0;
                    break;
                }
            }
        }

        [When(@"Status of the task is updated as TAKEN")]
        [Then(@"Status of the task is updated as TAKEN")]
        public void WhenStatusOfTheTaskIsUpdatedAsTAKEN()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            List<IWebElement> tableRows = webDriver.FindElements(By.XPath("//table[@class='datalist']/tbody/tr")).ToList();
            for (int k = 2; k < tableRows.Count; k++)
            {
                IList<IWebElement> tdAll = tableRows[k].FindElements(By.XPath("//table[@class='datalist']/tbody/tr/td[2]/a")).ToList();
                foreach (IWebElement td in tdAll)
                {
                    var path = td.Text;
                    if (path.Contains(gblTaskNumberForBulkUpload[0]))
                    {
                        var taskStatus = td.FindElement(By.XPath("//ancestor::td/following-sibling::td[3]")).Text.Trim();
                        Assert.AreEqual("TAK", taskStatus);
                        break;
                    }
                }
            }
        }

        [When(@"I search for the multiple task numbers and click on the corresponding check box")]
        public void WhenISearchForTheMultipleTaskNumbersAndClickOnTheCorrespondingCheckBox()
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            List<IWebElement> taskNumbers = webDriver.FindElements(By.XPath("//table[@class='datalist']/tbody/tr/td[2]/a")).ToList();
            var flag = 0;
            for (int t = 3; t <= taskNumbers.Count; t++)
            {
                var path = taskNumbers[t - 2].Text;
                Console.WriteLine(path);
                for (int i = 1; i < gblTaskNumberForBulkUpload.Length; i++)
                {
                    if (path.Contains(gblTaskNumberForBulkUpload[i]))
                    {
                        var taskChkBox = webDriver.FindElement(By.XPath("//table[@class='datalist']/tbody/tr[" + t + "]/td[1]/input"));
                        taskChkBox.Click();
                        System.Threading.Thread.Sleep(2000);
                        flag++;
                        break;
                    }
                }
                if (flag == 2)
                {
                    flag = 0;
                    break;
                }
            }
        }

        [When(@"I have clicked '([^']*)' button on Mobile Portal")]
        public void WhenIHaveClickedButton(string button)
        {
            var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
            var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            var id = BSuiteE2ERegressionTest.Models.BSuite.MobilePortal.UIMap.UIElementMap.Find(z => (z.elementName.Equals(button))).elementId;
            webDriver.FindElement(By.XPath(id)).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"Status of the tasks is updated as TAKEN")]
        [Then(@"Status of the tasks is updated as TAKEN")]
        public void WhenStatusOfTheTasksIsUpdatedAsTAKEN()
        {
            {
                var webDriver = gblOjectContainer.Resolve<OpenQA.Selenium.IWebDriver>();
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
                List<IWebElement> tableRows = webDriver.FindElements(By.XPath("//table[@class='datalist']/tbody/tr")).ToList();
                var flag = 0;
                var flag1 = 0;
                for (int k = 2; k < tableRows.Count; k++)
                {
                    IList<IWebElement> tdAll = tableRows[k].FindElements(By.XPath("//table[@class='datalist']/tbody/tr/td[2]/a")).ToList();
                    foreach (IWebElement td in tdAll)
                    {
                        var path = td.Text;
                        Console.WriteLine(path);
                        for (int i = 1; i < gblTaskNumberForBulkUpload.Length; i++)
                        {
                            if (path.Contains(gblTaskNumberForBulkUpload[i]))
                            {
                                var taskStatus = td.FindElement(By.XPath("//ancestor::td/following-sibling::td[3]")).Text.Trim();
                                Assert.AreEqual("TAK", taskStatus);
                                flag++;
                                break;
                            }
                        }
                        if (flag == 2)
                        {
                            flag = 0;
                            flag1 = 1;
                            break;
                        }
                    }
                    if (flag1 == 1)
                    {
                        flag1 = 0;
                        break;
                    }
                }
            }
        }
    }
}

