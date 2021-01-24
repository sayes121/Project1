using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace Airline
{
    class Passenger
    {
        public string[] First_Name;
        public string[] Last_Name;
        public string[] Gender;
        private int[] Security_Number = new int[40];
        private int Security;
        Random rand = new Random();
        public int[] Seat_Number = new int[40];
        public const string Departure_time = "6.30 AM";
        public const string Destination_time = "8.30 AM";
        public const string Flight = "JF459";
        public const int Departure_gate = 14;
        public const string Departure_date = "20-JUN-2019";
        public const string Departure_Loc = "BRISBANE";
        public const string Destination = "MELBORNE";
        private int count = 0;

        public Passenger() { }

        public Passenger(int arraysize)
        {
            this.First_Name = new string[arraysize];
            for(int i = 0; i < First_Name.Length; i++)
            {
                First_Name[i] = "0";
            }
            this.Last_Name = new string[arraysize];
            this.Gender = new string[arraysize];
            this.Seat_Number = new int[arraysize];
            for (int i = 0; i < Seat_Number.Length; i++)
            {
                Seat_Number[i] = 0;
            }
        }
        public int boarding_pass
        {
            get;
            set;
        }
        public string[] First
        {
            get
            {
                return First_Name;
            }
            set
            {
                First_Name = value;
            }
        } 
        public string[] Last
        {
            get
            {
                return Last_Name;
            }
            set
            {
                Last_Name = value;
            }
        }
        public string[] Gen
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }
        public int[] Seat
        {
            get
            {
                return Seat_Number;
            }
            set
            {
                Seat_Number = value;
            }
        }
        public void display()//This method is for displaying Boarding Pass
        {
            for (int i = count; i < count + boarding_pass; i++)
            {
                   WriteLine("--------------------------------------------------------------------------------");
                   WriteLine("First name                       :                        {0}", First_Name[i]);
                   WriteLine("Last name                        :                        {0}", Last_Name[i]);
                   WriteLine("Gender                           :                        {0}", Gender[i]);
                   WriteLine("Date of booking                  :                        {0}", DateTime.Now);
                   Security = rand.Next(30000, 999999);
                   Security_Number[i] = Security;
                   WriteLine("Security Number of the passenger :                        {0}", Security_Number[i]);
                   WriteLine("Seat Number                      :                        {0}", Seat_Number[i]);
                   WriteLine("Flight                           :                        {0}", Flight);
                   WriteLine("Departure Time                   :                        {0}", Departure_time);
                   WriteLine("Destination Time                 :                        {0}", Destination_time);
                   WriteLine("FROM                             :                        {0}", Departure_Loc);
                   WriteLine("TO                               :                        {0}", Destination);
                   WriteLine("Date of travelling               :                        {0}", Departure_date);
                   WriteLine("Departure gate                   :                        {0}", Departure_gate);
                   WriteLine("---------------------------------------------------------------------------------");
            }
            count = count + boarding_pass;
        }// End of Display method
        public void Display_info()// This method is accessed by the Airline staff
        {
            for (int i = 0; i < First_Name.Length; i++)
            {
                if (First_Name[i] != "0")
                {
                    WriteLine("------------------------------------------------------------------------------");
                    WriteLine("First name                       :                         {0}", First_Name[i]);
                    WriteLine("Last name                        :                         {0}", Last_Name[i]);
                    WriteLine("Security Number of the passenger :                         {0}", Security_Number[i]);
                    WriteLine("Seat Number                      :                         {0}", Seat_Number[i]);
                    WriteLine("------------------------------------------------------------------------------");
                }
            }
        }// End of Display_info method
        public void Empty_seat_count()// This method is for knowing empty seats available in the flight
        {
            for (int i = 0; i < Seat_Number.Length; i++)
            {
                if (Seat_Number[i] == 0)
                {

                    Write("{0} ", i + 1);
                }
            }
        }// End of Empty_seat_count method
    }// End of class
}// End of namespace
