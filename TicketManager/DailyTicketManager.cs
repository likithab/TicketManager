using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagerApp
{
    class DailyTicketManager : ITicketManager
    {
        public int TicketId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ValidityEndDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CostCalculation(TicketType ticketType)
        {
            throw new NotImplementedException();
        }
    }
}
