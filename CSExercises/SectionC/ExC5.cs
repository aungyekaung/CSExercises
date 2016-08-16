using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string input;
            int result;
            bool output;
            bool intCheck = true;

            Console.WriteLine("Please input a 3 digit Number:");
            input = Console.ReadLine();

            intCheck = Int32.TryParse(input, out result);

            while (intCheck = false || input.Length != 3)
            {
                Console.WriteLine("Error: Enter a 3 digit number:");
                input = Console.ReadLine();
                intCheck = Int32.TryParse(input, out result);

            }


            output = IsArmstrongNumber(Convert.ToInt32(input));

            Console.WriteLine(output);

        }


        public static bool IsArmstrongNumber(int n)
        {
            //YOUR CODE HERE
            int a, b, c;
            int tot;

            a = n / 100;
            b = n % 100 / 10;
            c = n % 10;

            tot = Convert.ToInt32(Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));

            if (tot == n)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}