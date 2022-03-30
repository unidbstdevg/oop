using System;

namespace _09_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyMatrix a = new MyMatrix(2, 3);
                a[0, 0] = 5;
                a[1, 1] = 9;
                MyMatrix b = new MyMatrix(2, 3);
                b[0, 1] = 2;
                b[1, 1] = 3;
                MyMatrix c;

                Console.WriteLine("Matrix a:");
                a.Print();

                Console.WriteLine("\nMatrix b:");
                b.Print();

                Console.WriteLine("\nMatrix a+b:");
                c = a + b;
                c.Print();

                Console.WriteLine("\nMatrix a-b:");
                c = a - b;
                c.Print();

                Console.WriteLine("\nMatrix a*2:");
                c = a * 2;
                c.Print();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
