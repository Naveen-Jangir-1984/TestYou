using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestYou.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestYou.StepDefinitions
{
    [Binding]
    public class AccessStepDefinitions
    {
        private WebDriver Driver;
        private Home Home;
        private Dashboard Dashoard;

        private String Username;
        
        [Before]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            this.Driver = new ChromeDriver();
            this.Home = new Home(this.Driver);
            this.Dashoard = new Dashboard(this.Driver);
        }

        [Given(@"user is on '([^']*)' home page")]
        public void GivenUserInOnHomePage(string testURL)
        {
            this.Driver.Url = testURL;
        }

        [When(@"user enters (.*) in username text field")]
        public void WhenUserEntersTestwithtestyouInUsernameTextField(String username)
        {
            this.Home.EnterUsernme(username);
            this.Username = username;
        }

        [When(@"user enters (.*) in password text field")]
        public void WhenUserEntersInPasswordTextField(String password)
        {
            this.Home.EnterPassword(password);
        }

        [When(@"user click on Login button")]
        public void WhenUserClickOnLoginButton()
        {
            this.Home.ClickLogin();
        }

        [Then(@"username is displayed on dashboard")]
        public void ThenUsernameIsDisplayedOnDashboard()
        {
            String Username = this.Dashoard.GetUsername().ToUpper();
            Username.Should().Contain(this.Username.ToUpper());
        }

        [When(@"user click on Signout button")]
        public void WhenUserClickOnSignoutButton()
        {
            this.Dashoard.ClickSignout();
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            String PanelLoginName = this.Home.GetPanelLoginName().ToUpper();
            PanelLoginName.Should().Be("TESTYOU LOGIN");
        }

        [Then(@"login error is displayed")]
        public void ThenLoginErrorIsDisplayed()
        {
            this.Home.GetErrorLogin();
        }

        [After]
        public void TearDown()
        {
            this.Driver.Close();
        }

    }
}
