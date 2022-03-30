using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_matrix
{
    class MyMatrix
    {
        private double[,] m;
        private int n, k;

        public double this [int i, int j] {
            get {
                if(i < 0 || j < 0 || i >= n || j >= k) {
                    throw new ApplicationException("Выход за границы матрицы");
                }
                return m[i, j];
            }
            set {
                if(i < 0 || j < 0 || i >= n || j >= k) {
                    throw new ApplicationException("Выход за границы матрицы");
                }
                m[i, j] = value;
            }
        }

        public MyMatrix() {
            n = k = 1;
            m = new double[n, k];
        }

        public MyMatrix(int nn, int kk) {
            if(nn == 0 || kk == 0) {
                throw new ApplicationException("Размерность матрицы не может быть равна 0");
            }

            n = nn;
            k = kk;
            m = new double[n, k];
        }

        public int N {
            get {
                return n;
            }
        }
        public int K {
            get {
                return k;
            }
        }

        public void Print() {
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < k; j++) {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static MyMatrix operator +(MyMatrix a, MyMatrix b)
        {
            if(a.n != b.n || a.k != b.k) {
                throw new ApplicationException("Matrix is not equivalent");
            }

            MyMatrix rm = new MyMatrix(a.n, a.k);

            for(int i = 0; i < a.n; i++)
                for(int j = 0; j < a.k; j++)
                    rm[i,j] = a[i,j] + b[i,j];

            return rm;
        }
        public static MyMatrix operator *(MyMatrix a, int k)
        {
            MyMatrix rm = new MyMatrix(a.n, a.k);

            for(int i = 0; i < a.n; i++)
                for(int j = 0; j < a.k; j++)
                    rm[i,j] = a[i,j] * k;

            return rm;
        }
    }
}
