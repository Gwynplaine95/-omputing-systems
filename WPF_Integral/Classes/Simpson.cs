using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    public class Simpson : ICalculator
    {
        public double Integrate(double a, double b, int count, Func<double, double> F)
        {
            double h = (b - a) / count;
            double S = 0;
            double S1 = 0;
            double S2 = 0;

            for (int i = 1; i < count / 2 + 1; i++)
                S1 += F(a + (2 * i - 1) * h);
            for (int i = 1; i < count / 2; i++)
                S2 += F(a + 2 * i * h);
            S += 4 * S1 + 2 * S2 + (F(a) + F(b));

            return S * h / 3;
        }
    }
}
