using OpenQA.Selenium;

namespace TestProject3.Pages.ShoppingCartPage;

public class ShoppingCardPage
{
    private WebDriver driver;

    public ShoppingCardPage(WebDriver driver)
    {
        this.driver = driver;
    }

    private By continueShoppingBtn = By.XPath("//button[@name='continue-shopping']");
    private By productNameTShirt = By.XPath("//div[@class='inventory_item_name' and text()='Sauce Labs Bolt T-Shirt']");
    private By productNameJacket = By.XPath("//div[@class='inventory_item_name' and text()='Sauce Labs Fleece Jacket']");

    public string getShoppingCardPageURL()
    {
        return driver.Url;
    }

    public ShoppingCardPage continueShopBtn()
    {
        driver.FindElement(continueShoppingBtn).Click();
        return this;
    }

    public string getProductNameTShirt()
    {
       return driver.FindElement(productNameTShirt).Text;
    }
    public string getProductNameJacket()
    {
        return driver.FindElement(productNameJacket).Text;
    }
}