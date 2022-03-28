using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestYou.Utilities;

namespace TestYou.Pages
{
    public class Dashboard
    {
        private readonly WebDriver Driver;

        public Dashboard(WebDriver driver)
        {
            this.Driver = driver;
        }

        private readonly By Lbl_Username = By.XPath("//span[contains(@id,'_username')]");
        private readonly By Btn_Signout = By.XPath("//a[contains(@id,'_lnkbtnSignout')]");

        public string GetUsername()
        {
            return CommonFunctions.WaitAndGetText(this.Driver, this.Lbl_Username); ;
        }

        public void ClickSignout()
        {
            CommonFunctions.WaitAndClickOnButton(this.Driver, Btn_Signout);
        }
    }
}
