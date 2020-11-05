using System;
using System.Linq;

namespace NapoleonIT_Test3
{
    class Program
    {
        int[] numbers = new int[] { };
        static void Main()
        {
            Program instance = new Program();
            Console.WriteLine("World up!");
            string input = Console.ReadLine();
            instance.numbers = Array.ConvertAll(input.Split(','), s => int.Parse(s));
            int[] EvenNumber = new int[] { };
            int[] OddNumber = new int[] { };
            if (instance.numbers.Length > 1)
            {
                instance.Sort(ref instance, 0, instance.numbers.Length - 1);
                EvenNumber = instance.numbers.Where((x, i) => i % 2 != 0).ToArray();
                OddNumber = instance.numbers.Where((x, i) => i % 2 == 0).ToArray();
            }
            for (int i = 0; i < EvenNumber.Length; i++) instance.numbers[i] = EvenNumber[i];
            for (int i = 0; i < OddNumber.Length; i++) instance.numbers[instance.numbers.Length - 1 - i] = OddNumber[i];
            foreach (int i in instance.numbers) Console.WriteLine(i);
        }
        void Sort(ref Program instance, int LeftMargin, int RightMargin)
        {
            if (LeftMargin < RightMargin)
            {
                int Med = LeftMargin;
                for (int i = LeftMargin; i < RightMargin; ++i)
                if (instance.numbers[i] <= instance.numbers[RightMargin])
                {
                    Swap(ref instance, i, Med);
                    Med++;
                }
                Swap(ref instance, Med, RightMargin);
                Sort(ref instance, LeftMargin, Med - 1);
                Sort(ref instance, Med + 1, RightMargin);
            }
        }
        void Swap(ref Program instance, int pos1, int pos2)
        {
            if (pos1 != pos2)
            {
                int temp1 = instance.numbers[pos1];
                int temp2 = instance.numbers[pos2];
                instance.numbers[pos1] = temp2;
                instance.numbers[pos2] = temp1;
            }
        }
    }
}
