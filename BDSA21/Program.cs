using System;

namespace BDSA21
{
    public class Program
    {
        private bool isLeapYear; 

        public bool IsLeapYear(int year)
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

        public void calculateLeapYear(int year)
        {      
            if(IsLeapYear(year))
            {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }

        int checkException(int input)
        {
            try
            {
                input = int.Parse(Console.ReadLine());

                if(input < 1582)
                {
                    throw new System.FormatException();
                }

                return input;

            } catch (FormatException) {
                Console.WriteLine("Year must be an integer larger than 1582, try again.", input);
                
                checkException(input);

                return input;
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            int input = 0;

            program.calculateLeapYear(program.checkException(input));

            
        }
    }
}


