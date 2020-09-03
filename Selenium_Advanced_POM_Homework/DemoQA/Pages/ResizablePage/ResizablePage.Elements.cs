using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public IWebElement BoxToResize => Driver.FindElement(By.Id("resizable"));

        public IWebElement ResizableHandle => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[2]/div/span"));

        public IWebElement BoxWithRestrictinToResize => Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        public IWebElement ResizableRestrictHandle => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div[1]/div/span"));
    }
}
