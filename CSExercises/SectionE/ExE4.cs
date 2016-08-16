﻿using System;

namespace CSExercises
{
    //Given an integer as input write a C# program to determine 
    //whether the number is a Perfect Number or not.

    //A perfect number is one for which the sum of its factors
    //    (including number one) add up to the number itself.For example 
    //        number six is a perfect number because,
    //		6 = 1 + 2 + 3.


    public class ExE4
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());


            if (IsPerfectNumber(n))
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }

        public static bool IsPerfectNumber(int n)
        {
            //YOUR CODE HERE
            int temp = 1;
            int total = 0;

            for (int k=1; k<n; k++)
            {
                double remainder = n % k;
                if (remainder == 0)
                {
                    temp = k;
                }
                else
                {
                    temp = 0;
                }
                total = total + temp;
            }

            if (total == n)
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
