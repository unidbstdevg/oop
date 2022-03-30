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
                a.Print();
                a[10, 10] = 3;
                Console.WriteLine("Lmao u'll never see this tExt. shit!");
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
