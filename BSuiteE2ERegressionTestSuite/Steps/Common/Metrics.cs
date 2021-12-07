using System;
using System.Collections.Generic;
using System.Text;

namespace BSuiteE2ERegressionTest
{
    public static class Metrics
    {
        /// <summary>
        /// Title of the Automated Regression Test Suite
        /// </summary>
        public static string RegressionTestSuiteTitle { get; set; } = String.Empty;
        /// <summary>
        /// Version Description Of Software Under Test - Bravo Host
        /// </summary>
        public static string BSuiteSoftwareVersion { get; set; } = String.Empty;
        /// <summary>
        /// Browser Name
        /// </summary>
        public static string BrowserName = string.Empty;
        /// <summary>
        /// Browser Version
        /// </summary>
        public static string BrowserVersion = string.Empty;
        /// <summary>
        /// Platform Name
        /// </summary>
        public static string PlatformName;
        /// <summary>
        /// Planned number of regression tests to be automated
        /// </summary>
        public static int Planned { get; set; } = 0;
        /// <summary>
        /// Actual number of regression tests automated and executed
        /// </summary>
        public static int Actual { get; set; } = 0;
        /// <summary>
        /// The number of tests that have a most recent result of pass.
        /// </summary>
        public static int Passed { get; set; } = 0;
        /// <summary>
        /// The number of tests that have a most recent result of failed.
        /// </summary>
        public static int Failed { get; set; } = 0;
        /// <summary>
        /// The number of tests that cannot be executed completely to the last step of the test. 
        /// For manual tests, this means the tester could not execute all the steps of the test. 
        /// For automated tests, the automated testing tool reports a passing result, 
        /// but the human test analyst determines that the test was invalid using information 
        /// outside the scope of what the automated testing tool can report.
        /// </summary>
        public static int Blocked { get; set; } = 0;
        /// <summary>
        /// Expected Test Coverage
        /// </summary>
        public static int ExpectedTestCoverage { get; set; } = 0;
        /// <summary>
        /// Actual Test Coverage
        /// </summary>
        public static int ActualTestCoverage { get; set; } = 0;
        /// <summary>
        /// Regression Test Run Start Time
        /// </summary>
        public static DateTime RegressionTestRunStartTime { get; set; } = DateTime.Now;
        /// <summary>
        /// Regression Test Run End Time
        /// </summary>
        public static DateTime RegressionTestRunEndTime { get; set; } = DateTime.Now;
        /// <summary>
        /// Regression Test Run Duration
        /// </summary>
        public static TimeSpan RegressionTestRunTotalTime { get; set; } = new TimeSpan(0, 0, 0, 0);

        /// <summary>
        /// Total number of Positive Scenarios (Happy Paths) executed
        /// </summary>
        public static int NumberOfPositiveScenarios { get; set; } = 0;

        /// <summary>
        /// Total number of Negative Scenarios (Edge Cases) executed
        /// </summary>
        public static int NumberOfNegativeScenarios { get; set; } = 0;
        /// <summary>
        /// The team member who initiated the automated regression test event
        /// </summary>
        public static string RegressionTestRunInitiatedBy => System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        /// <summary>
        /// The computer from which the automated regression test event was initiated from
        /// </summary>
        public static string RegressionTestRunInitiatedFrom => System.Net.Dns.GetHostName();
    }
}
