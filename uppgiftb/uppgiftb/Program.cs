using System;

namespace uppgiftb
{
    class Program
    {
        static void Main(string[] args)
        {

            string citat = Console.ReadLine();
            char[] separators = new char[] { ' ', '.' };

            string[] subs = citat.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            int x = 0;
            foreach (var sub in subs)
            {
                Console.WriteLine(sub);
                x++;
            }
            Console.WriteLine("det finns: " + x + " ord i denna citat");
        }
    }
}
