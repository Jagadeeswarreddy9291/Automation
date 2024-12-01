using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Support
{
    public class WebDriverWaits : Basetest
    {

        public  DefaultWait<IWebDriver> defaultWait { get; set; }
        public  WebDriverWait webDriverWait { get; set; }

        public WebDriverWaits()
        {
            defaultWait = new DefaultWait<IWebDriver>(webDriver);
            defaultWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            defaultWait.PollingInterval = TimeSpan.FromSeconds(1);
            defaultWait.Timeout = TimeSpan.FromSeconds(100);
            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(100));
        }
    }

}
