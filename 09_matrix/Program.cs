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

                Console.WriteLine("\nMatrix transposed a:");
                MyMatrix a_transposed = a.Transpose();
                a_transposed.Print();

                Console.WriteLine("\nMatrix a * a_transposed:");
                MyMatrix a_a_transp = a * a_transposed;
                a_a_transp.Print();


                Console.WriteLine("\nSquare matrix d:");
                MyMatrix d = new MyMatrix(3, 3);
                d[0, 0] = 5;
                d[1, 1] = 9;
                d[1, 2] = 1;
                d[0, 2] = 7;
                d[2, 0] = 1;
                d.Print();

                double d_determ = d.Determinant();
                Console.WriteLine("\nDeterminant of d: " + d_determ);

                MyMatrix d_inv = d.Inverse();
                Console.WriteLine("\nInverse of d:");
                d_inv.Print();
                Console.WriteLine("\nTest: d * d^-1:");
                (d * d_inv).Print();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
