using System;
using System.Threading;

namespace AppveyorConsoleTest
{
    class Program
    {
        private static string Name => "Test Name";

        static void Main(string[] args)
        {
            const int i = 100;
            Console.WriteLine($"Done {i} {Name}");
        }
    }
}
