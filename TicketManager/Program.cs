﻿using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace TicketManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("hi welcome to ticket manager");
            WriteLine("please enter your details to book a ticket");
            PassengerDetails passenger = new PassengerDetails();            
            WriteLine("Enter your Name");
            passenger.PassengerName = "Likitha";
            WriteLine("Enter your age");
            passenger.Age = 20;
            WriteLine("Enter your mobile number");
            passenger.MobileNumber = 237981;
            WriteLine("Enter the ticket type 1 - Daily \n 2 - Monthly \n 3 - Yearly");
            int type = ToUInt16(ReadLine());
            switch (type)
            {
                case 1:
                    passenger.TypeOfTicket = TicketType.Daily;
                    break;
                case 2:
                    passenger.TypeOfTicket = TicketType.Monthly;
                    break;
                case 3:
                    passenger.TypeOfTicket = TicketType.Yearly;
                    break;
                default:
                    throw new System.Exception("invalid choice made by user");                    
            }
            IList<PassengerDetails> passengerList = new List<PassengerDetails>();
            passengerList.Add(passenger);
            TicketManager manager = new TicketManager(passengerList);
            
            WriteLine("The passenger details are");
            foreach (var person in passengerList)
            {
                WriteLine("passenger Name "+person.PassengerName);
                WriteLine("passenger age "+person.Age);
                WriteLine("Ticket Number "+person.TicketNumber);
            }
            //ITicketManager ticketManager = new DailyTicketManager();
            //ticketManager.CostCalculation(TicketType.Daily);
        }
    }
}
