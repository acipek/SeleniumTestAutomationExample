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
        public GittiGidiyorLoginPage gittiGidiyorLoginPage;
        public GittiGidiyorShoppingPage gittiGidiyorShoppingPage;
        public GittiGidiyorAddressPage gittiGidiyorAddressPage;
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
            gittiGidiyorLoginPage = new GittiGidiyorLoginPage(webDriver);
            gittiGidiyorShoppingPage = new GittiGidiyorShoppingPage(webDriver);
            gittiGidiyorAddressPage = new GittiGidiyorAddressPage(webDriver);
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
            gittiGidiyorLoginPage.FillLoginInfo(email, password);
        }

        [StepDefinition(@"Üye girişi ekranında giriş yap butonuna tıklanır")]
        public void Login()
        {
            gittiGidiyorLoginPage.ClickLoginButton();
        }

        [StepDefinition(@"Menüden Otomobil, Motosiklet üzerine gelinir")]
        public void HoverMenu()
        {
            gittiGidiyorShoppingPage.HoverMenuItem();
        }
        [StepDefinition(@"Menüden eldiven seçilir")]
        public void ClickMenu()
        {
            gittiGidiyorShoppingPage.ClickMenuItem();
        }

        [StepDefinition(@"Yan filtreden kırmızı-siyah seçilir")]
        public void ClickLeftFilter()
        {
            gittiGidiyorShoppingPage.ClickFilterLeft();
        }

        [StepDefinition(@"Üst filtreden ücretsiz kargo seçilir")]
        public void ClickTopFilter()
        {
            gittiGidiyorShoppingPage.ClickFilterTop();
        }

        [StepDefinition(@"İlk ürün seçilir")]
        public void ChooseFirstItem()
        {
            gittiGidiyorShoppingPage.ClickFirstItem();
        }

        [StepDefinition(@"Beden olarak '(.*)' seçilir")]
        public void ChooseSize(string s)
        {
            gittiGidiyorShoppingPage.ChooseSize(s);
        }

        [StepDefinition(@"Renk olarak '(.*)' seçilir")]
        public void ChooseFirstItem(string c)
        {
            gittiGidiyorShoppingPage.ChooseColor(c);
        }

        [StepDefinition(@"Sepete Ekle butonuna tıklanır")]
        public void ClickBasket()
        {
            gittiGidiyorShoppingPage.ClickAddToBasket();
        }

        [StepDefinition(@"Alışverişi tamamla butonuna tıklanır")]
        public void ClickPay()
        {
            gittiGidiyorShoppingPage.ClickPay();
        }

        [StepDefinition(@"Ad alanına '(.*)' yazılır")]
        public void SetName(string name)
        {
            gittiGidiyorAddressPage.SetName(name);
        }

        [StepDefinition(@"Soyad alanına '(.*)' yazılır")]
        public void SetSurname(string surname)
        {
            gittiGidiyorAddressPage.SetSurname(surname);
        }

        [StepDefinition(@"Şehir olarak '(.*)' seçilir")]
        public void ChooseCity(string s)
        {
            gittiGidiyorAddressPage.ChooseCity(s);
        }

        [StepDefinition(@"İlçe olarak '(.*)' seçilir")]
        public void ChooseDistrict(string s)
        {
            gittiGidiyorAddressPage.ChooseDistrict(s);
        }

        [StepDefinition(@"Adres alanına '(.*)' yazılır")]
        public void SetAddress(string address)
        {
            gittiGidiyorAddressPage.SetAddress(address);
        }

        [StepDefinition(@"Telefon-1 alanına '(.*)' yazılır")]
        public void SetPhone(string phone)
        {
            gittiGidiyorAddressPage.SetPhone(phone);
        }

        [StepDefinition(@"Kaydet ve Devam Et butonuna tıklanır")]
        public void ClickSaveAndContinue()
        {
            gittiGidiyorAddressPage.ClickSaveAndContinue();
        }

        [StepDefinition(@"Devam Et butonuna tıklanır")]
        public void ClickContinue()
        {
            gittiGidiyorAddressPage.ClickContinue();
        }

        [StepDefinition(@"Ödeme yöntemi olarak BKM express seçilir")]
        public void ClickPayMethod()
        {
            gittiGidiyorShoppingPage.ClickPayMethod();
        }

        [AfterScenario]
        public void After()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            webDriver.Close();
        }
    }
}
