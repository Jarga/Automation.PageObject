﻿using AutomationCore;
using AutomationCore.Shared;
using AutomationCore.Shared.Exceptions;

namespace TestAutomation.Applications.ClearVoiceSurveys.Pages
{
    public class Dashboard : WebPage
    {
        public Dashboard(ITestableWebPage baseObject): base(baseObject)
        {
            RegisterSubElement("Sign Out", new { Id = "ctl01_ucHeader_ucLogin_lbSignOut"});
            RegisterSubElement("Your EmailDashboard Title", new { TagName = "span", InnerText = "Your EmailDashboard" });
            RegisterSubElement("Active Tab", new { TagName = "input", Class = "tabbutton_active" });
            RegisterSubElement("My Rewards Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnRewards"});
            RegisterSubElement("My Messages Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnInbox"});
            RegisterSubElement("My Achievements Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnAchievements"});
            RegisterSubElement("My Account Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnAccount"});
            RegisterSubElement("My Sweepstakes Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnSweepstakes"});
            RegisterSubElement("My Polls Tab", new { Id = "ctl01_cpBody_ucAccountInfo_cpAccountInfo_btnMyPolls"});
        }

        public FrontPage SignOut()
        {
            Click("Sign Out");

            FrontPage frontpage = New<FrontPage>();

            if (!frontpage.Exists("Log In", 120))
            {
                throw new PageNotDisplayedException("Log In Button is not visible on the screen, the Front Page is not displayed correctly!");
            }

            return frontpage;
        }
    }
}