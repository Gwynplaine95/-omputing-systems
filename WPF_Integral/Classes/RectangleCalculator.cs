using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    public class RectangleCalculator : ICalculator
    {
        public double Integrate(double a, double b, int count, Func<double, double> F)
        {
            if (count <= 0) 
                 throw new ArgumentException($"Некорректное количество разбиений {count}"); 
            double h = (b - a) / count;
            double S = 0;

            for (int i = 0; i < count; i++)
                S += F(a + h * i + h / 2);

            return h * S;
        }
    }
}
