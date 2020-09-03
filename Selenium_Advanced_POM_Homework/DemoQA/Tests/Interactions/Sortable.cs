using DemoQA_POM_Homework.Pages.SortablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA_POM_Homework.Tests.Interactions
{
    class Sortable : BaseTest
    {
        private SortablePage _sortablePage;
        
        [SetUp]
        public void Setup()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            Driver.Navigate().GoToUrl("http://www.demoqa.com/sortable");
        }

        [Test]
        public void SortableTestList()
        {
            int index = 4;

            Builder.DragAndDropToOffset(_sortablePage.ListOfOptions[index], 0, -50).Perform();

            _sortablePage.AssertElementIsMoved("Five", _sortablePage.ListOfOptions[index - 1].Text);
        }

        [Test]
        public void SortableTestGrid()
        {
            _sortablePage.TabGrid.Click();

            int index = 0;

            Builder.DragAndDropToOffset(_sortablePage.GridOfOptions[index], 0, +100).Perform();

            _sortablePage.AssertElementIsMoved("One", _sortablePage.GridOfOptions[index + 3].Text);
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
