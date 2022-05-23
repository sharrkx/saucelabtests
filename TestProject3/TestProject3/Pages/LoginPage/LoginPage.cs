
using OpenQA.Selenium;

namespace TestProject3.Pages.LoginPage;

using static TestBase.TestBase;

public class LoginPage
{
    private WebDriver driver;
    public LoginPage(WebDriver driver)
    {
        this.driver = driver;
    }

    private By loginInput = By.XPath("//input[@name = 'user-name']");
    private By passwordInput = By.XPath("//input[@name = 'password']");
    private By loginBtn = By.XPath("//input[@name = 'login-button']");

    public LoginPage typeLogin(string username)
    {
        driver.FindElement(loginInput).SendKeys(username);
        return new LoginPage(driver);
    }

    public LoginPage typePass(string password)
    {
        driver.FindElement(passwordInput).SendKeys(password);
        return new LoginPage(driver);
    }

    public LoginPage typeCorrectValuesAndLogin(string username, string password)
    {
        this.typeLogin(username);
        this.typePass(password);
        driver.FindElement(loginBtn).Click();
        return new LoginPage(driver);
    }

    public string getLoginPageUrl()
    {
        return driver.Url;
    }
}