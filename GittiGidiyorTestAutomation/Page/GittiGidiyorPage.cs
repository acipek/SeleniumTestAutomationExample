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

        [FindsBy(How = How.CssSelector, Using = ".profile-icon-container~.profile-icon-title")]
        public IWebElement BtnProfileIcon { get; set; }

        [FindsBy(How = How.Id, Using = "SignIn")]
        public IWebElement BtnSignin { get; set; }

        [FindsBy(How = How.Id, Using = "L-UserNameField")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "L-PasswordField")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "gg-login-enter")]
        public IWebElement BtnLogin { get; set; }

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

        public void FillLoginInfo(string email, string password)
        {
            SetText(TxtEmail, email);
            SetText(TxtPassword, password);
        }

        public void ClickSigninButton()
        {
            Click(BtnSignin);
        }

        public void ClickLoginButton()
        {
            Click(BtnLogin);
        }
    }
}
