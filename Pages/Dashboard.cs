using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYou.Pages
{
    public class Dashboard
    {
        private WebDriver Driver;

        public Dashboard(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        private readonly By Lbl_Username = By.XPath("//span[contains(@id,'_username')]");
        private readonly By Btn_Signout = By.XPath("//a[contains(@id,'_lnkbtnSignout')]");

        public string GetUsername()
        {
            return this.Driver.FindElement(this.Lbl_Username).Text;
        }

        public void ClickSignout()
        {
            this.Driver.FindElement(this.Btn_Signout).Click();
        }
    }
}
