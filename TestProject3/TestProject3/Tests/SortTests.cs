using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using Supremes.Nodes;
using TestProject3.Pages.StoreHomepage;

namespace TestProject3.TestBase;

public class SortTests : TestBase.TestSetUp
{
 
    

    [Test]
    public void SortLowToHighTest()
    {

        loginPage.typeCorrectValuesAndLogin("performance_glitch_user", "secret_sauce");
        storeHomepage.selectSortLowToHigh();
        storeHomepage.checkLowToHighSort();
        
    }

    [Test]
    public void SortHighToLow()
    {
        loginPage.typeCorrectValuesAndLogin("performance_glitch_user", "secret_sauce");
        storeHomepage.selectSortHighToLow();
        storeHomepage.checkLowToHighSort();
    }
        
    }
