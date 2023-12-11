using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11d
{
    internal interface ISolvable
    {
        double[] Solve();
        double[] Evaluate(double a);
    }
}
