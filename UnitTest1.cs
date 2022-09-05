using BookingWebsiteTests.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BookingWebsiteTests
{
    public class Tests
    {
        private IWebDriver _webDriver;
        private readonly By _assertNewYork = By.XPath("//input[@value='New York']");
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Navigate().GoToUrl("https://www.booking.com");
            _webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainPagePageObjects(_webDriver);
            
            mainMenu.SelectEnglishUsVersion()
                .SelectCurrencyUSD()
                .EnterDestinationNewYork()
                .SelectDate();
            var actual = _webDriver.FindElement(_assertNewYork).Text;
            Assert.AreEqual(actual, actual);
        }
    }
}