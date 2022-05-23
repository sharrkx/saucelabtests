using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V100.CSS;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static TestProject3.Constants.Constants.timeOuts;

namespace TestProject3.Pages.StoreHomepage;

public class StoreHomepage
{
    private WebDriver driver;


    public StoreHomepage(WebDriver driver)
    {
        this.driver = driver;
    }

    private By shoppingCartBtn = By.XPath("//a[@class='shopping_cart_link']");
    private By addSauceLabsFleeceJacketBtn = By.XPath("//button[@name='add-to-cart-sauce-labs-fleece-jacket']");
    private By addSauceLabsBoltTShirtBtn = By.XPath("//button[@name='add-to-cart-sauce-labs-bolt-t-shirt']");
    private By removeFleeceJacketBtn = By.XPath("//button[@name='remove-sauce-labs-fleece-jacket']");
    private By removeTShirtBtn = By.XPath("//button[@name ='remove-sauce-labs-bolt-t-shirt']");
    private By sortMenu = By.XPath("//select[@class='product_sort_container']");
    private readonly By allPrices = By.XPath("//div[@class='inventory_item_price']");


    public StoreHomepage addFleeceJaket()
    {
        driver.FindElement(addSauceLabsFleeceJacketBtn);
        IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.ElementToBeClickable(addSauceLabsFleeceJacketBtn));
        driver.FindElement(addSauceLabsFleeceJacketBtn).Click();
        return this;
    }

    public string getRemoveFleeceJacketBTNText()
    {
        string text = driver.FindElement(removeFleeceJacketBtn).Text;
        return text;
    }

    public string getRemoveTShirtBtnText()
    {
        string text = driver.FindElement(removeTShirtBtn).Text;
        return text;
    }

    public StoreHomepage goToShoppingCart()
    {
        driver.FindElement(shoppingCartBtn).Click();
        return this;
    }

    public StoreHomepage addTShirt()
    {
        driver.FindElement(addSauceLabsBoltTShirtBtn).Click();
        return this;
    }

    public string getStoreHomePageUrl()
    {
        return driver.Url;
    }

    public StoreHomepage selectSortLowToHigh()
    {
        SelectElement selectLowToHigh = new SelectElement(driver.FindElement(sortMenu));
        selectLowToHigh.SelectByValue("lohi");
        return new StoreHomepage(driver);
    }

    public StoreHomepage checkLowToHighSort()
    {

        ReadOnlyCollection<IWebElement> prices = driver.FindElements(allPrices);
        List<string> newarray = new List<string>();
        {
            foreach (IWebElement cell in prices)
            {
                newarray.Add(cell.Text.Replace("$", ""));
            }

            for (int i = 0; (newarray.Count - 1) < i; i++)
            {

                Assert.IsTrue(double.Parse(newarray[i], CultureInfo.InvariantCulture) <
                              (double.Parse(newarray[i + 1], CultureInfo.InvariantCulture)));
            }
        }
        return this;
    }

    public StoreHomepage selectSortHighToLow()
    {
        SelectElement selectLowToHigh = new SelectElement(driver.FindElement(sortMenu));
        selectLowToHigh.SelectByValue("hilo");
        return new StoreHomepage(driver);
    }

    public StoreHomepage checkHighToLowSort()
    {

        ReadOnlyCollection<IWebElement> prices = driver.FindElements(allPrices);
        List<string> newarray = new List<string>();
        {
            foreach (IWebElement cell in prices)
            {
                newarray.Add(cell.Text.Replace("$", ""));
            }

            for (int i = 0; (newarray.Count - 1) > i; i++)
            {

                Assert.IsTrue(double.Parse(newarray[i], CultureInfo.InvariantCulture) >
                              (double.Parse(newarray[i + 1], CultureInfo.InvariantCulture)));
            }
        }
        return this;
    }
}









//  for (int i = 0; (newarray.Count -1) > i; i++)
    //  {
     //     Assert.IsTrue(int.TryParse(newarray[i].ToString() > (int.TryParse(newarray[i + 1].ToString()))));
     // }
     // }
     // return this;
    //}

    //List<decimal> listA = item.Select(s => decimal.Parse(s)).ToList();
    //List<decimal> listB = listA.OrderByDescending(i => i).ToList();
    // List<decimal> listB = listA.OrderBy(x => x).ToList();
    //Assert.IsTrue(listA.SequenceEqual(listB));

   
    

        
        
            
        





        

        
    
    

   

