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
        private WebDriver driver;

        public Dashboard(WebDriver driver)
        {
            this.driver = driver;
        }

        private By lbl_username = By.XPath("//span[contains(@id,'_username')]");
        private By btn_signout = By.XPath("//a[contains(@id,'_lnkbtnSignout')]");

        public string getUsername()
        {
            return this.driver.FindElement(this.lbl_username).Text;
        }

        public void clickSignout()
        {
            this.driver.FindElement(this.btn_signout).Click();
        }
    }
}
