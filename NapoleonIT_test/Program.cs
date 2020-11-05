using System;

namespace NapoleonIT_test
{
    class Program
    {
        private readonly string[] Sentence_Addon = new string[2];
        private string Parse(ref Program instance)
        {
            int first_opening = instance.Sentence_Addon[0].IndexOf('[');
            int[] brackets = new int[2];
            foreach (char c in instance.Sentence_Addon[0]) if (c == '[') brackets[0]++; else if (c == ']') brackets[1]++;
            if (brackets[0] != brackets[1] || first_opening > instance.Sentence_Addon[0].IndexOf(']') || brackets[0] == 0)
            { 
                Console.WriteLine("You've totally messed up with those brackets!"); 
                return instance.Sentence_Addon[0];
            }
            int counter = 0;
            int related_closing = 0;
            for (int i = first_opening + 1; i < Sentence_Addon[0].Length; i++)
            { 
                if (Sentence_Addon[0][i] == '[') counter++; 
                else if (Sentence_Addon[0][i] == ']') counter--; 
                if (counter < 0) 
                { 
                    related_closing = i; 
                    break; 
                } 
            }
            return instance.Sentence_Addon[0].Substring(0, first_opening) + instance.Sentence_Addon[1] + instance.Sentence_Addon[0].Substring(related_closing + 1, Sentence_Addon[0].Length - related_closing - 1);
        }
        private static void Main(string[] args)
        {
            Program instance = new Program();
            Console.WriteLine("World Up!\x0AGimme ur sentence!");
            instance.Sentence_Addon[0] = Console.ReadLine();
            Console.WriteLine("Now feed me with a substring ^_^");
            instance.Sentence_Addon[1] = Console.ReadLine();
            Console.WriteLine(instance.Parse(ref instance));
        }
    }
}
