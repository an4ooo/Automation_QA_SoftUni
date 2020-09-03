using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.AutomationPracticeRegistration
{
    public partial class AutoPracticeFormPage : BasePage
    {
        public void AssertErrorMessageIsDisplayed(IWebElement element)
        {
            Assert.IsTrue(element.Displayed);
        }

        public void AssertErrorMessage(string currentError, IWebElement element)
        {
            Assert.AreEqual($"{currentError}", element.Text);
        }
    }
}
