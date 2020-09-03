using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.SoftuniCourse
{
    public partial class SoftuniCoursePage : BasePage
    {
        public void AssertHeading()
        {
            Assert.AreEqual("QA Automation - май 2020", CoursePageHeading.Text);
        }
    }
}
