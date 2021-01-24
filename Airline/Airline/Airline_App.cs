using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Airline_App
    {
        static int[] arraysize = new int[40];
        static Passenger Name = new Passenger(40);
        static void Main(string[] args)
        {
            FirstMethod();
            ReadKey();
        }// End of main method

        public static int counter = 0;
        public static int count_booking = 0;

        public static void FirstMethod()
        {
            int detail;
            string answer;
            WriteLine("-------------WELCOME TO AIRLINE TICKET BOOKING-------------------");
            WriteLine("---------Press 1 for Passenger and 2 for Airline staff-----------");
            answer = ReadLine();
            detail = Convert.ToInt32(answer);
            switch (detail)
            {
                case 1:
                    WriteLine("Selected as passenger - Please do the bookings");
                    Booking();
                    break;
                case 2:
                    WriteLine("Selected as Airline staff");
                    int info;
                    string ans;
                    WriteLine("--------------------------------------------------");
                    WriteLine("|Press 1 for issueing Ticket                     |");
                    WriteLine("|Press 2 for Viewing Passenger details           |");
                    WriteLine("|Press 3 for knowing the available seats         |");
                    WriteLine("--------------------------------------------------");
                    WriteLine("The option selected:");
                    ans = ReadLine();
                    info = Convert.ToInt32(ans);
                    switch (info)
                    {
                        case 1:
                            WriteLine("Issueing Boarding Pass");
                            Booking();
                            break;
                        case 2:
                            Name.Display_info();
                            Continuing();
                            break;
                        case 3:
                            WriteLine("Empty seats are listed below:");
                            Name.Empty_seat_count();
                            Continuing();
                            break;
                    }
                    break;
            }

        }
        public static void Booking()
        {
            string temp = "";
            string fname;
            int no_of_tickets;
            WriteLine("*****************************************************************************************************************");
            WriteLine("Ticket bookings for how many passengers:");
            int.TryParse(ReadLine(), out no_of_tickets);
            Name.boarding_pass = no_of_tickets;
            for (int i = count_booking; i < (count_booking + no_of_tickets); i++)
            {
                WriteLine("*****************************************************************************************************************");
                WriteLine("Enter the First name:");
                fname = ReadLine();
                Name.First[i] = fname;
                if (Name.First[i] != "0")
                {
                    temp = Name.First[i];
                    if (temp.Length > 5)
                    {
                        temp = temp.Remove(5);
                        Name.First[i] = temp;
                    }
                }
                WriteLine("*****************************************************************************************************************");
                WriteLine("Enter the last name:");
                Name.Last[i] = ReadLine();
                if (Name.Last[i] != "0")
                {
                    temp = Name.Last[i];
                    if (temp.Length > 5)
                    {
                        temp = temp.Remove(5);
                        Name.Last[i] = temp;
                    }
                }// First name and Last name evaluation for displaying first five characters of the name
                WriteLine("*****************************************************************************************************************");
                WriteLine("Enter the Gender:");
                Name.Gen[i] = ReadLine();// Gender details are obtained
                Name.Seat[i] = ++counter;//Seat Evaluation is performed 
            }
            count_booking = count_booking + no_of_tickets;
            Name.display();
            Continuing();
        }// End of Booking method
        public static void Continuing()// This method is used for continuing the defined process 
        {
            string nxt_pass;
            WriteLine("Do you wish to continue your bookings? Y/N");
            nxt_pass = ReadLine();
            if (nxt_pass == "Y" || nxt_pass == "y")
            {
                FirstMethod();
            }
            else if (nxt_pass == "N" || nxt_pass == "n")
            {
                WriteLine("Thanks for booking!... Enjoy your trip");
            }
        }//End of Continuing method
    }// End of class
}// End of namespace
