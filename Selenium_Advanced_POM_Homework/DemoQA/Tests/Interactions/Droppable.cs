using DemoQA_POM_Homework.Pages.DroppablePage;
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
    class Droppable : BaseTest
    {
        private DroppablePage _droppablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            Driver.Navigate().GoToUrl("http://www.demoqa.com/droppable");
        }

        [Test]
        [Obsolete]
        public void DroppableTestSimple()
        {
            var targetBoxColorBefore = _droppablePage.TargetBox.GetCssValue("background-color");
             
            Builder.DragAndDrop(_droppablePage.SourceBox, _droppablePage.TargetBox).Perform();

            _droppablePage.AssertTargetBoxColorIsDifferentBeforeAndAfter(targetBoxColorBefore, _droppablePage.TargetBox.GetCssValue("background-color"));
        }

        [Test]
        [Obsolete]
        public void DroppableTestAcceptable()
        {
            _droppablePage.AcceptTab.Click();

            string targetBoxColorBefore = _droppablePage.TargetBoxAccept.GetCssValue("background-color");

            Builder.DragAndDrop(_droppablePage.SourceAcceptableBox, _droppablePage.TargetBoxAccept).Perform();

            _droppablePage.AssertTargetBoxColorIsDifferentBeforeAndAfter(targetBoxColorBefore, _droppablePage.TargetBoxAccept.GetCssValue("background-color"));
        }

        [Test]
        [Obsolete]
        public void DroppableTestNotAcceptable()
        {
            _droppablePage.AcceptTab.Click();

            var targetBoxColorBefore = _droppablePage.TargetBoxAccept.GetCssValue("background-color");

            Builder.DragAndDrop(_droppablePage.SourceNotAcceptableBox, _droppablePage.TargetBoxAccept).Perform();

            _droppablePage.AssertTargetBoxColorIsEqualBeforeAndAfter(targetBoxColorBefore, _droppablePage.TargetBoxAccept.GetCssValue("background-color"));          
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
