using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Selenium_POM_Homework.Pages.SoftuniCourse;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Selenium_POM_Homework.Tests
{
    class SoftuniCourseTests : BaseTest
    {
        private SoftuniCoursePage _SoftuniCoursePage;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://www.softuni.bg");
            _SoftuniCoursePage = new SoftuniCoursePage(Driver);
        }

        [Test]
        [Obsolete]
        public void EqualSoftuniCourseHeading()
        {
            _SoftuniCoursePage.NavigateToCourse();

            _SoftuniCoursePage.AssertHeading();
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
