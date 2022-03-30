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

            Console.WriteLine("\nNormalize demonstration:");
            Frac f_norm = new Frac(64, 1024);
            Console.WriteLine("64/1024 = " + f_norm);

            Console.WriteLine("\nToString demonstration:");
            Frac fa = new Frac(1, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(6, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(3, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);

            fa = new Frac(-1, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(-6, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
            fa = new Frac(-3, 2);
            Console.WriteLine(fa.Chisl + "/" + fa.Znam + " = " + fa);
        }
    }
}
