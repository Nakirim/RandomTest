using System;
using System.IO;

namespace SoftwareTest
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            StreamWriter writer = new StreamWriter("C:\\Users\\Nakirim\\Desktop\\out.txt");

            Console.SetOut(writer);
            Act();


            StreamReader reader = new StreamReader("C:\\Users\\Nakirim\\Desktop\\out.txt");

            Console.SetIn(reader);
            X();

        }

        static void Act()
        {
            Console.WriteLine("This is Console.Writeline");
            Console.WriteLine("Tanks for playing");
        }

        static void X()
        {
            string line = Console.ReadLine();
            Console.WriteLine("READLINE RETURNED: " + line);
        }
    }
}
