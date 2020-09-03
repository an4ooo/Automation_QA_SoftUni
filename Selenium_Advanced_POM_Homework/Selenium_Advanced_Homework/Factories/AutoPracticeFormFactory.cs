using Selenium_POM_Homework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_POM_Homework.Factories
{
    public class AutoPracticeFormFactory
    {
        public static AutoPracticeFormModel Create()
        {
            return new AutoPracticeFormModel
            {
                FirstName = "Ivanka",
                LastName = "Ivanova",
                Email = "qwerty@abv.bg",
                Password = "12345",
                Adress = "Softuni 1",
                City = "Sofia",
                State = "Alabama",
                Postcode = "11111",
                PhoneNumber = "123456789"
            };
        }
    }
}
