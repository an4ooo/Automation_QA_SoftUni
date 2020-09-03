using DemoQA_POM_Homework.Pages.DragabblePage;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoQA_POM_Homework.Tests.Interactions
{
    class Dragabble : BaseTest
    {
        private DragabblePage _dragabblePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _dragabblePage = new DragabblePage(Driver);
            Driver.Navigate().GoToUrl("http://www.demoqa.com/dragabble");
        }

        [Test]
        [Obsolete]
        public void DraggableTestSimpleX()
        {
            int boxPositionXBefore = _dragabblePage.BoxToDrag.Location.X;

            Builder
                .MoveToElement(_dragabblePage.BoxToDrag)
                .ClickAndHold()
                .MoveByOffset(500, 150)
                .Perform();
                     
            _dragabblePage.AssertNotEqualPositionBeforeAndAfter(boxPositionXBefore, _dragabblePage.BoxToDrag.Location.X);
        }

        [Test]
        [Obsolete]
        public void DraggableTestSimpleY()
        {
            int boxPositionYBefore = _dragabblePage.BoxToDrag.Location.Y;

            Builder
                .MoveToElement(_dragabblePage.BoxToDrag)
                .ClickAndHold()
                .MoveByOffset(500, 150)
                .Perform();

            _dragabblePage.AssertNotEqualPositionBeforeAndAfter(boxPositionYBefore, _dragabblePage.BoxToDrag.Location.Y);
        }

        [Test]
        public void DraggableTestAxisRestrictionX()
        {            
            _dragabblePage.AxisTab.Click();

            int boxPositionXBefore = _dragabblePage.BoxToDragX.Location.X;
            int boxPositionYBefore = _dragabblePage.BoxToDragX.Location.Y;

            Builder
                .MoveToElement(_dragabblePage.BoxToDragX)
                .ClickAndHold()
                .MoveByOffset(500, 150)
                .Perform();

            _dragabblePage.AssertEqualPositionBeforeAndAfter(boxPositionYBefore, _dragabblePage.BoxToDragX.Location.Y);
            _dragabblePage.AssertNotEqualPositionBeforeAndAfter(boxPositionXBefore, _dragabblePage.BoxToDragX.Location.X);
        }

        [Test]
        public void DraggableTestAxisRestrictionY()
        {
            _dragabblePage.AxisTab.Click();

            int boxPositionXBefore = _dragabblePage.BoxToDragY.Location.X;
            int boxPositionYBefore = _dragabblePage.BoxToDragY.Location.Y;

            Builder
                .MoveToElement(_dragabblePage.BoxToDragY)
                .ClickAndHold()
                .MoveByOffset(150, 200)
                .Perform();

            _dragabblePage.AssertNotEqualPositionBeforeAndAfter(boxPositionYBefore, _dragabblePage.BoxToDragY.Location.Y);
            _dragabblePage.AssertEqualPositionBeforeAndAfter(boxPositionXBefore, _dragabblePage.BoxToDragY.Location.X);
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
