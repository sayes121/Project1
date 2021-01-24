using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace Cashless_pays
{
    class Program
    {
        static void Main(string[] args)
        {
            double disc = 0;
            double reduced_cost = 0;
            string products_String_val;
            string next_shopper;
            const int maximum_value = 8;
            const int minimum_value = 1;
            double price_val = 0;
            int total_prod = 0;
            double total_purchase_cost = 0;
            int cust = 1;
            string item_name;


            while (cust > 0)            
            {
                bool pay = false;        
                while (pay == false)
                {
                    bool product = false;    
                    while (product == false)
                    {
                        WriteLine("enter name of item"); 
                        item_name = ReadLine();
                        if (item_name.Length >= maximum_value || item_name.Length < minimum_value)
                        {

                            WriteLine(" enter valid product name");
                        }
                        else
                        {
                            product = true;
                        }
                    }
                    bool validcost = false;
                    while (validcost == false)  
                    {
                        WriteLine(" enter price_val of item");
                        double.TryParse(ReadLine(), out price_val);

                        if (price_val < minimum_value)  
                        {
                            WriteLine(" enter a valid price_val");

                        }
                        else
                        {

                            validcost = true;
                        }


                    }
                    bool nextprod = false;
                    while (nextprod == false)   
                    {

                        WriteLine("Does a customer have any more items? (Y/N)");
                        products_String_val = ReadLine();
                        if (products_String_val == "Y" || products_String_val == "y")
                        {
                            total_prod++;
                            total_purchase_cost = total_purchase_cost + price_val;
                            nextprod = true;
                            pay = false;

                        }
                        else if (products_String_val == "N" || products_String_val == "n")
                        {
                            nextprod = true;
                            pay = true;
                        }
                        else
                            WriteLine(" enter valid input");
                    }

                }
                WriteLine();

                total_prod = total_prod + 1;
                total_purchase_cost = total_purchase_cost + price_val;
                
                if (total_purchase_cost < 100)
                {
                    disc = 0;
                }
                else if (total_purchase_cost >= 100 && total_purchase_cost <= 300)
                {
                    disc = 1.5;

                }
                else if (total_purchase_cost > 300)
                {
                    disc = 2.5;

                }
                WriteLine();
                WriteLine("Total items:  " + total_prod);
                WriteLine("Total price_val:  " + total_purchase_cost.ToString("C"));
                WriteLine("Discount(" + disc + "%): " + (total_purchase_cost * disc / 100).ToString("C"));
                reduced_cost = total_purchase_cost - (total_purchase_cost * disc / 100);
                WriteLine("Final price_val: " + reduced_cost.ToString("C"));
                
                int creditNum;
                string card_str;
                const int DIGITS = 4;
                int firstThree;
                int lastOne;
                const int CHECK_FACTOR = 7;
                int remainder;
                int attempt = 0;
                bool accntcheck = false;
                while (accntcheck == false)
                {
                    Write("Enter Four digit credit card number ");
                    card_str = ReadLine();
                    if (card_str.Length != DIGITS)
                    {
                        WriteLine($"Card number invalid - it must have {DIGITS} digits");
                        attempt++;
                        if (attempt == 3)
                        {
                            WriteLine("Reached maximum number of attempts. Do you want to proceed with next cust? Y/N");
                            next_shopper = ReadLine();
                            if (next_shopper == "Y" || next_shopper == "y")
                            {
                                cust++;
                                accntcheck = true;
                                total_prod = 0;
                                total_purchase_cost = 0;
                            }
                            else if (next_shopper == "N" || next_shopper == "n")
                            {
                                cust = 0;
                                accntcheck = true;
                                pay = true;
                                WriteLine("Have a nice day!");
                            }
                            else
                                WriteLine("Please enter valid input");

                        }
                    }
                    else
                    {
                        creditNum = Convert.ToInt32(card_str);
                        firstThree = creditNum / 10;
                        lastOne = creditNum % 10;
                        remainder = firstThree % CHECK_FACTOR;
                        if (lastOne == remainder)
                        {
                            WriteLine("Card number is valid");
                            WriteLine("pay was successfull");
                            WriteLine("---------------------------------------------------------");
                            WriteLine("Total items purchased        : {0}",total_prod);
                            WriteLine("Total amount                 : {0}",total_purchase_cost.ToString("C"));
                            WriteLine("Discount given               : {0}%", disc);
                            WriteLine("After Discount               : {0}",(total_purchase_cost * disc / 100).ToString("C"));
                            reduced_cost = total_purchase_cost - (total_purchase_cost * disc / 100);
                            WriteLine("Total amount paid            : {0}",reduced_cost.ToString("C"));
                            WriteLine("----------------------------------------------------------");
                            WriteLine("Final amount {0} is paid with $0.0 owing", reduced_cost);
                            WriteLine("----------------------------------------------------------");
                            
                            WriteLine("Do you want to proceed with next cust? Y/N");
                            next_shopper = ReadLine();
                            if (next_shopper == "Y" || next_shopper == "y")
                            {
                                cust++;
                                accntcheck = true;
                                total_prod = 0;
                                total_purchase_cost = 0;

                            }
                            else if (next_shopper == "N" || next_shopper == "n")
                            {
                                cust = 0;
                                accntcheck = true;
                                pay = true;

                            }
                            else
                                WriteLine("Please enter valid input");
                            accntcheck = true;
                        }
                        else
                        {
                            WriteLine("Invalid entry");
                            attempt++;
                            if (attempt == 3)
                            {
                                WriteLine("pay declined! Do you want to proceed with next customer? Y/N");
                                next_shopper = ReadLine();
                                if (next_shopper == "Y" || next_shopper == "y")
                                {
                                    cust++;
                                    accntcheck = true;
                                    total_prod = 0;
                                    total_purchase_cost = 0;
                                }
                                else if (next_shopper == "N" || next_shopper == "n")
                                {
                                    cust = 0;
                                    accntcheck = true;
                                    pay = true;

                                }
                                else
                                    WriteLine("Please enter valid input");

                            }
                        }

                    }
                }
            }


            ReadKey();


        }// end of main method
    }// end of class
}// end of namespace
