using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Arch : Function
    {
        Expr A;
        public Arch(Expr a) { A = a; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues)
        {
            double res = A.Compute(variableValues);
            return Math.Log(res - Math.Sqrt((res + 1) * (res - 1)));
        }
        public override IEnumerable<string> Variables => A.Variables;
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override string ToString() => "Arch(" + A + ")";
    }
}
