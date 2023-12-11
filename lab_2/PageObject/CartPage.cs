using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2.PageObjects
{
    internal class CartPage
    {
        private IWebDriver driver;
        private By removeFromCartBtn = By.Id("remove-sauce-labs-backpack");

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnRemoveFromCart()
        {
            driver.FindElement(removeFromCartBtn).Click();
        }
    }
}
