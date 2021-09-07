using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
            IsLeapYear(Int32.Parse(Console.ReadLine()));
        }

        public static bool IsLeapYear(int year)
        {
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
