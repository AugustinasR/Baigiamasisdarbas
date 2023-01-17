using System.Collections.Generic;

namespace Framework.Pages
{
    public class Homepage
    {
        private static string enterAirportNameLocator = "//*[@id='select2-arrival-select-container']";
        private static string emptyFieldLocator = "//*[contains(@class,'select2-search__')]";
        private static string confirmRIXLocator = "//li[contains(@class,'select2-results__option')]";
        private static string searchForFlightsLocator = "//*[@id='skrydziu-tvarkarastis']/div/form/div[3]/button";
        private static string dateToLocator = "//*[@id='flights-widget-date-to']";
        private static string searchAnswersLocator = "//*[@id='nav-tabContent']//table/tbody/tr/td[3]/span[1]";
        private static string dateLocator = "//*[@id='flights-widget-date-from']";
        private static string airportServicesLocator = "//*[@id='navbar-bottom-content']/ul/li[2]/div/a";
        private static string carRentalButtonLocator = "//a[@title='Automobilių nuoma']";
        private static string hertzButton = "//a[@href='https://www.hertz.com/rentacar/reservation/']";
        private static string directionsLocator = "//span[@class='btn btn-primary']";
        private static string isolationYesOption = "//*[@id=\"isolate-in\"]/option[2]";
        private static string filterButtonLocator = "//*[@id='directions-filters']/form/div[8]/input";
        private static string answerLocator = "//*[@id='page-iframe']/div/div[6]";
        private static string cookiesDeclineLocator = "//*[@id='CybotCookiebotDialogBodyButtonDecline']";
        private static string addPopupCloseLocator = "//*[@class='close-popup']";
        private static string loadingSpinnerLocator = "//*[@class='loading-spinner']";

        public static void Open()
        {
            Driver.OpenPage("https://www.vilnius-airport.lt/");
            Common.WaitAndClick(cookiesDeclineLocator);
            Common.WaitAndClick(addPopupCloseLocator);
        }

        public static void ClickOnTheSelectedFieldToEnterAirport()
        {
            Common.ClickElement(enterAirportNameLocator);
        }

        public static void EnterAirportToTheSearch(string name)
        {
            Common.SendKeysToElement(emptyFieldLocator, name);
        }

        public static void ClickToConfirmAirport()
        {
            Common.ClickElement(confirmRIXLocator);
        }

        public static void ClickSearchForFlights()
        {
            Common.ClickElement(searchForFlightsLocator);
        }

        public static List<string> GetFlighSearchAnswers()
        {
            Common.WaitForElementToBeInvisible(loadingSpinnerLocator);
            return Common.GetElementTextList(searchAnswersLocator);
        }

        public static string GetValueOfDate()
        {
            return Common.GetAttributeValue(dateLocator, "value");
        }

        public static string ValueToDate()
        {
            return Common.GetAttributeValue(dateToLocator, "value");
        }

        public static void ClickServicesButton()
        {
            Common.ClickElement(airportServicesLocator);
        }

        public static void ClickCarRentalButton()
        {
            Common.ClickElement(carRentalButtonLocator);
        }

        public static void ClickDirectionsButton()
        {
            Common.ClickElement(directionsLocator);
        }

        public static void SelectYesInDropdownIfIsolationIsRequired()
        {
            Common.ClickElement(isolationYesOption);
        }

        public static void ClickFilterButton()
        {
            Common.ClickElement(filterButtonLocator);
        }

        public static string AnswerMessage()
        {
          return  Common.GetElementText(answerLocator);
        }

        public static void ClickOnHertzButton()
        {
            
            Common.ClickElement(hertzButton);

            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
            
        }
    }
}
