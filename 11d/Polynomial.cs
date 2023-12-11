using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal abstract class Polynomial : IExpression, ISolvable
    {
        protected double[] coefficients;
        public Polynomial(double[] coefficients)
        {
            this.coefficients = coefficients;
        }
        public int Power
        { get { return coefficients.Length - 1; } }
        public double Calculate(double x)
        {
            double res = coefficients[Power];
            for (int i = Power - 1; i >= 0; i--)
            {
                res = res * x + coefficients[i];
            }
            return res;
        }
        public virtual double[] Solve()
        {
            return Evaluate(0);
        }
        public abstract double[] Evaluate(double a);
    }
}
