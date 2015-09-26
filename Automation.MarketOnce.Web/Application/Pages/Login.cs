﻿using Automation.Common;
using Automation.Common.Initialization.Interfaces;
using Automation.MarketOnce.Web.Application.Pages.Admin;

namespace Automation.MarketOnce.Web.Application.Pages
{
    public class Login : WebPage
    {
        public Login(ITestConfiguration baseObject)
            : base(baseObject)
        {
            RegisterSubElement("Email", new { TagName = "input", Type = "text", Id = "UserName" });
            RegisterSubElement("Password", new { TagName = "input", Type = "password", Id = "Password"});
            RegisterSubElement("Log In", new { TagName = "input", Type = "image", Id = "ucLogin_Login1_LoginButton" });

            FindSubElement("Email", 120);
            TestConfiguration.TestOutput.WriteLineWithScreenshot("Opened Login Page", GetScreenshot());
        }

        public Welcome LogIn(string email, string password)
        {
            var emailElement = FindSubElement("Email");

            //For some reason chrome does not want to type the first time you hit the site...
            emailElement.Clear();
            emailElement.Type("Empty");

            emailElement.Clear();
            emailElement.Type(email);

            Type("Password", password);

            Click("Log In");

            return New<Welcome>();
        }
    }
}
