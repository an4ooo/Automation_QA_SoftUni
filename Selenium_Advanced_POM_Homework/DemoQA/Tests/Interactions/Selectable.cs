using DemoQA_POM_Homework.Pages.SelectablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace DemoQA_POM_Homework.Tests.Interactions
{
    class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            Driver.Navigate().GoToUrl("http://www.demoqa.com/selectable");
        }
        [Test]
        public void SelectableTestList()
        {
            string boxColorBefore = _selectablePage.BoxToSelect.GetCssValue("background-color");

            Builder.MoveToElement(_selectablePage.BoxToSelect).Click().Perform();

            _selectablePage.AssertNotEqualColorBeforeAndAfter(boxColorBefore, _selectablePage.BoxToSelect.GetCssValue("background-color"));            
        }

        [Test]
        public void SelectableTestGrid()
        {            
            _selectablePage.GridTab.Click();
            
            var boxSevenColorBefore = _selectablePage.BoxToSelectSeven.GetCssValue("background-color");

            Builder.MoveToElement(_selectablePage.BoxToSelectSeven).Click().Perform();     

            _selectablePage.AssertNotEqualColorBeforeAndAfter(boxSevenColorBefore, _selectablePage.BoxToSelectSeven.GetCssValue("background-color"));
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
