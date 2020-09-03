using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public void AssertMeasuresNotEqual(string measureBefore, string measureAfter)
            {
                Assert.AreNotEqual(measureBefore, measureAfter);
            }
    }
}
