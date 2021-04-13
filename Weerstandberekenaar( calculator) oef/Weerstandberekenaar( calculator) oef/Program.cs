using System;

namespace Weerstandberekenaar__calculator__oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resistance calculator");

            int x;
            Console.WriteLine("What is the 1st value?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("The Ring1 is:" + (x * 10));

            int y;
            Console.WriteLine("What is the 2nd value?");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("The Ring2 is:" + ((x * 10) + y));






        }
    }
}
