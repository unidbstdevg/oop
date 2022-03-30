using System;

class Program
{
    public delegate double FuncD(double x);
    public static double Integral(FuncD f, double a, double b, int n=1000) {
        if(b <= a)
            return 0;
        if(n == 0)
            throw new ApplicationException("Div by zero. Die");

        double d = (b - a) / n;
        double sum = 0;
        for(double x = a; x < b; x += d) {
            sum += d * (f(x) + f(x+d)) / 2;
        }

        return sum;
    }

    public static double F1(double x) {
        return x * x;
    }

    static void Main(string[] args)
    {
        double a = 1;
        double b = 3;

        double inta = Integral(F1, a, b);

        Console.WriteLine(String.Format("Integral of {0} on [{1}, {2}] = {3}", "F1", a, b, inta));
        Console.WriteLine(String.Format("Integral of {0} on [{1}, {2}] = {3}", "sin", a, b, Integral(Math.Sin, 0, Math.PI)));
        Console.WriteLine(String.Format("Integral of {0} on [{1}, {2}] = {3}", "x^2", a, b, Integral(delegate (double x) {return x * x;}, 1, 3)));
        Console.WriteLine(String.Format("Integral of {0} on [{1}, {2}] = {3}", "x^2 + 2", a, b, Integral(x => x*x + 2, 0, 3)));
    }
}
