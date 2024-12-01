using Automation.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.StepDefinitions
{
    [Binding]
    public class SigninStepDefination : Basetest
    {
        public static WebDriverWaits webDriverWaits;
        SigninStepDefination()
        {
            webDriverWaits = new WebDriverWaits();
        }
        [When(@"I click on the Sigin an Account")]
        public void WhenIClickOnTheSiginAnAccount()
        {
            webDriverWaits.defaultWait.Until(
                ExpectedConditions.ElementIsVisible(By.XPath(PageElements.signInHomePageUrl))).Click();
        }

        [When(@"I click on the Sign in Account button")]
        public void WhenIClickOnTheSignInAccountButton()
        {
            webDriverWaits.defaultWait.Until(
               ExpectedConditions.ElementIsVisible(By.XPath(PageElements.signinAnAccountButton))).Click();
        }

        [When(@"I fill in the account signin details")]
        public void WhenIFillInTheAccountCreationDetails(Table table)
        {
            var accountDetails = TableData.convertTableToDic(table);
            webDriver.FindElement(By.XPath(PageElements.loginEmail)).SendKeys(accountDetails["email"]);
            webDriver.FindElement(By.XPath(PageElements.loginpass)).SendKeys(accountDetails["password"]);
        }
      

        [Then(@"Click on Logout")]
        public void ClickonLogout()
        {
            
            webDriver.FindElement(By.XPath(PageElements.signouttoggle)).Click();
            webDriver.FindElement(By.XPath(PageElements.signout)).Click();
            webDriverWaits.defaultWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(PageElements.signoutText)));
        }

    }
}
