using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoQA_POM_Homework.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public List<IWebElement> ListOfOptions => Driver.FindElements(By.XPath("//*[@class = 'vertical-list-container mt-4']/div")).ToList();

        public IWebElement TabGrid => Driver.FindElement(By.Id("demo-tab-grid"));

        public List<IWebElement> GridOfOptions => Driver.FindElements(By.XPath("//*[@class = 'create-grid']/div")).ToList();
    }
}
