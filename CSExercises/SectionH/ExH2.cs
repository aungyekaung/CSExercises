using System;
namespace CSExercises
{
    public class ExH2
    {
        Write a static method: FindWord(string s1, string s2) that would return an integer.  
        The method should find if the string s2 occurs in s1 and return an integer that would 
        indicate the starting position of the word s2 in s1.  If the word does not occur 
        the return value should be –1.

        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Emter S1:");
                string s1 = Console.ReadLine();

                Console.WriteLine("Enter S2:");
                string s2 = Console.ReadLine();

                Console.WriteLine("Output is" + FindWord(s1, s2));
            }
        }
        public static int FindWord(string s1, string s2)
        {
            string s3 = ModifyString(s1);
            string s4 = ModifyString(s2);
            string indexer = "";
            bool result = false;
            int position = 0;
            Console.WriteLine(s1 + s2);

            for (int i = 0; i < s3.Length; i++)
            {
                if (s4.Substring(0, 1) == s3.Substring(i, 1))
                {

                    if (s4 == s3.Substring(i, s4.Length))
                    {
                        result = true;
                        indexer = 
                        break;
                    }
                }
                else
                {
                    result = false;
                }
            }

            if (result == true)
            {
                position = IdentifyStringIndex(s1, indexer);
            }

            return position;

        }

        public static int IdentifyStringIndex(string s2, string indexer)
        {
            int position = 0;

            for (int i = 0; i < s2.Length; i++ )
            {
                if (s2.Substring(i, indexer.Length) == indexer)
                {
                    position = i;
                    break;
                }
            }
            return position; 
        }

        public static string ModifyString(string phrase)
        {
            string[] punc = { ".", ",", "'", ";", ":", "!", "@", "\"" };
            phrase = phrase.ToLower();

            for (int k = 0; k < punc.Length; k++)
            {
                phrase = phrase.Replace(punc[k], string.Empty);
            }

            return phrase;
        }
    }
}
