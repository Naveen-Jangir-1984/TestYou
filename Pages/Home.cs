using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestYou.Utilities;

namespace TestYou.Pages
{
    public class Home
    {
        public readonly WebDriver Driver;
        private readonly By Lbl_ErrorLogin = By.XPath("//span[contains(@id,'_lblOutput')]");
        private readonly By Lbl_PanelLogin = By.XPath("//div[contains(@id,'_pnl_login')]//span");
        private readonly By Txt_Username = By.XPath("(//input[contains(@id,'_txtUserLogin')])[2]");
        private readonly By Txt_Password = By.XPath("(//input[contains(@id,'_txtPassword')])[2]");
        private readonly By Btn_Login = By.XPath("//input[contains(@id,'_btnLogin')]");
        private readonly By Chk_StaySignedIn = By.XPath("(//input[contains(@id,'RememberMe')])[2]");
        public Home(WebDriver driver)
        {
            this.Driver = driver;
        }
        public String GetErrorLogin()
        {
            return CommonFunctions.WaitAndGetText(this.Driver, this.Lbl_ErrorLogin);
        }        
        public String GetPanelLoginName()
        {
            return CommonFunctions.WaitAndGetText(this.Driver, this.Lbl_PanelLogin);
        }
        public void EnterUsernme(String username)
        {
            CommonFunctions.WaitAndEnterValueInTextField(this.Driver, this.Txt_Username, username);
        }
        public void EnterPassword(String password)
        {
            CommonFunctions.WaitAndEnterValueInTextField(this.Driver, this.Txt_Password, password);
        }
        public void ClickLogin()
        {
            CommonFunctions.WaitAndClickOnButton(this.Driver, this.Btn_Login);
        }
        public void CheckRememberMe()
        {
            CommonFunctions.WaitAndClickOnButton(this.Driver, this.Chk_StaySignedIn);
        }
    }
}
