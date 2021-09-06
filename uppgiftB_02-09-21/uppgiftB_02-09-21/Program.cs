using System;

namespace uppgiftB_02_09_21
{
    class Program
    {
        static string ReverseString(string s)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en palindom! ");
            string palindrom = Console.ReadLine();
            Console.WriteLine(ReverseString(palindrom));

        }
    }
}
