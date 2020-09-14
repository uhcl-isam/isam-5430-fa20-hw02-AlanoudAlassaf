using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            // Codes to enter start
            string input;
            int number1;
            input= Console.ReadLine();
            number1 = Convert.ToInt32(input);

            
            Console.Error.WriteLine("Enter the ending number");
            // Codes to enter end.
        
            int number2;
            input = Console.ReadLine();
            number2 = Convert.ToInt32(input);

            
            
            while( number1 <= number2)

            {
                if (number1 % 2 !=0)
                {
                    Console.WriteLine(number1);
                }

                number1++;
            }
           
        }
    }
}
