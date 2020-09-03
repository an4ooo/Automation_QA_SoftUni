using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.AutomationPracticeRegistration
{
    public partial class AutoPracticeFormPage : BasePage
    {
        public IWebElement SignInButton => Wait.Until(d => d.FindElement(By.ClassName("login")));

        [Obsolete]
        public IWebElement EnterValidEmailField => Wait.Until(ExpectedConditions.ElementExists(By.Id("email_create")));

        public IWebElement CreateAnAccountButton => Driver.FindElement(By.Id(@"SubmitCreate"));

        [Obsolete]
        public IWebElement RegistrationForm => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("account-creation_form")));

        public IWebElement EmailField => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[4]/input")));

        public IWebElement FirstName => Driver.FindElement(By.Id("customer_firstname"));

        public IWebElement LastName => Driver.FindElement(By.Id("customer_lastname"));

        public IWebElement Password => Driver.FindElement(By.Id("passwd"));

        public IWebElement Adress => Driver.FindElement(By.Id("address1"));

        public IWebElement City => Driver.FindElement(By.Id("city"));

        public IWebElement State(string optiontext) => Driver.FindElement(By.XPath($"//select[@id='id_state']//option[text()='{optiontext}']"));


        [Obsolete]
        public IWebElement CurrentState(int stateNum) => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//*[@class = 'selector']/*[@id='id_state']/option[@value={stateNum}]")));


        public IWebElement Postcode => Driver.FindElement(By.Id("postcode"));

        public IWebElement PhoneNumber => Driver.FindElement(By.Id("phone_mobile"));

        public IWebElement SubmitButton => Driver.FindElement(By.Id("submitAccount"));

        [Obsolete]
        public IWebElement ErrorMessage => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class = 'alert alert-danger']")));

        [Obsolete]
        public IWebElement ErrorMessageEmail => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("create_account_error")));

        public IWebElement CurrentErrorPhoneNumber => Wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@class='alert alert-danger']//li[(text()) = 'phone_mobile is too long. Maximum length: 32']")));

        public IWebElement CurrentErrorMessage(string errorText) => Wait.Until<IWebElement>(d => d.FindElement(By.XPath($"//*[@class = 'alert alert-danger']//li/b[(text() = '{errorText}')]")));

    }
}
