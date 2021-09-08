using System;

namespace BDSA21
{
    public class Program
    {
        private bool isLeapYear; 

        bool IsLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                isLeapYear = true;
                if(year % 100 == 0)
                {
                    isLeapYear = false;
                    if(year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
            }
            
            return isLeapYear;
        }

        

        static void Main(string[] args)
        {
            Program program = new Program();
            

            Console.Writeline(program.calculateLeapYear(1800));
            Console.Writeline(program.calculateLeapYear(1900));
            Console.Writeline(program.calculateLeapYear(1600));
            Console.Writeline(program.calculateLeapYear(2004));

            
        }
    }
}


