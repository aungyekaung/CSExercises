﻿using System;

namespace CSExercises
{

    //Modify the Prime Number C# program to print out all 
    //the prime numbers from 5 to 10000.


    public class ExE5
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            //Hint: you can call ExE3.IsPrime method (from previous exercise) 
            //to check whether a number is a prime or not.
            int count = 0;
            for (int i = 5; i <= 10000; i++)
            {
                if(ExE3.IsPrime(i))
               {
                   count++;
                    Console.WriteLine(i + " " + count);
                }
            }

        }
    }

}

