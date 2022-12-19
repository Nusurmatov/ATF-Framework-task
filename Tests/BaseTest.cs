using NUnit.Framework;
using OpenQA.Selenium;
using Framework.Driver;
using Framework.Pages;

namespace Framework
{
    public class BaseTest
    {
        protected IWebDriver Driver;

        protected LoginPage LoginPage;

        protected GoogleCloudMainPage GoogleCloudMainPage;

        protected GoogleCloudPricingCalculatorPage PricingCalculatorPage;

        protected YopMailPage YopMailPage;

        [SetUp]
        public void SetUp()
        {
            this.Driver = DriverSingleton.GetInstance(BrowserDrivers.Edge);
            this.LoginPage = new LoginPage(this.Driver);
            this.GoogleCloudMainPage = new GoogleCloudMainPage(this.Driver);
            this.PricingCalculatorPage = new GoogleCloudPricingCalculatorPage(this.Driver);
            this.YopMailPage = new YopMailPage(this.Driver);
        }

        [TearDown]
        public void TearDown()
        {
           DriverSingleton.CloseBrowser();
        }
    }
}