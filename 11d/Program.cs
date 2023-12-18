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
            double c = double.Parse(Console.ReadLine());
            Solve(new Trinomial(a, b, c));
        }
        static void Solve(ISolvable solvable)
        {
            List<double> result = solvable.Solve();
            if (result == null)
            {
                Console.WriteLine(solvable + "=0 has infinitely many solutions");
            }
            else if (result.Count == 0)
            {
                Console.WriteLine(solvable + "=0 has no solutions!");
            }
            else
            {
                Console.Write(solvable + "=0 has " + result.Count + " solutions: ");
                for (int i = 0; i < result.Count; i++)
                    Console.Write(result[i] + " ");
                Console.WriteLine();
            }
        }
    }
}