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
        public WebDriver Driver;
        public Home(WebDriver Driver)
        {
            this.Driver = Driver;
        }

        private readonly By Lbl_ErrorLogin = By.XPath("//span[contains(@id,'_lblOutput')]");
        private readonly By Lbl_PanelLogin = By.XPath("//div[contains(@id,'_pnl_login')]//span");
        private readonly By Txt_Username = By.XPath("(//input[contains(@id,'_txtUserLogin')])[2]");
        private readonly By Txt_Password = By.XPath("(//input[contains(@id,'_txtPassword')])[2]");
        private readonly By Btn_Login = By.XPath("//input[contains(@id,'_btnLogin')]");

        public String GetErrorLogin()
        {
            return this.Driver.FindElement(Lbl_ErrorLogin).Text;
        }
        
        public String GetPanelLoginName()
        {
            return this.Driver.FindElement(Lbl_PanelLogin).Text;
        }

        public void EnterUsernme(String username)
        {
            this.Driver.FindElement(this.Txt_Username).Clear();
            this.Driver.FindElement(this.Txt_Username).SendKeys(username);
        }
        public void EnterPassword(String password)
        {
            this.Driver.FindElement(this.Txt_Password).Clear();
            this.Driver.FindElement(this.Txt_Password).SendKeys(password);
        }

        public void ClickLogin()
        {
            this.Driver.FindElement(this.Btn_Login).Click();
        }
    }
}
