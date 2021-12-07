using System;
using System.Collections.Generic;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
{
    public static class UIMap
    {
        public static readonly Dictionary<string, (string resourceName, string windowTitle)> UIPageMap = new Dictionary<string, (string, string)>()
        {
                {"BSuite on WAP", ("?AJAX=preStartChecklList", "preStartChecklList")},
                {"My Tasks", ("mobile?mytasks", "MobileMyTasks")},
                //{"BSuite on WAP", ("?AJAX=preStartChecklList", "preStartChecklList")},
                {"?AJAX=preStartChecklList", ("?AJAX=preStartChecklList", "preStartChecklList")},
        };

        public static readonly List<(string screen, string elementName, string elementId)> UIElementMap = new List<(string, string, string)>(){
                 ("?AJAX=preStartChecklList", "preStartChecklList", "BSuite on WAP" ),
                 ("?AJAX=preStartChecklList", "Submit", "preStartCompleted" ),
                 ("mobile?mytasks", "taskNumber", "//table[@class='datalist']/tbody/tr/td[2]/a" ),
                 ("mobile", "ETA box", "//input[@name='enableSetEta']" ),
                 ("mobile", "Take Task", "//input[@value='Take Task(s)']" ),
        };
    }
}
