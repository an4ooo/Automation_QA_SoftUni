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
    class RegistrationForm : BaseTest
    {
        private AutoPracticeFormPage _autoPracticeFormPage;
        private AutoPracticeFormModel _user;

        [SetUp]
        [Obsolete]
        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            _autoPracticeFormPage = new AutoPracticeFormPage(Driver);
            _user = AutoPracticeFormFactory.Create();
            _autoPracticeFormPage.NavigateToRegistrationForm();
        }

        [Test]
        [Obsolete]
        public void NegativeTestWithoutFirstName()
        {
            string currentError = "firstname";


            _user.FirstName = string.Empty;

            _autoPracticeFormPage.FillForm(_user);

            _autoPracticeFormPage.AssertErrorMessageIsDisplayed(_autoPracticeFormPage.ErrorMessage);
            _autoPracticeFormPage.AssertErrorMessage(currentError, _autoPracticeFormPage.CurrentErrorMessage(currentError));

        }

        [Test]
        [Obsolete]
        public void NegativeTestInvalidPassword()
        {
            string currentError = "passwd";
            _user.Password = "0000";

            _autoPracticeFormPage.FillForm(_user);

            _autoPracticeFormPage.AssertErrorMessageIsDisplayed(_autoPracticeFormPage.ErrorMessage);
            _autoPracticeFormPage.AssertErrorMessage(currentError, _autoPracticeFormPage.CurrentErrorMessage(currentError));
        }

        [Test]
        [Obsolete]
        public void NegativeTestInvalidPhoneNumber()
        {
            string currentError = "phone_mobile is too long. Maximum length: 32";
            _user.PhoneNumber = "111111111111111111111111111111111";
            _user.Password = "0000";

            _autoPracticeFormPage.FillForm(_user);

            _autoPracticeFormPage.AssertErrorMessageIsDisplayed(_autoPracticeFormPage.ErrorMessage);
            _autoPracticeFormPage.AssertErrorMessage(currentError, _autoPracticeFormPage.CurrentErrorPhoneNumber);
        }

        [Test]
        [Obsolete]
        public void NegativeTestNoCity()
        {
            string currentError = "city";
            _user.City = string.Empty;

            _autoPracticeFormPage.FillForm(_user);

            _autoPracticeFormPage.AssertErrorMessageIsDisplayed(_autoPracticeFormPage.ErrorMessage);
            _autoPracticeFormPage.AssertErrorMessage(currentError, _autoPracticeFormPage.CurrentErrorMessage(currentError));
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
