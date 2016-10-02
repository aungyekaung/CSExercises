using System;

namespace CSExercises
{
    public class ExH1
    {
        static void Main (string[] args)
        {
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine("Emter S1:");
                string s1 = Console.ReadLine();

                Console.WriteLine("Enter S2:");
                string s2 = Console.ReadLine();

                Console.WriteLine("Output is" + InString(s1, s2));
            }
        }
        public static bool InString(string s1, string s2)
        {
            s1 = ModifyString(s1);
            s2 = ModifyString(s2);
            int count = 0;
            Console.WriteLine(s1 + s2);
            bool result = false;

            for (int i = 0; i < s1.Length; i++ )
            {
                if (s2.Substring(0,1) == s1.Substring(i,1))
                {
                    if (s2 == s1.Substring(i,s2.Length))
                    {
                        result = true;
                        break;
                    }
                }
                else
                {
                    result = false;
                }
            }

            return result;
            
        }

        public static string ModifyString(string phrase)
        {
            string[] punc = { " ", ".", ",", "'", ";", ":", "!", "@", "\"" };
            phrase = phrase.ToLower();

            for (int k = 0; k < punc.Length; k++)
            {
                phrase = phrase.Replace(punc[k], string.Empty);
            }

            return phrase;
        }
    }
}
