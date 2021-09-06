using System;

namespace UppgiftB_03_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string citat = Console.ReadLine();
            char[] separators = new char[] { ' ', '.' };

            string[] subs = string.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sub in subs)
            {
                Console.Write($"substring: {sub}");
            }

        }


    }
    
}
