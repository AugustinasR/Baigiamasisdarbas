using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Framework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void WaitForElementToBeClickable(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void WaitAndClick(string locator)
        {
            WaitForElementToBeClickable(locator);
            ClickElement(locator);
        }

        internal static void SendKeysToElement(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static void ClearInputElement(string locator)
        {
            GetElement(locator).Clear();
        }

        public static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickMultipleElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                return;
            }
        }

        internal static string GetDateValue(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static List<string> GetListElementText(string locator)
        {
            List<string> destinations = new List<string>();

            int currentAttempt = 1;
            int maxAttempts = 5;
            while (currentAttempt < maxAttempts)
            {
                try
                {
                    List<IWebElement> elements = GetElements(locator);

                    foreach (IWebElement element in elements)
                    {
                        destinations.Add(element.Text);
                    }

                    return destinations;
                }
                catch(StaleElementReferenceException)
                {
                    currentAttempt++;
                }
            }
            return destinations;
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }
    }
}
