using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.SoftuniCourse
{
    public partial class SoftuniCoursePage : BasePage
    {

        public SoftuniCoursePage(IWebDriver driver) : base(driver)
        {
        }

        [Obsolete]
        public void NavigateToCourse()
        {
            NavigationBarCourse.Click();
            ModulsButton.Click();
            QaModulPageButton.Click();
            QaCoursePageButton.Click();
        }

    }
}
