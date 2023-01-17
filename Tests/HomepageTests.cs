using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    internal class HomepageTests
    {
        [SetUp]
       public void SetUp()
        {
            Driver.CreateDriver();
            Homepage.Open();
        }

        [Test]
        public void TodaysDateTest() 
        {
            DateTime today = DateTime.Today;

            string customFormatDate = "yyyy-MM-dd";
            string formattedDate = today.ToString(customFormatDate);

            string actualDate = Homepage.GetValueOfDate();

            Assert.AreEqual(formattedDate, actualDate);
        }

        [Test]
        public void DateToTest()
        {
            DateTime today = DateTime.Today;
            DateTime oneMonthFromToday = today.AddMonths(1).AddDays(-1);
            string customFormatDate = "yyyy-MM-dd";
            string expectedResult = oneMonthFromToday.ToString(customFormatDate);

            string actualDateTo = Homepage.ValueToDate();

            Assert.AreEqual(expectedResult, actualDateTo);
        }

        [Test]
        public void SearchForFlightsFromTest()
        {
            string expectedValue = "Ryga RIX";

            Homepage.ClickOnTheSelectedFieldToEnterAirport();
            Homepage.ClickOnEmptyFieldToEnter();
            Homepage.EnterAirportToTheSearch("rix");
            Homepage.ClickToConfirmAirport();

            Homepage.ClickSearchForFlights();

            List<string> actualValue = Homepage.GetFlighSearchAnswers();

            foreach (string value in actualValue)
            {
                Assert.AreEqual(expectedValue, value);
            }
        }

        [Test]
        public void CarRentalTest()
        {
            string expectedurlValue = "https://www.hertz.com/rentacar/reservation/";

            Homepage.ClickServicesButton();
            Homepage.ClickCarRentalButton();
            Homepage.ClickOnHertzButton();

            string actualUrl = Driver.GetDriver().Url;

            Assert.AreEqual(expectedurlValue, actualUrl);
        }

        [Test]
        public void CovidRestrictionsTest()
        {
            string expectedAnswer = "Atvykstant į Lietuvą nebetaikomi jokie COVID-19 reikalavimai";

            Homepage.ClickDirectionsButton();
            Homepage.SelectDropDownListIfIzolationIsRequired();
            Homepage.ClickFilterButton();

            string actualAnswer = Homepage.AnswerMessage();

            Assert.AreEqual(expectedAnswer, actualAnswer);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.CloseDriver();
        }
    }
}
