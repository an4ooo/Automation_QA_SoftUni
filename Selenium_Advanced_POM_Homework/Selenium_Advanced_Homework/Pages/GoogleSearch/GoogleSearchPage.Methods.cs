using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base(driver)
        {
        }

        [Obsolete]
        public void FindAndSelectFirstResultForSelenium()
        {
            SearchField.SendKeys("selenium\n");
            FirstSearchResult.Click();
        }
    }
}
