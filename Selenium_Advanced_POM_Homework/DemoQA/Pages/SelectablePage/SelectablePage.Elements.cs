using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public IWebElement BoxToSelect => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[1]/ul/li[1]"));

        public IWebElement GridTab => Driver.FindElement(By.Id("demo-tab-grid"));           

        public IWebElement BoxToSelectSeven => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[3]/li[1]"));
    }
}
