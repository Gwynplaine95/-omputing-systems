using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Integral.Classes
{
    public interface ICalculator
    {
        public double Integrate(double a, double b, int count, Func<double, double> F);
    }
}
