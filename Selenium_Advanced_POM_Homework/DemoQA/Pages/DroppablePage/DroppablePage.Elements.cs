using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA_POM_Homework.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        [Obsolete]
        public IWebElement SourceBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("draggable")));

        [Obsolete]
        public IWebElement TargetBox => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("droppable")));

        public IWebElement AcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));

        [Obsolete]
        public IWebElement SourceAcceptableBox => Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("acceptable")));
   
        public IWebElement SourceNotAcceptableBox => Wait.Until(d => d.FindElement(By.Id("notAcceptable")));
        
        public IWebElement TargetBoxAccept => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[2]/div[1]/div/div[2]/div/div[2]"));

    }
}
