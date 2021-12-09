using System;
using System.Collections.Generic;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
{
    public static class UIMap
    {
        public static readonly Dictionary<string, (string resourceName, string windowTitle)> UIPageMap = new Dictionary<string, (string, string)>()
        {
                //{"BSuite on WAP", ("?AJAX=preStartChecklList", "preStartChecklList")},
                {"?AJAX=preStartChecklList", ("?AJAX=preStartChecklList", "preStartChecklList")},
                {"My Tasks", ("mobile?mytasks", "MobileMyTasks")},
                {"Status Update Task", ("mobile?taskstatus=1", "StatusUpdateTask")},
                {"My Slamm Assessment Page", ("mobile?siteSafeCheck=1", "mySlammAssessmentPage")},
                {"Create Fieldtask", ("mobile?taskstatus=1&createtask=1", "BSuite on WAP")},
                {"Work Log for Field Task", ("mobile?taskstatus=1", "Work Log for Field Task")},
                {"Please Select Cause Category", ("mobile?causeCatGroup=1", "Please Select Cause Category")},
        };
       
        public static readonly List<(string screen, string elementName, string elementId)> UIElementMap = new List<(string, string, string)>(){
                 ("?AJAX=preStartChecklList", "preStartChecklList", "BSuite on WAP" ),
                 ("?AJAX=preStartChecklList", "Submit", "preStartCompleted" ),
                 ("mobile?taskstatus=1&createtask=1", "Worktype", "createtask_worktype"),
                 ("mobile?taskstatus=1&createtask=1", "Site", "createtask_site"),
                 ("mobile?taskstatus=1&createtask=1", "Serial No", "createtask_serialno" ),
                 ("mobile?taskstatus=1&createtask=1", "Part", "createtask_part" ),
                 ("mobile?taskstatus=1&createtask=1", "Position", "createtask_position" ),
                 ("mobile?taskstatus=1&createtask=1", "Priority", "createtask_priority" ),
                 ("mobile?taskstatus=1&createtask=1", "Problem Category", "createtask_problemcategory" ),
                 ("mobile?taskstatus=1&createtask=1", "Problem Code", "createtask_problemcode" ),
                 ("mobile?taskstatus=1&createtask=1", "Problem Description", "createtask_problemdescription" ),
                 ("mobile?taskstatus=1&createtask=1", "Create Task", "//input[@value='Create Task']" ),
                 ("mobile?taskstatus=1&createtask=1", "TaskNumber", "//div[@id='createtask_InfoMsg']/a[1]" ),
                 ("mobile?taskdetails=1", "verifyWorktype", "//table/tbody/tr[2]/td[2]"),
                 ("mobile?taskdetails=1", "verifySite", "//table/tbody/tr[3]/td[2]"),
                 ("mobile?taskdetails=1", "verifyPosition", "//table/tbody/tr[15]/td[2]"),
                 ("mobile?taskdetails=1", "verifyProblemCategory", "//table/tbody/tr[20]/td[2]"),
                 ("mobile?taskdetails=1", "verifyProblemCode", "//table/tbody/tr[21]/td[2]"),
                 ("mobile?taskstatus=1", "Update", "//input[@id='Update']"),
                 ("mobile", "OK", "//input[@value='OK']"),
                 ("mobile?taskstatus=1", "Add Action", "//select[@name='actionType']"),
                 ("mobile?taskstatus=1", "Next »", "//input[@value='Next »']"),
                 ("mobile?toSearchPart", "Part In - Part No", "//input[@name='partcode_one']"),
                 ("mobile?toSearchPart", "Part In - Search", "//input[@name='search_one']"),
                 ("mobile?toSearchPart", "Part Out - Part No", "//input[@name='partcode_two']"),
                 ("mobile?toSearchPart", "Part Out - Search", "//input[@name='search_two']"),
                 ("mobile?toSearchPart", "Part Fault Desc", "//textarea[@name='wlActionComments']"),
                 ("mobile?toSearchPart", "AddAction", "//input[@value='Add Action']"),
                 ("mobile?taskstatus=1", "Close Work Log", "//input[@value='Close Work Log']"),
                 ("mobile?causeCatGroup=1", "Cause Category", "//select[@name='causeCategory']"),
                 ("mobile?causeCatGroup=1", "Cause Category Details", "//select[@name='causeCategoryDetails']"),
                 ("mobile?causeCatGroup=1", "Save", "//input[@value='Save']"),
                 ("mobile?causeCatGroup=1", "Status", "//select[@name='newTaskFieldStatus']"),
                 ("mobile?siteSafeCheck=1", "Submit", "my-slam-submit" ),
                 ("mobile?taskstatus=1", "Task Status", "//td[text()='Status']/following-sibling::td[1]" ),
                 ("mobile?mytasks", "taskNumber", "//table[@class='datalist']/tbody/tr/td[2]/a" ),
                 ("mobile", "ETA box", "//input[@name='enableSetEta']" ),
                 ("mobile", "Take Task", "//input[@value='Take Task(s)']" ),
                 ("mobile?taskstatus=1", "Update", "//input[@value='Update']" ),
                 ("mobile", "Continue", "//input[@value='Continue']" ),
                 
        };

        
    }
}
