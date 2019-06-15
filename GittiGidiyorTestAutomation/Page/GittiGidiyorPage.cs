using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestAutomation.Page
{
    [Binding]
    [TestFixture]
    public class GittiGidiyorPage : Base
    {
        [FindsBy(How = How.Id, Using = "later-subscription-button")]
        public IWebElement BtnCloseSubscription { get; set; }

        [FindsBy(How = How.ClassName, Using = "profile-icon-title")]
        public IWebElement BtnProfileIcon { get; set; }

        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement BtnSignin { get; set; }

        public GittiGidiyorPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void CloseSubscriptionPopUp()
        {
            Click(BtnCloseSubscription);
        }

        public void HoverLogin()
        {
            Hover(BtnProfileIcon);
        }
        public void ClickSigninButton()
        {
            Click(BtnSignin);
        }
        
    }
}
