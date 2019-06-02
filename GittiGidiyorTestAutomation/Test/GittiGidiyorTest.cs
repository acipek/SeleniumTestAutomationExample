using GittiGidiyorTestAutomation.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;
using TechTalk.SpecFlow;

namespace GittiGidiyorTestAutomation.Test
{
    [TestFixture]
    [Binding, Scope(Tag = "mytag")]
    public class GittiGidiyorTest
    {
        public IWebDriver webDriver;
        public GittiGidiyorPage gittiGidiyorPage;
        [BeforeScenario]
        public void Before()
        {
            string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("disable-popup-blocking");
            chromeOptions.AddArguments("ignore-certificate-errors");
            chromeOptions.AddArguments("disable-translate");
            chromeOptions.AddArguments("disable-automatic-password-saving");
            chromeOptions.AddArguments("allow-silent-push");
            chromeOptions.AddArguments("disable-infobars");

            webDriver = new ChromeDriver(driverPath, chromeOptions);

            gittiGidiyorPage = new GittiGidiyorPage(webDriver);
        }


        [StepDefinition(@"GittiGidiyor anasayfası açılır")]
        public void OpenHomePage()
        {
            webDriver.Navigate().GoToUrl("https://www.gittigidiyor.com");
        }

        [StepDefinition(@"Güncel fırsatlar pop-up'ında daha sonra butonu tıklanır")]
        public void ClosePopUp()
        {
            gittiGidiyorPage.CloseSubscriptionPopUp();
        }

        [StepDefinition(@"Giriş yap butonu üzerine gelinir")]
        public void HoverProfile()
        {
            gittiGidiyorPage.HoverLogin();
        }

        [StepDefinition(@"Giriş yap butonuna tıklanır")]
        public void ClickLogin()
        {
            gittiGidiyorPage.ClickSigninButton();
        }

        [StepDefinition(@"Email alanına '(.*)' şifre alanına '(.*)' yazılır")]
        public void FillLogin(string email, string password)
        {
            gittiGidiyorPage.FillLoginInfo(email, password);
        }

        [StepDefinition(@"Üye girişi ekranında giriş yap butonuna tıklanır")]
        public void Login()
        {
            gittiGidiyorPage.ClickLoginButton();
        }

        [AfterScenario]
        public void After()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            webDriver.Close();
        }
    }
}
