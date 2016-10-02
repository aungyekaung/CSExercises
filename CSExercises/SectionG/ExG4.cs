using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            string[] name = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = { 63, 29, 75, 82, 55 };

            PrintArray(name, marks);
            Console.WriteLine();
            FirstReport(name, marks);
            Console.WriteLine();
            SecondReport(name, marks);

        }

        public static void PrintArray (string[] name, int[] marks)
        {
            for (int i = 0; i< name.Length; i++)
            {
                Console.Write(name[i] + "\t");
            }
            Console.WriteLine();
            for (int j = 0; j< marks.Length; j++)
            {
                Console.Write(marks[j] + "\t");
            }
            Console.WriteLine();
        }

        public static void FirstReport (string[] name, int[] marks)
        {
            Console.WriteLine("Dan tan tan... First Report Desu... Dan tan tan");

            for (int i = 0; i<marks.Length; i++)
            {
                for (int j=0; j<marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int temp = marks[i];
                        string tempname = name[i];
                        marks[i] = marks[j];
                        name[i] = name[j];
                        marks[j] = temp;
                        name[j] = tempname;
                    }
                }
            }

            PrintArray(name, marks);
        }

        public static void SecondReport(string[] name, int[] marks)
        {
            Console.WriteLine("Dan tan tan.... Second Report Desu ... Dan tan tan");

            for (int i =0; i<name.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[i].CompareTo(name[j])==-1)
                    {
                        string nametemp = name[i];
                        int tempmark = marks[i];
                        name[i] = name[j];
                        marks[i] = marks[j];
                        marks[j] = tempmark;
                        name[j] = nametemp;
                    }
                }
            }

            PrintArray(name, marks);
        }
    }
}
