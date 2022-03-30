using System;

namespace sam_rab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(3, 5, 4);
            Vector b = new Vector(1, 4, 2);
            double k = 2;

            Console.WriteLine("Vecotr a = " + a);
            Console.WriteLine("Vecotr b = " + b);
            Console.WriteLine("double k = " + k);
            Console.WriteLine();

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a & b = " + (a & b));
            Console.WriteLine();

            Console.WriteLine("a * k = " + (a * k));
            Console.WriteLine("k * a = " + (k * a));
            Console.WriteLine();

            Console.WriteLine("-a = " + (-a));
            Console.WriteLine();

            Console.WriteLine("abs(a) = " + a.Abs());
            Console.WriteLine("abs(b) = " + b.Abs());
            Console.WriteLine();

            Console.WriteLine("a == b? " + (a == b));
            Console.WriteLine("a != b? " + (a != b));
            Console.WriteLine("a > b? " + (a > b));
            Console.WriteLine("a < b? " + (a < b));
            Console.WriteLine("a >= b? " + (a >= b));
            Console.WriteLine("a <= b? " + (a <= b));
        }
    }
}
