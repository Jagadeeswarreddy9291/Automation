using Automation.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace Automation.StepDefinitions
{
    [Binding]
    public class SignInStepDefinitions : Basetest
    {
        public static WebDriverWaits webDriverWaits;
        SignInStepDefinitions()
        {
            webDriverWaits = new WebDriverWaits();
        }
        [Given(@"I navigate to the website URL")]
        public void GivenINavigateToTheWebsiteURL(Table table)
        {
            var url = BaseData.baseurlsdata["magento"];
            webDriver.Navigate().GoToUrl(url);
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Then(@"I should land on the required page")]
        public void ThenIShouldLandOnTheRequiredPage(Table table)
        {
            var expected = TableData.convertTableToDic(table)["title"];
            var title = webDriver.Title;
            Assert.AreEqual(title, expected);
        }

        [When(@"I click on the Create an Account")]
        public void WhenIClickOnTheCreateAnAccount()
        {
            webDriverWaits.defaultWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PageElements.createAnAccountHomePageUrl))).Click();
        }

        [When(@"I fill in the account creation details")]
        public void WhenIFillInTheAccountCreationDetails(Table table)
        {
            var accountDetails = TableData.convertTableToDic(table);
            webDriver.FindElement(By.XPath(PageElements.firstName)).SendKeys(accountDetails["firstname"]);
            webDriver.FindElement(By.XPath(PageElements.lastName)).SendKeys(accountDetails["lastname"]);
            webDriver.FindElement(By.XPath(PageElements.email_address)).SendKeys(accountDetails["email"]);
            webDriver.FindElement(By.XPath(PageElements.password)).SendKeys(accountDetails["password"]);
            webDriver.FindElement(By.XPath(PageElements.password_confirmation)).SendKeys(accountDetails["password_conf"]);

        }

        [When(@"I click on the Create an Account button")]
        public void WhenIClickOnTheCreateAnAccountButton()
        {
            webDriverWaits.defaultWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PageElements.createAnAccountButton))).Click();
        }

        [Then(@"I should see the user details on the logged-in account page")]
        public void ThenIShouldSeeTheUserDetailsOnTheLogged_InAccountPage(Table table)
        {
            var name = TableData.convertTableToDic(table)["username"];
            var actualName = webDriverWaits.defaultWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PageElements.userloggedInVerificationXpath))).Text;
            Assert.IsTrue(webDriver.FindElement(By.XPath(PageElements.userloggedInVerificationXpath)).Displayed);
            Assert.AreEqual(name, actualName);
        }
        [Then(@"Verify error message")]
        public void ThenVerifyErrorMessage(Table table)
        {
            var error = ErrorMessages.errorMessages[TableData.convertTableToDic(table)["error"]];

            var text = webDriverWaits.defaultWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@role='alert']"))).Text;
            Assert.AreEqual(error, text);
        }


        [Then(@"Verify mandetory field error messages")]
        public void VerifyMandetoryFieldErrorMessages()
        {
            webDriverWaits.defaultWait.Until(ExpectedConditions.ElementIsVisible(By.XPath(PageElements.createAnAccountButton))).Click();
            var elements = webDriver.FindElements(By.XPath("//div[@class='mage-error']"))
                        .Select(x => x.GetAttribute("id"));
            var expectedIds = new List<string> { "firstname-error", "lastname-error", "email_address-error", "password-error", "password-confirmation-error" };
            Assert.IsTrue(expectedIds.All(id => elements.Contains(id)), "Some ids are missing in the elements.");
        }
    }

}
