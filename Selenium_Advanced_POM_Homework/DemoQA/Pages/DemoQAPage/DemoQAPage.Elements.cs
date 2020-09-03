using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DemoQAPage
{
    public partial class DemoQAPage : BasePage
    {
        public IWebElement InteractionsSection => Wait.Until(d => d.FindElement(By.XPath("//*[text() = 'Interactions']//ancestor::div[@class = 'card mt-4 top-card']")));

        public IWebElement InteractionsSubSection(string subSectionName) => Wait.Until(d => d.FindElement(By.XPath($"//*[normalize-space(text())='{subSectionName}']")));

        public IWebElement InteractionPageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}
