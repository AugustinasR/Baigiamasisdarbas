using Framework;
using Framework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SearchForFlightsFromSZGTest()
        {
            string expectedValue = "Zalcburgas SZG";

            Homepage.ClickOnTheSelectedFieldToEnterAirport();
            Homepage.ClickOnEmptyFieldToEnter();
            Homepage.EnterAirportToTheSearch("szg");
            Homepage.ClickToConfirmAirport();

            Homepage.ClickSearchForFlights();

            List<string> actualValue = Homepage.GetFlighSearchAnswers();

            foreach (string value in actualValue)
            {
                Assert.AreEqual(expectedValue, value);
            }
        }

        [TearDown]
        public void Teardown()
        {
            Driver.CloseDriver();
        }
    }
}
