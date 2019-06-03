using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace GittiGidiyorTestAutomation.Page
{
    public class Base
    {

        private IWebDriver _driver;

        public Base(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public IWebElement Find(By by)
        {
            return _driver.FindElement(by);
        }

        public void Click(IWebElement btn)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(btn));
            btn.Click();
        }

        public void Hover(IWebElement btn)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text)
        {
            txt.SendKeys(text);
        }
        public void SelectOptionByText(IWebElement slct, string text)
        {
            SelectElement selectElement = new SelectElement(slct);
            selectElement.SelectByText(text);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(slct, text));
        }

        public void ScrollTo(IWebElement el)
        {
            string jsStmt = String.Format("window.scrollTo({0},{1})", el.Location.X, el.Location.Y);
            GetScriptExecutor().ExecuteScript(jsStmt, true);
        }

        public IJavaScriptExecutor GetScriptExecutor()
        {
            return (IJavaScriptExecutor)_driver;
        }
    }
}
