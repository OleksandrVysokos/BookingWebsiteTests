using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebsiteTests.PageObjects
{
    class MainPagePageObjects
    {
        private IWebDriver _webdriver;
        private readonly By _selectLanguageButton = By.XPath("//button[@data-modal-id='language-selection']");
        private readonly By _selectEngUS = By.XPath("//a[@data-lang='en-us']");
        private readonly By _selectCurrencyButton = By.XPath("//button[@data-modal-header-async-type='currencyDesktop']");
        private readonly By _selectUsd = By.XPath("//a[@data-modal-header-async-url-param='changed_currency=1&selected_currency=USD&top_currency=1']");
        private readonly By _searchCityField = By.XPath("//input[@type='search']");
        private const string _destinationNewYork = "New York";
        private readonly By _searchButton = By.CssSelector(".sb-searchbox__button");
        private readonly By _dateField = By.XPath("//span[@class='sb-date-field__icon sb-date-field__icon-btn bk-svg-wrapper calendar-restructure-sb']");
        private readonly By _nextMonthClick = By.XPath("//div[@data-bui-ref='calendar-next']");
        private readonly By _findDecember1 = By.XPath("//td[@data-date='2022-12-01']");
        private readonly By _findDecember31 = By.XPath("//td[@data-date='2022-12-31']");
        public readonly By _assertNewYork = By.XPath("//input[@value='New York']");


        public MainPagePageObjects(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
        public MainPagePageObjects SelectEnglishUsVersion()
        {
            WaitUntil.WaitElement(_webdriver, _selectLanguageButton);
            _webdriver.FindElement(_selectLanguageButton).Click();
            WaitUntil.WaitElement(_webdriver, _selectEngUS);
            _webdriver.FindElement(_selectEngUS).Click();
            return new MainPagePageObjects(_webdriver);
        }
        public MainPagePageObjects SelectCurrencyUSD()
        {
            WaitUntil.WaitElement(_webdriver, _selectCurrencyButton);
            _webdriver.FindElement(_selectCurrencyButton).Click();
            WaitUntil.WaitElement(_webdriver, _selectUsd);
            _webdriver.FindElement(_selectUsd).Click();
            return new MainPagePageObjects(_webdriver);
        }
        public MainPagePageObjects EnterDestinationNewYork()
        {
            WaitUntil.WaitElement(_webdriver, _searchCityField);
            _webdriver.FindElement(_searchCityField).Click();
            WaitUntil.WaitElement(_webdriver, _searchCityField);
            _webdriver.FindElement(_searchCityField).SendKeys(_destinationNewYork);
            return new MainPagePageObjects(_webdriver);
        }
        public MainPagePageObjects SelectDate()
        {
            WaitUntil.WaitElement(_webdriver, _dateField);
            _webdriver.FindElement(_dateField).Click();
            WaitUntil.WaitElement(_webdriver, _nextMonthClick);
            _webdriver.FindElement(_nextMonthClick).Click();
            _webdriver.FindElement(_nextMonthClick).Click();
            WaitUntil.WaitElement(_webdriver, _findDecember1);
            _webdriver.FindElement(_findDecember1).Click();
            _webdriver.FindElement(_findDecember31).Click();
            WaitUntil.WaitElement(_webdriver, _searchButton);
            _webdriver.FindElement(_searchButton).Click();
            return new MainPagePageObjects(_webdriver);
        }
    }
}
