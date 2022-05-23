using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject3.Pages.LoginPage;
using TestProject3.Pages.ShoppingCartPage;
using TestProject3.Pages.StoreHomepage;
using static TestProject3.Constants.Constants.URLs;
using static TestProject3.Constants.Constants.timeOuts;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using TestProject3.Pages.Base;
using static TestProject3.Pages.Base.BasePage;


namespace TestProject3.TestBase;

public class TestBase
{


    
    
    [TestFixture]
    public class TestSetUp {
        protected LoginPage loginPage;
        protected WebDriver driver;
        protected StoreHomepage storeHomepage;
        protected ShoppingCardPage shoppingCardPage;
        protected BasePage basePage;

        [SetUp]
        public void SetUp()
        {
            WebDriver driver = new ChromeDriver(Path.GetDirectoryName(
                @"C:\Users\i.khamadiev\RiderProjects\RegressProject\RegressProject\main\resources\chromedriver-3"));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
            driver.Navigate().GoToUrl(SAUCE_LOGIN_PAGE);
            loginPage = new LoginPage(driver);
            storeHomepage = new StoreHomepage(driver);
            shoppingCardPage = new ShoppingCardPage(driver);
            basePage = new BasePage(driver);

        }


        [TearDown]
        public void TearDownTest()
        {
            basePage.CloseDriver();
        }
        

    }

}
