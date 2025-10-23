using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_R_3_KhasanovaNG_BPI_23_01.Class
{
    public class FunctionCalculator
    {
        public int N { get; set; }
        public int K { get; set; }
        public double A { get; set; }
        public double X { get; set; }
        public double F { get; set; }
        public double Y { get; set; }

        public double CalculateVariant16()
        {
            double sum = 0.0;

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= K; j++)
                {
                    double numerator = Math.Pow(A, i - 1) * Math.Pow(X, i) + Math.Pow(F, j) * Math.Pow(Y, j);
                    double denominator = (i + 1) * j;

                    if (Math.Abs(denominator) < 1e-10)
                        throw new DivideByZeroException($"Деление на ноль при i={i}, j={j}");

                    sum += numerator / denominator;

                }
            }

            return sum;
        }

    }
}

