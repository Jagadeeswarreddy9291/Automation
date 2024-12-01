using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Support
{
    public class Basetest 
    {
        public static IWebDriver webDriver { get; set; }

        public void LaunchBasetest() {
            var webDriverType = System.Environment.GetEnvironmentVariable("browser");
            if (webDriverType != null && webDriverType.Equals("edge",StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new EdgeDriver();
            }
            else
            {
                webDriver = new ChromeDriver();
            }
            if (webDriver != null)
            {
                webDriver.Manage().Window.Maximize();
            }
        }  
    }
}
