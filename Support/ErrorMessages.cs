using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Support
{
    public class ErrorMessages
    {
        public static Dictionary<string,string> errorMessages =  new Dictionary<string, string>() {
            { "duplicateaccountcreation" ,"There is already an account with this email address. If you are sure that it is your email address, click here to get your password and access your account."},
            {"loginfailed","The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later." }
        };
    } 
}
