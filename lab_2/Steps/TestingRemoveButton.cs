using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using lab_2.PageObjects;

namespace test_lab_2.Steps
{
    [Binding]
    public class TestingRemoveButton
    {
        private IWebDriver driver;
        private LoginPage LoginPage;
        private MainPage MainPage;
        private CartPage CartPage;

        public TestingRemoveButton()
        {
            driver = new ChromeDriver("C:/Users/kosti/.cache/selenium/chromedriver/win64/118.0.5993.70/chromedriver.exe");
            LoginPage = new LoginPage(driver);
            MainPage = new MainPage(driver);
            CartPage = new CartPage(driver);
        }

        [Given(@"The problem_user is logged into saucedemo.com")]
        public void GivenTheProblemUserIsLoggedIntoSaucedemoCom()
        {
            LoginPage.ClickOnLoginButton();
        }

        [Given(@"The user adds a product to the cart")]
        public void AndIAddAnItemToTheCart()
        {
            MainPage.ClickOnAddToCart();
        }

        [When(@"The user navigates to the cart")]
        public void WhenTheUserNavigatesToTheCart()
        {
            MainPage.GoToCart();
        }

        [When(@"The user clicks on the REMOVE button for the product")]
        public void WhenTheUserClicksOnTheRemoveButtonForTheProduct()
        {
            CartPage.ClickOnRemoveFromCart();
        }

        [Then(@"The product should be removed from the cart")]
        public void ThenTheProductShouldBeRemovedFromTheCart()
        {
            Assert.IsFalse(IsElementPresent(By.ClassName("cart_button")));
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        [After]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
