using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIRST NAME
            Console.WriteLine("Tell me your first name.");
            string firstName = Console.ReadLine();

            // LAST NAME
            Console.WriteLine("Tell me your last name.");
            string lastName = Console.ReadLine();

            // AGE / RETIREMENT
            Console.WriteLine("Tell me your age.");

            string retirement;
            string age = Console.ReadLine();
            int ageNumber = Convert.ToInt32(age);

            if (ageNumber % 2 == 0)
            {
                retirement = "15 years";
            }
            else
            {
                retirement = "20 years";
            }


            // BANK BALANCE
            string bankBalance;
            string birthMonth;
            Console.WriteLine("What is the number of your birth month?");
            birthMonth = Console.ReadLine();
            int monthNumber = Convert.ToInt32(birthMonth);


            if (monthNumber <= 4)
            {
                bankBalance = "$45";
            } else if (monthNumber <= 8 && monthNumber > 4)
            {
                bankBalance = "$10,000";
            } else if (monthNumber > 8)
            {
                bankBalance = "$75,000";
            } else bankBalance = "$3.50";






            // MODE OF TRANSPORTATION
            string transportation;
            bool colorChoice = false;
            string color;
            do
            {
                Console.WriteLine("What is your favorite color? (ROYGBIV)");
                Console.WriteLine("enter \"HELP\" for a list of colors.");
                color = Console.ReadLine().ToLower();

                if (color == "help")
                {
                    Console.WriteLine("==== COLORS ====");
                    Console.WriteLine("RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET");
                }
                else if (color == "red")
                {
                    transportation = "Lamborghini";
                    colorChoice = true;
                }
                else if (color == "orange")
                {
                    transportation = "Prius";
                    colorChoice = true;

                }
                else if (color == "yellow")
                {
                    transportation = "Corvette";
                    colorChoice = true;
                }
                else if (color == "green")
                {
                    transportation = "Jeep";
                    colorChoice = true;
                }
                else if (color == "blue")
                {
                    transportation = "scooter";
                    colorChoice = true;
                }
                else if (color == "indigo")
                {
                    transportation = "lawn mower";
                    colorChoice = true;
                }
                else if (color == "violet")
                {
                    transportation = "school bus";
                    colorChoice = true;
                }
            } while (colorChoice == false);
        


                // VACATION HOME LOCATION
                Console.WriteLine("How many siblings do you have?");

                string siblings = Console.ReadLine();
                int siblingCount = Convert.ToInt32(siblings);
                string vacationHome;

                if (siblingCount == 0)
                {
                    vacationHome = "Rockport";
                }
                else if (siblingCount == 1)
                {
                    vacationHome = "Italy";
                }
                else if (siblingCount == 2)
                {
                    vacationHome = "Los Angeles";
                }
                else if (siblingCount == 3)
                {
                    vacationHome = "Hawaii";
                }
                else if (siblingCount > 3)
                {
                    vacationHome = "Toronto";
                }
                else if (siblingCount < 0)
                {
                    vacationHome = "Cleveland";
                }
            Console.WriteLine("Are you ready to hear your fortune?");
            Console.ReadLine();


            }
        }
    }
