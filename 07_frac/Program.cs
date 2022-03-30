using System;

namespace _07_frac
{
    class Program
    {
        static void Main(string[] args) {
            DemoPrint();
        }

        static void DemoPrint()
        {
            Frac fr;

            Frac f1 = new Frac(1, 2);
            Frac f2 = new Frac(3, 4);
            int k = 3;

            Console.WriteLine("Multiplication:");
            fr = f1 * f2;
            Console.WriteLine("f1 * f2 = " + f1 + " * " + f2 + " = " + fr);
            fr = f1 * k;
            Console.WriteLine("f1 * k = " + f1 + " * " + k + " = " + fr);
            fr = k * f1;
            Console.WriteLine("k * f1 = " + k + " * " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Sum:");
            fr = f1 + f2;
            Console.WriteLine("f1 + f2 = " + f1 + " + " + f2 + " = " + fr);
            fr = f1 + k;
            Console.WriteLine("f1 + k = " + f1 + " + " + k + " = " + fr);
            fr = k + f1;
            Console.WriteLine("k + f1 = " + k + " + " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Difference:");
            fr = f1 - f2;
            Console.WriteLine("f1 - f2 = " + f1 + " - " + f2 + " = " + fr);
            fr = f1 - k;
            Console.WriteLine("f1 - k = " + f1 + " - " + k + " = " + fr);
            fr = k - f1;
            Console.WriteLine("k - f1 = " + k + " - " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Div:");
            fr = f1 / f2;
            Console.WriteLine("f1 / f2 = " + f1 + " / " + f2 + " = " + fr);
            fr = f1 / k;
            Console.WriteLine("f1 / k = " + f1 + " / " + k + " = " + fr);
            fr = k / f1;
            Console.WriteLine("k / f1 = " + k + " / " + f1 + " = " + fr);
            Console.WriteLine();

            Console.WriteLine("Comparisons:");
            Console.WriteLine("f1 > f2? \n\t" + f1 + " > " + f2 + "? \n\t" + (f1 > f2));
            Console.WriteLine("f1 >= f2? \n\t" + f1 + " >= " + f2 + "? \n\t" + (f1 >= f2));

            Console.WriteLine("f1 < f2? \n\t" + f1 + " < " + f2 + "? \n\t" + (f1 < f2));
            Console.WriteLine("f1 <= f2? \n\t" + f1 + " <= " + f2 + "? \n\t" + (f1 <= f2));

            Console.WriteLine("f1 == f2? \n\t" + f1 + " == " + f2 + "? \n\t" + (f1 == f2));
            Console.WriteLine("f1 != f2? \n\t" + f1 + " != " + f2 + "? \n\t" + (f1 != f2));
            Console.WriteLine();

            Console.WriteLine("Normalize:");
            Frac f_norm = new Frac(64, 1024);
            Console.WriteLine("64/1024 = " + f_norm);
            Console.WriteLine();

            Console.WriteLine("ToString:");
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
