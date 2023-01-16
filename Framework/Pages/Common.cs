﻿using OpenQA.Selenium;
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

            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                destinations.Add(element.Text);
            }

            return destinations;
                                   
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static List<string> GetWindowHandles()
        {
            return Driver.GetDriver().WindowHandles.ToList();
        }

        internal static string GetCurrentWindowHandle()
        {
            return Driver.GetDriver().CurrentWindowHandle;
        }

        internal static void SwitchToNewUrlFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = GetWindowHandles();
            foreach (string handle in handles)
            {
                if (handle != parentWindowHandle)
                {
                    SwitchToWindowByHandle(handle);
                    break;
                }
            }
        }

        private static void SwitchToWindowByHandle(string handle)
        {
            Driver.GetDriver().SwitchTo().Window(handle);
        }

        internal static void WaitForElementToBeInvisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(locator)));
        }
    }

}
