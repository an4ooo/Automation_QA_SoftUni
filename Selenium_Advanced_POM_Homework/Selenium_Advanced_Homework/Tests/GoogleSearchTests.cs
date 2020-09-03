using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Selenium_POM_Homework.Pages.GoogleSearch;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Selenium_POM_Homework.Tests
{
    class GoogleSearchTests : BaseTest
    {
        private GoogleSearchPage _googleSearchPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.google.com");
            _googleSearchPage = new GoogleSearchPage(Driver);
        }

        [Test]
        [Obsolete]
        public void EnterAndEqualSeleniumWebsiteUrl()
        {
            _googleSearchPage.FindAndSelectFirstResultForSelenium();

            _googleSearchPage.AssertUrl();
            _googleSearchPage.AssertTitle();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{Directory.GetCurrentDirectory()}/{TestContext.CurrentContext.Test.Name}.png", ScreenshotImageFormat.Png);
            }
            Driver.Quit();
        }

    }
}
