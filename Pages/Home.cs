using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestYou.Pages
{
    public class Home
    {
        public WebDriver driver;
        public Home(WebDriver driver)
        {
            this.driver = driver;
        }

        private By lbl_panellogin = By.XPath("//div[contains(@id,'_pnl_login')]//span");
        private By txt_username = By.XPath("(//input[contains(@id,'_txtUserLogin')])[2]");
        private By txt_password = By.XPath("(//input[contains(@id,'_txtPassword')])[2]");
        private By btn_login = By.XPath("//input[contains(@id,'_btnLogin')]");

        public String getPanelLoginName()
        {
            return this.driver.FindElement(lbl_panellogin).Text;
        }

        public void enterUsernme(String username)
        {
            this.driver.FindElement(this.txt_username).Clear();
            this.driver.FindElement(this.txt_username).SendKeys(username);
        }
        public void enterPassword(String password)
        {
            this.driver.FindElement(this.txt_password).Clear();
            this.driver.FindElement(this.txt_password).SendKeys(password);
        }

        public void clickLogin()
        {
            this.driver.FindElement(this.btn_login).Click();
        }
    }
}
