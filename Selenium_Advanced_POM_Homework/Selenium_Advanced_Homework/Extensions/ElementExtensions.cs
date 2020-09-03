using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Extensions
{
    public static class ElementExtensions
    {
        public static WebElement ScrollTo(this WebElement element)
        {
            ((IJavaScriptExecutor)element).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
    }
}
