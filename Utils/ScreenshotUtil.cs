using OpenQA.Selenium;
using System;
using System.IO;

namespace Framework.Utils
{
    public static class ScreenshotUtil
    {
        public static void TakeAndSaveScreenshot(IWebDriver driver)
        {
            ITakesScreenshot? ts = driver as ITakesScreenshot;
            Screenshot screenshot = ts.GetScreenshot();
                
            SaveScreenShotWithTimeStamp(screenshot);
        }

        private static void SaveScreenShotWithTimeStamp(Screenshot screenshot)
        {
            DateTime dateTime = DateTime.Now;
            screenshot.SaveAsFile(@$"C:\Users\Xusniddin\Desktop\Khusniddin\IT\Automed Testing\LocalRepo\ATF-Framework-task\Screenshots\screenshot_{GetTimeStamp(dateTime)}.jpeg");
        }

        private static string GetTimeStamp(DateTime dateTime) => dateTime.ToString("yyyy-MM-dd_HH-mm-ss");
    }
}
