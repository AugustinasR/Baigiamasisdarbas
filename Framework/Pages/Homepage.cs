using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Framework.Pages
{
    public class Homepage
    {
        public static string enterAirportNameLocator = "//*[@id='select2-arrival-select-container']";
        public static string emptyFieldLocator = "//*[contains(@class,'select2-search__')]";
        public static string confirmRIXLocator = "//li[contains(@class,'select2-results__option')]";
        public static string searchForFlightsLocator = "//*[@id='skrydziu-tvarkarastis']/div/form/div[3]/button";
        public static string dateFromLocator = "//*[@id='flights-widget-date-from']";
        public static string dateToLocator = "//*[@id='flights-widget-date-to']";
        public static string searchAnswersLocator = "//*[@id=\"nav-tabContent\"]/div[1]/div/table/tbody/tr/td[3]/span[1]";
        public static string actualDate = "//*[@id=\"flights-widget-date-from\"]";
        public static string dateLocator = "//*[@id='flights-widget-date-from']";

        public static void Open()
        {
            Driver.OpenPage("https://www.vilnius-airport.lt/");
            Common.WaitAndClick("//*[@id='CybotCookiebotDialogBodyButtonDecline']");
            Common.WaitAndClick("//*[@class='close-popup']");
            //Common.WaitForElementToBeClickable("//*[@class='close-popup']");
        }

        public static void ClickOnTheSelectedFieldToEnterAirport()
        {
            Common.ClickElement(enterAirportNameLocator);
        }

        public static void EnterAirportToTheSearch(string name)
        {
            Common.SendKeysToElement(emptyFieldLocator, name);
        }

        public static void ClickOnEmptyFieldToEnter()
        {
            Common.ClickElement(emptyFieldLocator);
        }

        public static void ClickToConfirmAirport()
        {
            Common.ClickElement(confirmRIXLocator);
        }

        public static void ClickSearchForFlights()
        {
            Common.ClickElement(searchForFlightsLocator);
        }

        public static void ClickDateFrom()
        {
            Common.ClickElement(dateFromLocator);
        }

        public static void EnterDateFrom(string dateFrom)
        {
            Common.SendKeysToElement(dateFromLocator, dateFrom);
        }

        public static void ClickDateTo()
        {
            Common.ClickElement(dateToLocator);
        }

        public static void EnterDateTo(string dateTo)
        {
            Common.SendKeysToElement(dateToLocator, dateTo);
        }

        public static void ClearDateFrom()
        {
           Common.ClearInputElement(dateFromLocator);
        }

        public static void ClearDateTo()
        {
            Common.ClearInputElement(dateToLocator); 
        }

        public static List<string> GetFlighSearchAnswers()
        {
            return Common.GetListElementText(searchAnswersLocator);
        }

        public static string GetValueOfDate()
        {
            return Common.GetAttributeValue(dateLocator, "value");
        }

        public static string ValueToDate()
        {
            return Common.GetAttributeValue(dateToLocator, "value");
        }
    }
}
