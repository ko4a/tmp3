using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Pow : Function
    {
        Expr A, B;
        public Pow(Expr a, Expr b) { A = a; B = b; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Pow(A.Compute(variableValues), B.Compute(variableValues));
        public override IEnumerable<string> Variables => A.Variables.Concat(B.Variables);
        public override bool IsConstant => false;
        public override bool IsPolynom => true;
        public override string ToString() => A + "^" + B;
    }
}
