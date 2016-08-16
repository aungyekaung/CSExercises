using System;

namespace CSExercises
{
    public class ExE3
    {
        //Given an integer as input determine whether the number 
        //is a prime number or not.  Your program should output “Prime” 
        //    or “Not Prime” as the case may be.

        //A Prime Number is one which is only divisible by one and itself.

        //Consider how the efficiency of the program can be improved. 
        //Normally the order of complexity is proportional to the number of 
        //    times a loop is executed.A more formal definition of 
        //    “Analysis of Algorithms” will be dealt in a later course.

        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


          bool status = IsPrime(n);


            Console.WriteLine(status);
        }

        public static bool IsPrime(int n)
        {
            bool IsPrimeStatus = true;
            for (int k = 2; k < n; k++)
            {
                double remainder = n % k;
                if (remainder != 0)
                {
                     IsPrimeStatus = true;
                } 
                else
                {
                     IsPrimeStatus = false;
                     k = n;
                }

            }


            return IsPrimeStatus;
        }
    }
}
