using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TicketManagerApp;

namespace TicketManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssignTicketTest()
        {
            PassengerDetails passenger = new PassengerDetails()
            {
                PassengerName = "Likitha",
                Age = 10,
                MobileNumber = 190,
                TypeOfTicket = TicketType.Daily,
            };
            IList<PassengerDetails> passengerList = new List<PassengerDetails>();
            passengerList.Add(passenger);
            TicketManager ticketManager = new TicketManager(passengerList);
            Assert.IsNotNull(passenger.TicketNumber);
        }

        [TestMethod]
        public void ClaculateDailyDiscountTest()
        {

        }
    }
}
