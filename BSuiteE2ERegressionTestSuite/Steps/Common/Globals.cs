using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BSuiteE2ERegressionTest
{
    public sealed partial class StepDefinitions
    {
        #region Test Framework related globals

        private static int gblTestStepCounter;
        private static string gblTestCaseId = "";
        public static Config gblConfig; //Overall Test Framework Configuration for the current test run event
        public static object gblCurrentPage;
        public static string gblMenuItemSelected;
        public static (string UserName, string Password, string Role) gblCurrentUser;
        public static string gblLog = "";
        public string yestFrom = "";
        public string yestTo = "";
        public String[] gblTaskNumberForBulkUpload = new String[3];
        public string gblWareHouseId = "";
        public string gblTaskNumber = "";
        public string gbluserFullName = "";
        public static List<string> gblRoleTypes = new List<string>()
        {
            "After Hours Supervisor",
            "Agent Logistics (Stock Take)",
            "Agent Manager",
            "Agent Manager (Logistics)",
            "Agent Technician",
            "Agent View",
            "BSuite Documentation",
            "Call Desk + Logistics RO",
            "Call Desk Contractor",
            "Call Desk Manager",
            "Call Desk Manager (Service Plan Admin)",
            "Call Desk OCC",
            "Call Desk Supervisor",
            "Call Desk Technician",
            "Client Admin",
            "Client Technician",
            "Contact Centre Operator",
            "Dashboard View",
            "Field Supervisor",
            "Field Supervisor (Stocktake)",
            "Field Tech + Logistics",
            "Field Tech + Workshop + Logistics",
            "Field Technician",
            "Finance",
            "Finance Admin",
            "Human Resources",
            "Kamco Client",
            "Logistics + Call Desk Technician",
            "Logistics + Reports",
            "Logistics Admin",
            "Logistics Admin (Limited Call Desk)",
            "Logistics Admin (Limited Call Desk) + PO",
            "Logistics Storeman",
            "Logistics Storeman (Casual)",
            "Logistics Storeman (Limited CallDesk)",
            "Logistics Supervisor",
            "Logistics Technician",
            "National Inventory",
            "National Workshop Manager",
            "Part Type Creation",
            "Projects",
            "Projects - SME",
            "Purchasing",
            "Service Delivery Manager",
            "Staging",
            "State Inventory",
            "State Supply Chain Manager",
            "Stock Take",
            "Stocktake Reports",
            "System Admin",
            "Trainer",
            "VG Agent Logistics",
            "Workshop + Logistics",
            "Workshop Admin",
            "Workshop Admin (NEW)",
            "Workshop Supervisor",
            "Workshop Technician",
            "Workshop Technician (NEW)",
            "Worm"
        };
        #endregion
    }
}
