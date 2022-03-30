using System;

namespace _07_frac
{
    class Program
    {
        static void Main(string[] args)
        {
            Frac fr;

            Frac f1 = new Frac(1, 2);
            Frac f2 = new Frac(3, 4);
            int k = 3;

            fr = f1 * f2;
            Console.WriteLine("f1 * f2 = " + f1 + " * " + f2 + " = " + fr);
            fr = f1 * k;
            Console.WriteLine("f1 * k = " + f1 + " * " + k + " = " + fr);
            fr = k * f1;
            Console.WriteLine("k * f1 = " + k + " * " + f1 + " = " + fr);

            fr = f1 + f2;
            Console.WriteLine("f1 + f2 = " + f1 + " + " + f2 + " = " + fr);
            fr = f1 + k;
            Console.WriteLine("f1 + k = " + f1 + " + " + k + " = " + fr);
            fr = k + f1;
            Console.WriteLine("k + f1 = " + k + " + " + f1 + " = " + fr);

            fr = f1 - f2;
            Console.WriteLine("f1 - f2 = " + f1 + " - " + f2 + " = " + fr);
            fr = f1 - k;
            Console.WriteLine("f1 - k = " + f1 + " - " + k + " = " + fr);
            fr = k - f1;
            Console.WriteLine("k - f1 = " + k + " - " + f1 + " = " + fr);

            fr = f1 / f2;
            Console.WriteLine("f1 / f2 = " + f1 + " / " + f2 + " = " + fr);
            fr = f1 / k;
            Console.WriteLine("f1 / k = " + f1 + " / " + k + " = " + fr);
            fr = k / f1;
            Console.WriteLine("k / f1 = " + k + " / " + f1 + " = " + fr);

            Console.WriteLine("f1 > f2? => " + f1 + " > " + f2 + "? => " + (f1 > f2));
            Console.WriteLine("f1 >= f2? => " + f1 + " >= " + f2 + "? => " + (f1 >= f2));
            
            Console.WriteLine("f1 < f2? => " + f1 + " < " + f2 + "? => " + (f1 < f2));
            Console.WriteLine("f1 <= f2? => " + f1 + " <= " + f2 + "? => " + (f1 <= f2));
            
            Console.WriteLine("f1 == f2? => " + f1 + " == " + f2 + "? => " + (f1 == f2));
            Console.WriteLine("f1 != f2? => " + f1 + " != " + f2 + "? => " + (f1 != f2));
        }
    }
}
