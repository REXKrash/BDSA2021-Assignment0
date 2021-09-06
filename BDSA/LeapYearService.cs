using System;

namespace Prime.Services
{
    public class LeapYearService
    {
        public static void Main(string[] args) {
            string value = Console.ReadLine();

            var leapYearService = new LeapYearService();
            bool isItLeapYear = leapYearService.IsLeapYear(Convert.ToInt32(value));

            if (isItLeapYear) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }

        public bool IsLeapYear(int year)
        {
            return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
        }
    }
}