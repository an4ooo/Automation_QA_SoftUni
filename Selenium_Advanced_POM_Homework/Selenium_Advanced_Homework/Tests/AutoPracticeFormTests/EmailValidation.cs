using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Selenium_POM_Homework.Factories;
using Selenium_POM_Homework.Models;
using Selenium_POM_Homework.Pages.AutomationPracticeRegistration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Selenium_POM_Homework.Tests
{
    public class EmailValidation : BaseTest
    {
        private AutoPracticeFormPage _autoPracticeFormPage;
        private AutoPracticeFormModel _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _autoPracticeFormPage = new AutoPracticeFormPage(Driver);
            _user = AutoPracticeFormFactory.Create();
        }

        [Test]
        [Obsolete]
        public void EnterValidEmailValidation()
        {
            _autoPracticeFormPage.NavigateToRegistrationForm();

            var currentValue = _autoPracticeFormPage.EmailField.GetAttribute("value");

            Assert.AreEqual("qwerty@abv.bg", currentValue);
        }

        [Test]
        [Obsolete]
        public void NegativeTestInvalidEmail()
        {
            _autoPracticeFormPage.SignInButton.Click();
            _autoPracticeFormPage.EnterValidEmailField.SendKeys("qwerty@abv");

            _autoPracticeFormPage.CreateAnAccountButton.Click();

            Assert.IsTrue(_autoPracticeFormPage.ErrorMessageEmail.Displayed);
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
