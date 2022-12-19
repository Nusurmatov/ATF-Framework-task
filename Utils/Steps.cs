using OpenQA.Selenium;
using System;
using System.Text;

namespace Framework.Utils
{
    public static class Steps
    {
        public static double ExtractCostFromMessage(string message)
        {
            StringBuilder cost = new StringBuilder();
            
            foreach (char c in message)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    cost.Append(c);
                }
            }

            return Math.Round(double.Parse(cost.ToString()), 2);
        }

        public static void TakeAndSaveScreenshot(IWebDriver driver)
        {
            ITakesScreenshot? ts = driver as ITakesScreenshot;
            Screenshot screenshot = ts.GetScreenshot();
                
            SaveScreenShotWithTimeStamp(screenshot);
        }

        private static void SaveScreenShotWithTimeStamp(Screenshot screenshot)
        {
            DateTime dateTime = DateTime.Now;
            screenshot.SaveAsFile(@$"..\..\..\Screenshots\screenshot_{GetTimeStamp(dateTime)}.jpeg");
        }

        private static string GetTimeStamp(DateTime dateTime) => dateTime.ToString("yyyy-MM-dd_HH-mm-ss");
    }
}
