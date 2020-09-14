using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Create an application that reads a bunch of non-negative integers line-by-line until a negative integer or the end-of-line (CTRL-Z) has reached. 
    /// The app will print out the sum of all the fillers that will make all the values entered so far will appear in increasing order, 
    /// where each value is larger than the previous number. That is each filler is added to each input, such that the numbers will all appear in increasing order (e.g. 1, 2, 3, 10). 
    /// The only exception is when the element is 0, where the current number and the subsequent numbers will restart from zero.
    /// </summary>
    /// <param name="a"></param>
    /// <remarks>In essence, this app will calculate the sum of all these values added to the original numbers such that our projected numbers will appear in increasing order.</remarks>
    /// <returns>The sum of all the fillers</returns>
    public class AscendingFillers
    {
        public static void Main()
        {
            // Complete your loop codes here.

            
            int sum = 0;
            int counter = 0;
            string input;

            do
            {
                Console.WriteLine("Please Enter positive integers or type Q to quit");
                input = Console.ReadLine();

                if (!input.ToUpper().Equals("Q"))
                {
                    int n = 0;

                    if (int.TryParse(input, out n))
                    {

                        if (n > 0)
                        {
                            sum = + n;

                            counter++;
                        }
                        else

                            Console.WriteLine("Please Enter Valid positive integers or type Q to quit");


                    }

                }
                else
                    Console.WriteLine("Please Enter Valid positive integers or type Q to quit");

            }

            while (!input.ToUpper().Equals("Q"));

            {
                Console.WriteLine($"{sum} , ");

            }



              
            
            

            
        }
    }
}
