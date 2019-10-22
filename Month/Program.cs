using System;

namespace Month
{
    public static class Program
    {
        public static void Main()
        {
            string monthName = string.Empty;

            Console.Write("Enter the number of the month: ");
            string monthNumber = Console.ReadLine();

            if (monthNumber == "1")
            {
                monthName = "January";
            }

             else if (monthNumber == "2")
            {
                monthName = "February";
            }

            else if (monthNumber == "3")
            {
                monthName ="March";
            }

            else if (monthNumber == "4")
            {
                monthName = "April";
            }

            else if (monthNumber == "5")
            {
                monthName = "May";
            }

            else if(monthNumber == "6")
            {
                monthName = "June";
            }
            else if(monthNumber == "7")
            {
                monthName = "July";
            }

            else if (monthNumber == "8")
            {
                monthName = "August";
            }

            else if (monthNumber == "9")
            {
                monthName = "September";
            }

            else if (monthNumber == "10")
            {
                monthName = "October";
            }

            else if(monthNumber == "11")
            {
                monthName = "November";
            }

            else if(monthNumber == "12")
            {
                monthName = "December";
            }

            else
            {
                monthName = "That Month does not exist";
            }
            // Save the input to a variable.

            // Use the if statment to update the monthName variable based on the user's input.
           


            Console.WriteLine($"The name of the month you entered is {monthName}");

            Console.ReadLine();
        }
    }
}
