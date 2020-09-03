using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Pages.SoftuniCourse
{
    public partial class SoftuniCoursePage : BasePage
    {
        [Obsolete]
        public IWebElement NavigationBarCourse => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span")));

        public IWebElement ModulsButton => Wait.Until(d => d.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div/div[1]/i")));

        [Obsolete]
        public IWebElement QaModulPageButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Quality Assurance - октомври 2019")));
       
        public IWebElement QaCoursePageButton => Wait.Until(d => d.FindElement(By.XPath("//div[@class = 'course-instance-box']/a[contains(@href, 'qa-automation-may-2020')]	")));

        public IWebElement CoursePageHeading => Driver.FindElement(By.XPath("//div[@class='content']/header/h1"));

    }
}
