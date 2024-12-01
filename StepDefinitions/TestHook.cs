using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Support;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Automation.StepDefinitions
{
    [Binding]
    public class TestHook : Basetest
    {
        [BeforeScenario]
        public void LaunchBrowser()
        {
            LaunchBasetest();
        }

        [AfterScenario]
        public void closetest()
        {
            webDriver.Close();
        }

     
    }
}
