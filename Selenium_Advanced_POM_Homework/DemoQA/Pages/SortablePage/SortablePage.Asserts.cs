using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public void AssertElementIsMoved(string expextedElement, string actualElement)
        {
            Assert.AreEqual(expextedElement, actualElement);
        }
    }
}
