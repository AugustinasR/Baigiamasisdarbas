using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class Homepage
    {
        public static string enterAirportNameLocator = "//*[@id='select2-arrival-select-container']";
        public static string emptyFieldLocator = "//*[contains(@class,'select2-search__')]";
        public static string confirmRIXLocator = "//li[contains(@class,'select2-results__option')]";

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

        public static void EnterRixAirportToTheSearch(string name)
        {
            Common.SendKeysToElement(emptyFieldLocator, name);
        }

        public static void ClickOnEmptyFieldToEnter()
        {
            Common.ClickElement(emptyFieldLocator);
        }

        public static void ClickToConfirmRixAirport()
        {
            Common.ClickElement(confirmRIXLocator);
        }
    }
}
