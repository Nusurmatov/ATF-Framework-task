using NUnit.Framework;
using OpenQA.Selenium;
using Framework.Pages;
using System;
using Framework.Utils;
using Framework.Driver;

namespace Framework.Tests
{
    [TestFixture]
    public class SmokeTest : BaseTest
    {
        [Test]
        public void GoToPricingCalculaterPageTest()
        {
            try
            {
                GoogleCloudMainPage.GoTo();
                GoogleCloudMainPage.GoToPricingCalculatorPage();
                Console.WriteLine(Driver.Title);
               
                Assert.IsTrue(Driver.Title.Contains("Google Cloud Pricing Calculator"));
            }
            catch (WebDriverException ex)
            {
                Steps.TakeAndSaveScreenshot(Driver);
                Console.WriteLine(ex.StackTrace);
               
                Assert.Fail(ex.Message);
            }
            finally
            {
                DriverSingleton.CloseBrowser();
            }
        }

        [Test]
        public void LoginTest()
        {
            try
            {
                GoogleCloudMainPage.GoTo();
                GoogleCloudMainPage.SignInIcon.Click();
                LoginPage.Login(email: YopMailPage.GenerateRandomEmail(Driver), password: "passwordToBeFailed");
                
                Assert.IsTrue(GoogleCloudMainPage.SearchBox.Displayed);
            }
            catch(WebDriverException ex)
            {
                Steps.TakeAndSaveScreenshot(Driver);
                Console.WriteLine(ex.StackTrace);
               
                Assert.Fail(ex.Message);
            }
            finally
            {
                DriverSingleton.CloseBrowser();
            }
        }
    }
}