using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public void AssertNotEqualColorBeforeAndAfter(string colorBefore, string colorAfter)
        {
            Assert.AreNotEqual(colorBefore, colorAfter);
        }
    }
}
