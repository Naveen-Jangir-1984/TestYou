using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestYou.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestYou.StepDefinitions
{
    [Binding]
    public class AccessStepDefinitions
    {
        private WebDriver driver;
        private Home home;
        private Dashboard dashoard;

        private String username;
        
        [Before]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            this.driver = new ChromeDriver();
            this.home = new Home(this.driver);
            this.dashoard = new Dashboard(this.driver);
        }

        [Given(@"user in on '([^']*)' home page")]
        public void GivenUserInOnHomePage(string testurl)
        {
            this.driver.Url = testurl;
        }

        [When(@"user enters (.*) in username text field")]
        public void WhenUserEntersTestwithtestyouInUsernameTextField(String username)
        {
            this.home.enterUsernme(username);
            this.username = username;
        }

        [When(@"user enters (.*) in password text field")]
        public void WhenUserEntersInPasswordTextField(String password)
        {
            this.home.enterPassword(password);
        }

        [When(@"user click on Login button")]
        public void WhenUserClickOnLoginButton()
        {
            this.home.clickLogin();
        }

        [Then(@"username is displayed on dashboard")]
        public void ThenUsernameIsDisplayedOnDashboard()
        {
            String username = this.dashoard.getUsername().ToUpper();
            username.Should().Contain(this.username.ToUpper());
        }

        [When(@"user click on Signout button")]
        public void WhenUserClickOnSignoutButton()
        {
            this.dashoard.clickSignout();
        }

        [Then(@"user is navigated to home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            String panelLoginName = this.home.getPanelLoginName().ToUpper();
            panelLoginName.Should().Be("TESTYOU LOGIN");
        }


        [After]
        public void TearDown()
        {
            this.driver.Close();
        }

    }
}
