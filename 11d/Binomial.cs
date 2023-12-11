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
            : base(new double[] { b, a })
        { }

        public override double[] Evaluate(double a)
        {
            if (coefficients[1] != 0)
                return new double[] { (a - coefficients[0]) / coefficients[1] };
            else if (coefficients[0] != 0)
                return new double[0];
            else return null;
        }
    }
}
