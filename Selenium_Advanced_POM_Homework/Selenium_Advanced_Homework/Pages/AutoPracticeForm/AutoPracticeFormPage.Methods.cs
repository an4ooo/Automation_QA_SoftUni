using OpenQA.Selenium;
using Selenium_POM_Homework.Extensions;
using Selenium_POM_Homework.Factories;
using Selenium_POM_Homework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.AutomationPracticeRegistration
{
    public partial class AutoPracticeFormPage : BasePage
    {
        public AutoPracticeFormPage(IWebDriver driver) : base(driver)
        {
        }

        public void FillForm(AutoPracticeFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Password.SendKeys(user.Password);
            Adress.SendKeys(user.Adress);
            City.SendKeys(user.City);
            State(user.State).Click();
            Postcode.SendKeys(user.Postcode);
            PhoneNumber.SendKeys(user.PhoneNumber);

            Driver.ScrollTo(SubmitButton);
            SubmitButton.Click();
        }

        [Obsolete]
        public void NavigateToRegistrationForm()
        {
            SignInButton.Click();

            Type(EnterValidEmailField, "qwerty@abv.bg");

            CreateAnAccountButton.Click();
            RegistrationForm.Click();
        }

    }
}

