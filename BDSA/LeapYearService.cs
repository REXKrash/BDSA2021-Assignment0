using System;

namespace Prime.Services
{
    public class LeapYearService
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter a year:");
            string value = Console.ReadLine();

            var leapYearService = new LeapYearService();
            try
            {
                Int32 number = Convert.ToInt32(value);
                bool isItLeapYear = leapYearService.IsLeapYear(number);
                if (number >= 1582)
                {
                    if (isItLeapYear)
                    {
                        Console.WriteLine("yay");
                    }
                    else
                    {
                        Console.WriteLine("nay");
                    }
                }
                else
                {
                    Console.WriteLine("Please insert a number higher or equal to 1582!");
                }
            }
            catch (FormatException _)
            {
                Console.WriteLine("This only work for numbers!");
            }
        }

        public bool IsLeapYear(int year)
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }
}