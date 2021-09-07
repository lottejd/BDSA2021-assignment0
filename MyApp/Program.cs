using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var input = Console.ReadLine();
            try
            {
                var year = Int32.Parse(input);
                IsLeapYear(year);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Input should be a number!");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if(year < 1582)
            {
                Console.WriteLine("nay");
                return false;
            }
            if(year % 4 == 0)
            {
                if(year % 100 != 0 || year % 400 == 0) 
                {
                    Console.WriteLine("yay");
                    return true;
                }
                else
                {
                    Console.WriteLine("nay");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("nay");
                return false;
            }
        }
    }
}
