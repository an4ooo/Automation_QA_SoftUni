using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DragabblePage
{
    public partial class DragabblePage : BasePage
    {
        [Obsolete]
        public IWebElement BoxToDrag => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dragBox")));

        public IWebElement AxisTab => Wait.Until(d => d.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/nav/a[2]")));

        public IWebElement BoxToDragX => Driver.FindElement(By.Id("restrictedX"));

        public IWebElement BoxToDragY => Driver.FindElement(By.Id("restrictedY"));
    }
}
