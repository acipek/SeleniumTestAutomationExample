using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyorTestAutomation.Page
{
    public class GittiGidiyorLoginPage : Base
    {
        public GittiGidiyorLoginPage(IWebDriver _driver) : base(_driver)
        {

        }

        [FindsBy(How = How.Id, Using = "L-UserNameField")]
        public IWebElement TxtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "L-PasswordField")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "gg-login-enter")]
        public IWebElement BtnLogin { get; set; }


        public void FillLoginInfo(string email, string password)
        {
            SetText(TxtEmail, email);
            SetText(TxtPassword, password);
        }


        public void ClickLoginButton()
        {
            Click(BtnLogin);
        }
    }
}

