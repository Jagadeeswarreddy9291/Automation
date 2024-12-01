using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Support
{

    public class PageElements
    {
        public static string createAnAccountHomePageUrl = "//a[contains(text(),'Create an Account')]";
        public static string signInHomePageUrl = "//a[contains(text(),'Sign In')]";
        public static string firstName = "//input[@id='firstname']";
        public static string lastName = "//input[@id='lastname']";
        public static string email_address = "//input[@id='email_address']";
        public static string password = "//input[@id='password']";
        public static string password_confirmation = "//input[@id='password-confirmation']";


        public static string createAnAccountButton = "//button[@type='submit'][@title='Create an Account']";
        public static string signinAnAccountButton = "//button[@type='submit'][@name='send']";

        public static string userloggedInVerificationXpath = "//*[@class='greet welcome']/*[@class='logged-in']";

        public static string loginEmail  = "//input[@id='email']";
        public static string loginpass = "//input[@id='pass']";

        public static string signouttoggle = " //*[@class='action switch']";
        public static string signout = "//div[@class='customer-menu']/ul/li/a[contains(text(),'Sign Out')]";
        public static string signoutText = "//*[contains(text(),'You are signed out')]";
    }
}
