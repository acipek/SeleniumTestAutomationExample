using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyorTestAutomation.Page
{
    public class GittiGidiyorShoppingPage : Base
    {
        public GittiGidiyorShoppingPage(IWebDriver _driver) : base(_driver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//*[@id='header_wrapper']/div[6]/div[8]")]
        public IWebElement BtnMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href = '//www.gittigidiyor.com/motosiklet-giyim-kask/eldiven']")]
        public IWebElement BtnEldiven { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label[title='Kırmızı-Siyah']")]
        public IWebElement ChkFilterEldiven { get; set; }

        [FindsBy(How = How.Id, Using = "search-page-tab-free-shipping")]
        public IWebElement ChkFilterKargo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li[product-index='1']")]
        public IWebElement BtnFirstItem { get; set; }

        [FindsBy(How = How.ClassName, Using = "spec-select-0")]
        public IWebElement SlctSize { get; set; }

        [FindsBy(How = How.ClassName, Using = "spec-select-1")]
        public IWebElement SlctColor { get; set; }

        [FindsBy(How = How.Id, Using = "add-to-basket")]
        public IWebElement BtnBasket { get; set; }

        [FindsBy(How = How.ClassName, Using = "btn-pay")]
        public IWebElement BtnPay { get; set; }

        [FindsBy(How = How.Id, Using = "P-PayViaBKM")]
        public IWebElement BtnPayMethod { get; set; }
        public void HoverMenuItem()
        {
            Hover(BtnMenu);
        }

        public void ClickMenuItem()
        {
            Click(BtnEldiven);
        }

        public void ClickFilterLeft()
        {
            ScrollTo(ChkFilterEldiven);
            Click(ChkFilterEldiven);
        }

        public void ClickFilterTop()
        {
            Click(ChkFilterKargo);
        }

        public void ClickFirstItem()
        {
            Click(BtnFirstItem);
        }

        public void ChooseSize(string size)
        {
            SelectOptionByText(SlctSize, size);
        }

        public void ChooseColor(string color)
        {
            SelectOptionByText(SlctColor, color);
        }

        public void ClickAddToBasket()
        {
            ScrollTo(BtnBasket);
            Click(BtnBasket);
        }
        public void ClickPay()
        {
            Click(BtnPay);
        }

        public void ClickPayMethod()
        {
            Click(BtnPayMethod);
        }
    }
}
