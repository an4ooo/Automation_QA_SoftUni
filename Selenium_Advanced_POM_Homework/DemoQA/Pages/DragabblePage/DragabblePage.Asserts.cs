using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DragabblePage
{
    public partial class DragabblePage : BasePage
    {
        public void AssertNotEqualPositionBeforeAndAfter(int positionBefore, int positionAfter)
        {
            Assert.AreNotEqual(positionBefore, positionAfter);
        }

        public void AssertEqualPositionBeforeAndAfter(int positionBefore, int positionAfter)
        {
            Assert.AreEqual(positionBefore, positionAfter);
        }
    }
}
