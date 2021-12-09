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
        public int gblCount = 0;
        public string gblCommonVariable = "";
        public string gblTaskNumber= "";
        public string gblNumberWithDate = "";
        public String[] gblTaskNumberForBulkUpload = new String[3];
        public string gblWareHouseId = "";
        public string gblClientRef = "";
        public string gblSerialNumber = "";
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

        public static Dictionary<string, List<Dictionary<string, object>>> gblUsers =
            new Dictionary<string, List<Dictionary<string, object>>>();
        public static int gblTestUserStartIndex = 100;
        public static int gblTestUserEndIndex = 110;
        public static OpenQA.Selenium.IWebDriver gblWebDriver;

        /// <summary>
        /// Collection of BSuite Roles and corresponding RoleIds 
        /// Valid as on 10-Nov-2021 Abhy Kizhakkepat
        /// This collection needs maintenance - 
        /// May need cleanup as roles get cleaned up or added in future
        /// </summary>
        public static Dictionary<int, string> gblRoles = new Dictionary<int, string>()
        {
            {1 ,"Call Desk Manager"},
            {2 ,"Call Desk Supervisor"},
            {3 ,"Call Desk Technician"},
            {4 ,"Field Technician"},
            {5 ,"Logistics Admin (Limited Call Desk)"},
            {6 ,"Agent Technician"},
            {7 ,"Client Technician"},
            {8 ,"Workshop Technician"},
            {9 ,"System Admin"},
            {10,"Trainer"},
            {11,"Agent View"},
            {12,"Call Desk Contractor"},
            {13,"Field Supervisor"},
            {14,"Call Desk OCC"},
            {15,"After Hours Supervisor"},
            {16,"Logistics + Call Desk Technician"},
            {17,"Workshop + Logistics"},
            {18,"Field Tech + Workshop + Logistics"},
            {19,"Field Tech + Logistics"},
            {20,"Call Desk + Logistics RO"},
            {21,"Logistics Storeman (Limited CallDesk)"},
            {22,"Logistics Supervisor"},
            {23,"Workshop Admin"},
            {24,"Logistics Storeman"},
            {25,"Worm"},
            {27,"Agent Manager"},
            {28,"National Workshop Manager"},
            {29,"Field Supervisor (Stocktake)"},
            {31,"Logistics Admin (Limited Call Desk) + PO"},
            {36,"Logistics Technician"},
            {46,"Logistics + Reports"},
            {47,"Logistics Admin"},
            {52,"Staging"},
            {53,"Client Admin"},
            {54,"Purchasing"},
            {55,"Finance"},
            {56,"Call Desk Manager (Service Plan Admin)"},
            {58,"Dashboard View"},
            {59,"Agent Manager (Logistics)"},
            {60,"VG Agent Logistics"},
            {61,"Human Resources"},
            {62,"Logistics Storeman (Casual)"},
            {63,"Finance Admin"},
            {64,"Service Delivery Manager"},
            {65,"Projects"},
            {66,"Projects - SME"},
            {67,"Kamco Client"},
            {68,"Agent Logistics (Stock Take)"},
            {69,"Stock Take"},
            {70,"Stocktake Reports"},
            {71,"Workshop Technician (NEW)"},
            {72,"Workshop Admin (NEW)"},
            {73,"Workshop Supervisor"},
            {74,"Contact Centre Operator"},
            {75,"National Inventory"},
            {76,"Part Type Creation"},
            {77,"BSuite Documentation"},
            {78,"State Inventory"},
            {79,"State Supply Chain Manager"},
        };
        #endregion
    }
}
