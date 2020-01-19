using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagerApp
{
    interface ITicketManager
    {
        int TicketId { get; set; }
        int Cost { get; set; }
        int ValidityEndDate { get; set; }
        void CostCalculation(TicketType ticketType);
    }
}
