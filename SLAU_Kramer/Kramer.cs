using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAU_Kramer
{
    internal partial class KramerOOP
    {
        private static double[,] a = new double[3, 3];
        private static double[] b = new double[3];
        public static double x, y, z;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public double Z
        {
            get { return z; }
        }

        public KramerOOP(double [,] A, double[] B)
        {
            a = A;
            b = B;
            Calculate();
        }

        private static double Det(double[,] matr)
        {
            return matr[0, 0] * matr[1, 1] * matr[2, 2] + matr[0, 1] * matr[1, 2] * matr[2, 0] + matr[0, 2] * matr[1, 0] * matr[2, 1] - matr[0, 2] * matr[1, 1] * matr[2, 0] - matr[0, 1] * matr[1, 0] * matr[2, 2] - matr[0, 0] * matr[1, 2] * matr[2, 1];
        }

        private static double[,] CopyArr(double[,] matr)
        {
            double[,] arr = new double[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arr[i, j] = matr[i, j];
            return arr;
        }
        private static void Calculate()
        {
            double[,] x1 = CopyArr(a);
            double[,] x2 = CopyArr(a);
            double[,] x3 = CopyArr(a);
            x1[0, 0] = x2[0, 1] = x3[0, 2] = b[0];
            x1[1, 0] = x2[1, 1] = x3[1, 2] = b[1];
            x1[2, 0] = x2[2, 1] = x3[2, 2] = b[2];
            double dA = Det(a);
            double dX1 = Det(x1);
            double dX2 = Det(x2);
            double dX3 = Det(x3);
            x = dX1 / dA;
            y = dX2 / dA;
            z = dX3 / dA;
        }
    }
}
