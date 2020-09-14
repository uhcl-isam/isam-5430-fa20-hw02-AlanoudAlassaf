using System;
using System.Reflection.Metadata;

namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// A palindrome is a sequence of characters that reads the same backward
    /// as forward. For example, each of the following five-digit integers
    /// is a palindrome: 12321, 55555, 45554 and 11611. 
    /// Write an app that reads in exactly 9-digit positive integers 
    /// and determines whether it’s a palindrome (display either:
    /// "a palindrome" or "not a palindrome"). If the number is not 
    /// nine digits long, display an error message and allow the user to
    /// enter a new value. </summary>
    /// <remark>[Hint: Use the remainder and division operators to pick off
    /// the number’s digits one at a time, from right to left.]</remark>
    /// 
    public class IntegerPalindromes
    {
        public static void Main()
        {
            // enter sentinel inputs
            // then check the palindrome only once.




            int reminder = 0;
            int reverse = 0;
            int number = 0;
            int backup;


            do

            {

                Console.WriteLine("Enter 9 positive inetgers");
                number = int.Parse(Console.ReadLine());

                if (number.ToString().Length == 9)
                {

                    backup = number;




                    while (backup > 0)

                    {
                        reminder = backup % 10;
                        reverse = reverse * 10 + reminder;
                        backup /= 10;

                    }


                    if (number == reverse)


                        Console.WriteLine($"{backup} is palindrome number");


                    else

                        Console.WriteLine($"{backup} is not palindrome number");


                }
                else
                    Console.WriteLine("The number is Not 9 digit, enter correct number ");



            }

            while (number.ToString().Length != 9);
        }


        




    }
}
