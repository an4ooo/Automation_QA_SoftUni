using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DemoQAPage
{
    public partial class DemoQAPage : BasePage
    {
        public void AssertPageIsLoaded(string pageTitle)
        {
            Assert.AreEqual(pageTitle, InteractionPageTitle.Text);
        }
    }
}
