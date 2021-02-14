using System;

namespace Day4_Hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> personeller = new MyDictionary<int, string>();

            personeller.Add(1, "Enver");

            Console.WriteLine(personeller.Length);
        }
    }
}
