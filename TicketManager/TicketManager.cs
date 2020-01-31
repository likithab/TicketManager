using System.Collections.Generic;
using TicketManagerApp;

namespace TicketManagerApp
{
    public class TicketManager : ITicketManager
    {
        public TicketManager()
        {

        }
        public TicketManager(IList<PassengerDetails> passengerList)
        {
            AssignTicketNumber(passengerList);
        }

        public int TicketId { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Cost { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int ValidityEndDate { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IList<PassengerDetails> AssignTicketNumber(IList<PassengerDetails> passengerList)
        {
            int TicketNumber = 1;
            foreach (var passenger in passengerList)
            {
                new TicketManager().TicketId = TicketNumber;
                TicketNumber++;
            }
            return passengerList;
        }

        void ITicketManager.CostCalculation(TicketType ticketType)
        {
            throw new System.NotImplementedException();
        }
    }
}
