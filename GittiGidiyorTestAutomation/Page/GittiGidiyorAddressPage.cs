using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyorTestAutomation.Page
{
    public class GittiGidiyorAddressPage : Base
    {
        public GittiGidiyorAddressPage(IWebDriver _driver) : base(_driver)
        {

        }

        [FindsBy(How = How.Name, Using = "Name")]
        public IWebElement TxtName { get; set; }

        [FindsBy(How = How.Name, Using = "SurName")]
        public IWebElement TxtSurName { get; set; }

        [FindsBy(How = How.Name, Using = "City")]
        public IWebElement SlctCity { get; set; }

        [FindsBy(How = How.Name, Using = "District")]
        public IWebElement SlctDistrict { get; set; }

        [FindsBy(How = How.Name, Using = "Address")]
        public IWebElement TxtAddress { get; set; }

        [FindsBy(How = How.Name, Using = "phone-number")]
        public IWebElement TxtPhone { get; set; }

        [FindsBy(How = How.ClassName, Using = "post-address")]
        public IWebElement BtnSaveAndContinue { get; set; }

        [FindsBy(How = How.Id, Using = "post-address-form")]
        public IWebElement BtnContinue { get; set; }

        public void SetName(string name)
        {
            SetText(TxtName, name);
        }

        public void SetSurname(string surname)
        {
            SetText(TxtSurName, surname);
        }

        public void ChooseCity(string city)
        {
            SelectOptionByText(SlctCity, city);
        }

        public void ChooseDistrict(string dist)
        {
            SelectOptionByText(SlctDistrict, dist);
        }

        public void SetAddress(string address)
        {
            SetText(TxtAddress, address);
        }

        public void SetPhone(string phone)
        {
            SetText(TxtPhone, phone);
        }

        public void ClickSaveAndContinue()
        {
            Click(BtnSaveAndContinue);
        }
        public void ClickContinue()
        {
            Click(BtnContinue);
        }

 
    }
}
