using System.Collections.Generic;
using TicketManagerApp;

namespace TicketManagerApp
{
    public class TicketManager
    {
        public TicketManager(IList<PassengerDetails> passengerList)
        {
            AssignTicketNumber(passengerList);
        }

        public IList<PassengerDetails> AssignTicketNumber(IList<PassengerDetails> passengerList)
        {
            int TicketNumber = 1;
            foreach (var passenger in passengerList)
            {
                passenger.TicketNumber = TicketNumber;
                TicketNumber++;
            }
            return passengerList;
        }


    }
}
