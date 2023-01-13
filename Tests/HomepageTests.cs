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
        public void SearchForFlightsToRigaTest()
        {
            Homepage.ClickOnTheSelectedFieldToEnterAirport();
            Homepage.ClickOnEmptyFieldToEnter();
            Homepage.EnterRixAirportToTheSearch("Rix");
            Homepage.ClickToConfirmRixAirport();
        }

        //[TearDown]
        //public void Teardown()
        //{
        //    Driver.CloseDriver();
        //}
    }
}
