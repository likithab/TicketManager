using static System.Console;

namespace TicketManagerApp
{
    internal class PassengerDetails
    {
        public PassengerDetails()
        {

        }
        public PassengerDetails(string name, int age, int mobileNumber)
        {
            WriteLine("Enter your Name");
            PassengerName = name;
            WriteLine("Enter your age");
            Age = age;
            WriteLine("Enter your mobile number");
            MobileNumber = mobileNumber;
            WriteLine("Enter the ticket type");
        }
        public string PassengerName { get; set; }
        public int Age { get; set; }
        public int MobileNumber { get; set; }
        public TicketType TypeOfTicket{ get; set; }        
    }
}