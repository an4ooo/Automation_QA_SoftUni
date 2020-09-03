using DemoQA_POM_Homework.Pages.DemoQAPage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Selenium_POM_Homework.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA_POM_Homework.Tests
{
    class NavigationTests : BaseTest
    {
        private DemoQAPage _demoQAPage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.demoqa.com");
            _demoQAPage = new DemoQAPage(Driver);
        }

        [Test]
        [TestCase("Dragabble")]
        [TestCase("Droppable")]
        [TestCase("Resizable")]
        [TestCase("Selectable")]
        [TestCase("Sortable")]

        public void SuccessfullyNavigateToInteractions(string sectionName)
        {
            _demoQAPage.InteractionsSection.Click();

            Driver.ScrollTo(_demoQAPage.InteractionsSubSection(sectionName));
            _demoQAPage.InteractionsSubSection(sectionName).Click();

            _demoQAPage.AssertPageIsLoaded(sectionName);
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
