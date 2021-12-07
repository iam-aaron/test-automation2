using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSuiteE2ERegressionTest.Models.BSuite.MobilePortal
{
    public interface IPage
    {
        /// <summary>
        /// Select Menu Item
        /// </summary>
        void SelectMenuLink(string menuItem);

        /// <summary>
        /// Home
        /// </summary>
        void Home();

        /// <summary>
        /// Logout
        /// </summary>
        void Logout();
    }
}
