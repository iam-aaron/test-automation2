﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.DesktopPortal
{
    public static class UIMap
    {
        public static readonly Dictionary<string, (string resourceName, string windowTitle)> UIPageMap = new Dictionary<string, (string, string)>()
        {
            //Call Centre
                {"Admin", ("adminmenulayout","Admin")},
                {"Call Centre", ("calldeskmenulayout","CallDesk")},
                {"Add Task", ("calldesk", "CallDesk")},
                {"Add Task - FieldTask", ("calldesk", "CallDesk")},
                {"PreStart", ("prestart", "preStart")},
                {"Import FieldTasks",("bulkload/tasks","BSuite")},
                {"BSuite",("bulkload/tasks","BSuite")},
                {"Task Status Screen",("fieldtaskstatus","FieldTaskStatus")},
                {"A - FieldTaskEdit",("fieldtaskstatus/edit","fieldtaskstatusedit")},
                {"FieldTaskAuditLog",("/fieldtaskauditlog/fieldtaskedit/fieldtask","FieldTaskAuditLog")},
                {"Tasks by Watch List", ("taskbytech","TechTask")},
                {"Admin Warehouse", ("storagelocation", "Warehouse")},
                {"Reports", ("reportsmenulayout","Reports")},
                {"Prestart Desktop", ("report/prestartdesktop","Prestart Desktop")},
                {"Edit Watch List Preference", ("taskbytech","TechTask")},
                {"PreStart link", ("taskbytech", "taskByTech")},
        };

        public static readonly List<(string screen, string elementName, string elementId)> UIElementMap = new List<(string, string, string)>(){
            //Call Centre
            ("calldesk", "Site", "ctl0_MainContent_SiteList"),
            ("calldesk", "Contract/WorkType", "ctl0_MainContent_WorkTypeList"),
            ("calldesk", "Add Task", "ctl0_MainContent_AddFieldTaskButton" ),
            ("calldesk", "Site", "ctl0_MainContent_SiteList" ),
            ("calldesk", "Contact", "ctl0_MainContent_SiteContact" ),
            ("calldesk", "App. Start Time", "ctl0_MainContent_appointmentStartTime" ),
            ("calldesk", "App. Start Hour", "ctl0_MainContent_fromHourBox" ),
            ("calldesk", "App. Start Minute", "ctl0_MainContent_fromMinuteBox" ),
            ("calldesk", "App. End Time", "ctl0_MainContent_appointmentEndTime" ),
            ("calldesk", "App. End Hour", "ctl0_MainContent_toHourBox" ),
            ("calldesk", "App. End Minute", "ctl0_MainContent_toMinuteBox" ),
            ("calldesk", "Serial Number", "ctl0_MainContent_SerialNumber" ),
            ("calldesk", "Part", "ctl0_MainContent_PartTypes" ),
            ("calldesk", "Part Status", "ctl0_MainContent_EquipmentStatusList" ),
            ("calldesk", "Position", "ctl0_MainContent_Position" ),
            ("calldesk", "Similar Tasks", "ctl0_MainContent_SimilarTasks" ),
            ("calldesk", "Billable", "ctl0_MainContent_Billable" ),
            ("calldesk", "Task Status", "ctl0_MainContent_FieldTaskStatusList" ),
            ("calldesk", "Priority", "ctl0_MainContent_PriorityList" ),
            ("calldesk", "Client Ref #", "ctl0_MainContent_ClientReferenceNumber" ),
            ("calldesk", "Problem Category", "ctl0_MainContent_ProblemCategoryList" ),
            ("calldesk", "Problem Code", "ctl0_MainContent_ProblemList" ),
            ("calldesk", "Problem Desc", "ctl0_MainContent_ProblemDescription" ),
            ("calldesk", "Client Notes", "ctl0_MainContent_ClientNotes" ),
            ("calldesk", "Call Centre Notes", "ctl0_MainContent_CallDeskNotes" ),
            ("calldesk", "Save", "ctl0_MainContent_saveButton" ),
            ("calldesk", "Task ##", "ctl0_MainContent_FieldTaskNumber"),
            ("calldesk", "Details of Client Targets For This Task", "ctl0_MainContent_FieldTaskTargets" ),
            ("calldesk", "Finish", "ctl0_MainContent_CancelFieldTask" ),
            ("calldesk", "Add Another", "ctl0_MainContent_AnotherFieldTask" ),
            ("calldesk", "TaskNumber", "//span[@id='ctl0_MainContent_FieldTaskNumber']/b/a"),
            ("prestart", "Lets complete your Pre Start Checklist for today ", "ctl0_MainContent_AnotherFieldTask" ),
            ("prestart", "Submit", "ctl0_MainContent_SubmitButton" ),
            ("bulkload/tasks", "WorkType", "ctl0_MainContent_workType"),
            ("bulkload/tasks", "File", "ctl0_MainContent_FileUploader"),
            ("bulkload/tasks", "Upload", "ctl0$MainContent$ctl2"),
            ("bulkload/tasks", "Yes", "//div[@id='continuePanel']/input[1]"),
            ("fieldtaskstatus", "Task No", "ctl0_MainContent_taskNumber"),
            ("fieldtaskstatus", "Search Field Tasks", "ctl0_MainContent_search"),
            ("fieldtaskstatus", "Search Tasks Result", "//table[@class='DataList']/tbody/tr[1]/td[1]"),
            ("fieldtaskstatus", "Tasks Result Table", "//table[@class='DataList']/tbody"),
            ("fieldtaskstatus", "Tasks Result Table Header", "//table[@class='DataList']/thead"),
            ("fieldtaskstatus/edit", "Task No Status", "ctl0_MainContent_TaskNumberLabel"),
            ("fieldtaskstatus/edit", "Audit Log", "ctl0_MainContent_AuditLogButton"),
            ("fieldtaskstatus/edit", "Task Status", "ctl0_MainContent_FieldTaskStatusList"),
            ("fieldtaskstatus/edit", "Technician", "ctl0_MainContent_TechnicianList"),
            ("fieldtaskstatus/edit", "Save", "ctl0_MainContent_SaveButton"),
            ("fieldtaskstatus/edit", "Yes", "ctl0_MainContent_CancelConfirmYes"),
            ("storagelocation", "Warehouse Name", "ctl0_MainContent_SearchName" ),
            ("storagelocation", "Search", "ctl0_MainContent_SearchButton" ),
            ("storagelocation", "Show Details","//span[@id='ctl0_MainContent_storageLocationList']/table/tbody/tr//select" ),
            ("storagelocation", "Cancel","ctl0$MainContent$ctl4" ),
            ("storagelocation", "Alias","ctl0_MainContent_SearchAlias" ),
            ("storagelocation", "Show Warehouses Under","ctl0_MainContent_showLocationBtn" ),
            ("storagelocation", "Reset","//span[@id='ctl0_MainContent_TreeLabel']/input" ),            
            ("report/prestartdesktop", "fromDateReport", "ctl0_MainContent_fromDateReport" ),
            ("report/prestartdesktop", "toDateReport", "ctl0_MainContent_toDateReport" ),
            ("report/prestartdesktop", "Output To CSV", "//input[@value='Output To CSV']" ),
            ("taskbytech", "Edit Preferences", "ctl0_MainContent_AddButton" ),
            ("taskbytech", "All Technicians", "ctl0_MainContent_outTechList" ),
            ("taskbytech", "Technicians currently on watch list", "ctl0_MainContent_inTechList" ),
            ("taskbytech", "Add Technicians", "ctl0_MainContent_addTechBtn" ),
            ("taskbytech", "Remove Technicians", "ctl0_MainContent_removeTechBtn" ),
            ("taskbytech", "Unassigned Tasks By State", "ctl0_MainContent_unassignedStateList" ),
            ("taskbytech", "Unassigned Tasks By WorkType", "ctl0_MainContent_unassignedWorkTypeList" ),
            ("taskbytech", "Unassigned Add State WorkType", "ctl0_MainContent_addUnassignedBtn" ),
            ("taskbytech", "Pending Tasks By State", "ctl0_MainContent_pendingStateList" ),
            ("taskbytech", "Pending Tasks By WorkType", "ctl0_MainContent_pendingWorkTypeList" ),
            ("taskbytech", "Pending Add State WorkType", "ctl0_MainContent_addPendingBtn" ),
            ("taskbytech", "Save and Update", "ctl0_MainContent_EditButton" ),
            ("taskbytech", "Unassigned Panel", "//div[@id='ctl0_MainContent_UnassignedPanel']/table/tbody" ),
            ("taskbytech", "All Agents", "ctl0_MainContent_outAgentList" ),
            ("taskbytech", "Agents currently on watch list", "ctl0_MainContent_inAgentList" ),
            ("taskbytech", "Add Agents", "ctl0_MainContent_addAgentBtn" ),
            ("taskbytech", "Remove Agents", "ctl0_MainContent_removeAgentBtn" ),
            ("taskbytech", "Assigned to Techs","ctl0_MainContent_ShowTechLabel" ),
            ("taskbytech", "Assigned to Agents", "ctl0_MainContent_ShowAgentBtn" ),
            ("taskbytech", "Unassigned", "ctl0_MainContent_ShowUnassignedBtn" ),
            ("taskbytech", "Pending", "ctl0_MainContent_ShowPendingBtn" ),
            ("taskbytech", "Full Screen Mode", "ctl0_MainContent_toggleDisplayButton" ),
            ("taskbytech", "Edit Preferences", "ctl0_MainContent_AddButton" ),
            ("taskbytech", "Show Legend", "ctl0_MainContent_LegendButton" ),
            ("taskbytech", "Assigned to Techs Table", "//div[@id='ctl0_MainContent_TechPanel']/table/tbody/tr" ),
            ("taskbytech", "Assigned to Agents Table", "//div[@id='ctl0_MainContent_AgentPanel']/table/tbody/tr" ),
            ("taskbytech", "Unassigned Table", "//div[@id='ctl0_MainContent_UnassignedPanel']/table/tbody/tr" ),
            ("taskbytech", "Pending Table", "//div[@id='ctl0_MainContent_PendingPanel']/table/tbody/tr" ),
            ("fieldtaskstatus", "View Status Legend", "ctl0_MainContent_changeLegendVisibility"),
            ("fieldtaskstatus", "Change Column Views", "ctl0_MainContent_changeColumnVisibilities"),
            ("fieldtaskstatus", "State", "//label[text()='State']/preceding-sibling::input"),
            ("fieldtaskstatus", "APP_END", "//label[text()='APP_END']/preceding-sibling::input"),
            ("fieldtaskstatus", "save view", "ctl0_MainContent_saveColumnBtn"),
        };


    }
}