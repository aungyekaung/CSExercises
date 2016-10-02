using System;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {
            //YOUR CODE HERE
            string[] temparr = phrase.Split(' ');
            
            string result = "";

            for (int i = 0; i < temparr.Length; i++ )
            {
                string temp2 = temparr[i].Substring(0, 1).ToUpper();
                //temparr[i] = temparr[i].Remove(0, 1).Insert(0, temp2);
                temparr[i] = temp2 + temparr[i].Substring(1, temparr[i].Length - 1) + " ";
                result = result + temparr[i];
            }

                return result;


        }
    }
}
