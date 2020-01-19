using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("hi welcome to ticket manager");
            WriteLine("please enter your details to book a ticket");
            PassengerDetails passenger = new PassengerDetails()
            {
                PassengerName = "",
                Age = 0,
                MobileNumber = 0,
            };
            IList<PassengerDetails> passengerList = new List<PassengerDetails>();
            passengerList.Add(passenger);
            ITicketManager ticketManager = new DailyTicketManager();
            ticketManager.CostCalculation(TicketType.Daily);
        }
    }
}
