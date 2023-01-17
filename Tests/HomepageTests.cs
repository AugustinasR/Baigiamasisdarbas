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
        public void TodaysDate() 
        {
            DateTime today = DateTime.Today;
            string customFormatDate = "yyyy-MM-dd";
            string expectedDateFrom = today.ToString(customFormatDate);

            string actualDateFrom = Homepage.GetValueOfDate();

            Assert.AreEqual(expectedDateFrom, actualDateFrom);
        }

        [Test]
        public void DateTo()
        {
            DateTime today = DateTime.Today;
            DateTime oneMonthFromToday = today.AddMonths(1).AddDays(-1);
            string customFormatDate = "yyyy-MM-dd";
            string expectedDateTo = oneMonthFromToday.ToString(customFormatDate);

            string actualDateTo = Homepage.ValueToDate();

            Assert.AreEqual(expectedDateTo, actualDateTo);
        }

        [Test]
        public void SearchForFlightsFrom()
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
        public void CarRental()
        {
            string expectedUrl = "https://www.hertz.com/rentacar/reservation/";

            Homepage.ClickServicesButton();
            Homepage.ClickCarRentalButton();
            Homepage.ClickOnHertzButton();

            string actualUrl = Driver.GetDriver().Url;

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Test]
        public void CovidRestrictions()
        {
            string expectedMessage = "Atvykstant į Lietuvą nebetaikomi jokie COVID-19 reikalavimai";

            Homepage.ClickDirectionsButton();
            Homepage.SelectDropDownListIfIzolationIsRequired();
            Homepage.ClickFilterButton();

            string actualMessage = Homepage.AnswerMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public void Teardown()
        {
            Driver.CloseDriver();
        }
    }
}
