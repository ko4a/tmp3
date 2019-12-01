using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Arsh : Function
    {
        Expr A;
        public Arsh(Expr a) { A = a; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double res = A.Compute(variableValues);
            return Math.Log(res + Math.Sqrt(res * res + 1));
        }
        public override IEnumerable<string> Variables => A.Variables;
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override string ToString() => "Arsh(" + A + ")";
    }
}
