using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        [Obsolete]
        public IWebElement SearchField => Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains(@class,'gLFyf')]")));

        public IWebElement FirstSearchResult => Driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div[9]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div/div[1]/a/h3"));

    }
}
