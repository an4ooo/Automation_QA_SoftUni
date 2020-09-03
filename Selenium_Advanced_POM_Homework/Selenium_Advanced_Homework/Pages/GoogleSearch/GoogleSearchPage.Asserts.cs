using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.GoogleSearch
{
    public partial class GoogleSearchPage : BasePage
    {
        public void AssertUrl()
        {
            Assert.AreEqual("https://www.selenium.dev/", Driver.Url);
        }

        public void AssertTitle()
        {
            Assert.AreEqual("SeleniumHQ Browser Automation", Driver.Title);
        }
    }
}
 