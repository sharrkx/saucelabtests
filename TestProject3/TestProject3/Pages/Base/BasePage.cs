using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace TestProject3.Pages.Base;

public class BasePage
{
    public BasePage (WebDriver driver)
    {
        this.driver = driver;
    }

    public WebDriver driver;
    public void CloseDriver()
    {
        driver.Quit();
        driver.Dispose();
    }
    
    
}
 


    
