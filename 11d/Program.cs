using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Solve(new Binomial(a, b));
        }
        static void Solve(Binomial binomial)
        {
            double[] result = binomial.Solve();
            if (result == null)
            {
                Console.WriteLine(binomial + "=0 has infinitely many solutions");
            }
            else if (result.Length == 0)
            {
                Console.WriteLine(binomial + "=0 has no solutions!");
            }
            else
            {
                Console.WriteLine(binomial + "=0 has one solution: " + result[0]);
            }
        }
    }
}