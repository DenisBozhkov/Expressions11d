using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal class Binomial : Polynomial
    {
        public Binomial(double a, double b)
            : base(new List<double>() { b, a })
        { }

        public override List<double> Evaluate(double a)
        {
            if (coefficients[1] != 0)
                return new List<double>() { (a - coefficients[0]) / coefficients[1] };
            else if (coefficients[0] != 0)
                return new List<double>();
            else return null;
        }
        public override string ToString()
        {
            return coefficients[1] + "x+" + coefficients[0];
        }
    }
}
