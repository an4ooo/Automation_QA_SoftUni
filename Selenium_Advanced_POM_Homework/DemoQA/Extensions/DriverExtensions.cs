using OpenQA.Selenium;
using System.Threading;

namespace Selenium_POM_Homework.Extensions
{
    public static class DriverExtensions
    {
        public static void ScrollTo(this IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }


    }
}
