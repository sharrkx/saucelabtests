using System;
using TestProject3.Constants;
using static TestProject3.TestBase.TestBase;
using NUnit.Framework;

namespace TestProject3;
using static Constants.Constants.URLs;

public class Tests : TestBase.TestBase.TestSetUp
{
    [Test]
    public void testLogin()
    {   
        Console.WriteLine("1.Авторизация");
        loginPage.typeCorrectValuesAndLogin("performance_glitch_user", "secret_sauce");
        string getLoginPageUrl = loginPage.getLoginPageUrl();
        Assert.AreEqual(SAUCE_HOME_PAGE, getLoginPageUrl);
        
        Console.WriteLine("2.Добавляем в корзину Sauce Labs Fleece Jacket");
        storeHomepage.addFleeceJaket();
        string getRemoveTextJacket = storeHomepage.getRemoveFleeceJacketBTNText();
        Assert.AreEqual("REMOVE", getRemoveTextJacket);
        
        Console.WriteLine("3.Переход в корзину");
        storeHomepage.goToShoppingCart();
        string getShoppingCardPageUrl = shoppingCardPage.getShoppingCardPageURL();
        Assert.AreEqual(SAUCE_SHOPPING_CARD,getShoppingCardPageUrl);
        
        Console.WriteLine("4.Нажимаем Continue Shopping");
        shoppingCardPage.continueShopBtn();
        string getStoreHomePageURL = storeHomepage.getStoreHomePageUrl();
        Assert.AreEqual(SAUCE_HOME_PAGE, getStoreHomePageURL);
        
        Console.WriteLine("5.Добавляем в корзину Sauce Labs Bolt T-Shirt");
        storeHomepage.addTShirt();
        string getRemoveTextTShirtBtn = storeHomepage.getRemoveTShirtBtnText();
        Assert.AreEqual("REMOVE",getRemoveTextTShirtBtn);
        
        Console.WriteLine("6.Переходим в корзину");
        storeHomepage.goToShoppingCart();
        string getNameTShirt = shoppingCardPage.getProductNameTShirt();
        string getNameJacket = shoppingCardPage.getProductNameJacket();
        Assert.AreEqual("Sauce Labs Bolt T-Shirt", getNameTShirt);
        Assert.AreEqual("Sauce Labs Fleece Jacket", getNameJacket);
        
        





    }
    }
    
    
