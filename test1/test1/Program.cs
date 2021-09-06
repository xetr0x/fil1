using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("välj typen a eller b ");
            string val = Console.ReadLine();
            if (val == "a")
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("hej " + name + "!");
            }

            else
            {
                Console.Write("Vad är ditt förnamn ");
                string förnamn = Console.ReadLine();
                Console.Write(" Vad är ditt efternamn? ");
                string efternamn = Console.ReadLine();
                Console.Write("Hej " + förnamn + " " + efternamn);
            }


        }
    }
}