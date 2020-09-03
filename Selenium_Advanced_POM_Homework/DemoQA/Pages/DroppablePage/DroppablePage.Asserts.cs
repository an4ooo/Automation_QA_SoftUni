using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public void AssertTargetBoxColorIsDifferentBeforeAndAfter(string colorBefore, string colorAfter)
        {
            Assert.IsFalse(colorBefore == colorAfter);
        }

        public void AssertTargetBoxColorIsEqualBeforeAndAfter(string colorBefore, string colorAfter)
        {
            Assert.IsTrue(colorBefore == colorAfter);
        }
    }
}
