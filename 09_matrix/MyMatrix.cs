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
        // n - rows
        // k - columns

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

        public static MyMatrix operator -(MyMatrix a, MyMatrix b)
        {
            MyMatrix rm = a + (b * -1);

            return rm;
        }

        public static MyMatrix operator *(MyMatrix a, MyMatrix b) {
            if(a.k != b.n)
            {
                throw new ApplicationException("Для перемножения матрицы A на B количество столбцов матрицы A должно быть равно количеству строк матрицы B");
            }
            int obshhee_kolvo = a.k;

            MyMatrix rm = new MyMatrix(a.n, b.k);

            for(int i = 0; i < a.n; i++)
            {
                for(int j = 0; j < b.k; j++)
                {
                    double sm = 0;
                    for (int t = 0; t < obshhee_kolvo; t++)
                        sm += a[i, t] * b[t, j];

                    rm[i,j] = sm;
                }
            }

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

        public MyMatrix Transpose() {
            MyMatrix rm = new MyMatrix(k, n);

            for(int j = 0; j < n; j++)
                for (int i = 0; i < k; i++)
                    rm[i, j] = m[j, i];

            return rm;
        }

        private MyMatrix GetMinor(int row, int column)
        {
            if (n != k)
                throw new ApplicationException("Матрица не квадратная");

            MyMatrix rm = new MyMatrix(n - 1, n - 1);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < k; j++)
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column)
                            rm[i - 1, j] = m[i, j];
                        if (i < row && j > column)
                            rm[i, j - 1] = m[i, j];
                        if (i > row && j > column)
                            rm[i - 1, j - 1] = m[i,j];
                        if (i < row && j < column)
                            rm[i, j] = m[i, j];
                    }

            return rm;
        }
        public double Determinant()
        {
            // https://www.cyberforum.ru/csharp-beginners/thread915016.html
            if (n != k)
                throw new ApplicationException("Матрица не квадратная");

            double det = 0;

            int rank = n;

            if (rank == 1)
                det = m[0, 0];
            else if (rank == 2)
                det = m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
            else
                for (int j = 0; j < k; j++)
                    det += Math.Pow(-1, j) * m[0, j] * this.GetMinor(0, j).Determinant();

            return det;
        }

        public MyMatrix Inverse() {
            MyMatrix obr = new MyMatrix(n, k);

            double mxDet = this.Determinant();
            if(mxDet == 0) {
                throw new ApplicationException("Определитель равен нулю. Обратной матрицы не существует");
            }

            double result;
            for (int z = 0; z < n; z++)
            {
                for (int q = 0; q < k; q++)
                {
                    int flag = 0;
                    MyMatrix minor = new MyMatrix(n - 1, k - 1);
                    for (int i = 0; i < n; i++)
                    {
                        if (i != z)
                        {
                            int flag1 = 0;
                            for (int j = 0; j < k; j++)
                            {
                                if (j != q)
                                {
                                    minor[flag, flag1] = m[i, j];
                                    flag1++;
                                }
                            }
                            flag++;
                        }
                    }
                    result = minor.Determinant();
                    obr[q, z] = Math.Round(Math.Pow(-1, z + q) * result / mxDet, 2);
                }
            }
            return obr;
        }
    }
}
