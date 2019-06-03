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
    [Binding, Scope(Feature = "GittiGidiyorTest")]
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

        [StepDefinition(@"Menüden Otomobil, Motosiklet üzerine gelinir")]
        public void HoverMenu()
        {
            gittiGidiyorPage.HoverMenuItem();
        }
        [StepDefinition(@"Menüden eldiven seçilir")]
        public void ClickMenu()
        {
            gittiGidiyorPage.ClickMenuItem();
        }

        [StepDefinition(@"Yan filtreden kırmızı-siyah seçilir")]
        public void ClickLeftFilter()
        {
            gittiGidiyorPage.ClickFilterLeft();
        }

        [StepDefinition(@"Üst filtreden ücretsiz kargo seçilir")]
        public void ClickTopFilter()
        {
            gittiGidiyorPage.ClickFilterTop();
        }

        [StepDefinition(@"İlk ürün seçilir")]
        public void ChooseFirstItem()
        {
            gittiGidiyorPage.ClickFirstItem();
        }

        [StepDefinition(@"Beden olarak '(.*)' seçilir")]
        public void ChooseSize(string s)
        {
            gittiGidiyorPage.ChooseSize(s);
        }

        [StepDefinition(@"Renk olarak '(.*)' seçilir")]
        public void ChooseFirstItem(string c)
        {
            gittiGidiyorPage.ChooseColor(c);
        }

        [StepDefinition(@"Sepete Ekle butonuna tıklanır")]
        public void ClickBasket()
        {
            gittiGidiyorPage.ClickAddToBasket();
        }

        [StepDefinition(@"Alışverişi tamamla butonuna tıklanır")]
        public void ClickPay()
        {
            gittiGidiyorPage.ClickPay();
        }

        [StepDefinition(@"Ad alanına '(.*)' yazılır")]
        public void SetName(string name)
        {
            gittiGidiyorPage.SetName(name);
        }

        [StepDefinition(@"Soyad alanına '(.*)' yazılır")]
        public void SetSurname(string surname)
        {
            gittiGidiyorPage.SetSurname(surname);
        }

        [StepDefinition(@"Şehir olarak '(.*)' seçilir")]
        public void ChooseCity(string s)
        {
            gittiGidiyorPage.ChooseCity(s);
        }

        [StepDefinition(@"İlçe olarak '(.*)' seçilir")]
        public void ChooseDistrict(string s)
        {
            gittiGidiyorPage.ChooseDistrict(s);
        }

        [StepDefinition(@"Adres alanına '(.*)' yazılır")]
        public void SetAddress(string address)
        {
            gittiGidiyorPage.SetAddress(address);
        }

        [StepDefinition(@"Telefon-1 alanına '(.*)' yazılır")]
        public void SetPhone(string phone)
        {
            gittiGidiyorPage.SetPhone(phone);
        }

        [StepDefinition(@"Kaydet ve Devam Et butonuna tıklanır")]
        public void ClickSaveAndContinue()
        {
            gittiGidiyorPage.ClickSaveAndContinue();
        }

        [StepDefinition(@"Devam Et butonuna tıklanır")]
        public void ClickContinue()
        {
            gittiGidiyorPage.ClickContinue();
        }

        [StepDefinition(@"Ödeme yöntemi olarak BKM express seçilir")]
        public void ClickPayMethod()
        {
            gittiGidiyorPage.ClickPayMethod();
        }

        [AfterScenario]
        public void After()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            webDriver.Close();
        }
    }
}
