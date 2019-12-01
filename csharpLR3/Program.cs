using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    using static Functs;
    class Program
    {
        static void Main()
        {
            var a = new Variable("a");
            var b = new Variable("b");
            var c = new Variable("c");
            var d = new Variable("d");
            var expr = a + b + (-Cos(c * d));
            Console.WriteLine(expr);
            Console.WriteLine(expr.Compute(new Dictionary<string, double> { ["a"] = 5, ["b"] = 2, ["c"] = 10 * Math.PI / 180, ["d"] = 9 }));
            Console.ReadLine();
        }
    }
}
