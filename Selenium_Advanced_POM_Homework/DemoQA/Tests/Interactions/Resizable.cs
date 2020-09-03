using DemoQA_POM_Homework.Pages.ResizablePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Selenium_POM_Homework.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA_POM_Homework.Tests.Interactions
{
    class Resizable : BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            Driver.Navigate().GoToUrl("http://www.demoqa.com/resizable");
        }


        [Test]
        public void ResizableTestSimple()
        {
            string boxHeightBefore = _resizablePage.BoxToResize.GetCssValue("height");
            string boxWidthBefore = _resizablePage.BoxToResize.GetCssValue("width");

            Driver.ScrollTo(_resizablePage.ResizableHandle);

            Builder
                 .MoveToElement(_resizablePage.ResizableHandle)
                 .ClickAndHold()
                 .MoveByOffset(50, 50)
                 .Release()
                 .Perform();

            _resizablePage.AssertMeasuresNotEqual(boxHeightBefore, _resizablePage.BoxToResize.GetCssValue("height"));
            _resizablePage.AssertMeasuresNotEqual(boxWidthBefore, _resizablePage.BoxToResize.GetCssValue("width"));
        }

        [Test]
        public void ResizableTestToMinSize()
        {
            Builder
                .MoveToElement(_resizablePage.ResizableRestrictHandle)
                .ClickAndHold()
                .MoveByOffset(-100, -100)
                .Release()
                .Perform();

            _resizablePage.AssertMeasuresNotEqual("150", _resizablePage.BoxWithRestrictinToResize.GetCssValue("height"));
            _resizablePage.AssertMeasuresNotEqual("150", _resizablePage.BoxWithRestrictinToResize.GetCssValue("width"));

        }

        [Test]
        public void ResizableTestToMaxSize()
        {
            Builder
                .MoveToElement(_resizablePage.ResizableRestrictHandle)
                .ClickAndHold()
                .MoveByOffset(350, 150)
                .Release()
                .Perform();

            _resizablePage.AssertMeasuresNotEqual("300", _resizablePage.BoxWithRestrictinToResize.GetCssValue("height"));
            _resizablePage.AssertMeasuresNotEqual("500", _resizablePage.BoxWithRestrictinToResize.GetCssValue("width"));
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
