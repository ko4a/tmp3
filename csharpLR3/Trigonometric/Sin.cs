using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Sin : Function
    {
        Expr A;
        public Sin(Expr a) { A = a; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Sin(A.Compute(variableValues));
        public override IEnumerable<string> Variables => A.Variables;
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override string ToString() => "Sin(" + A + ")";
    }
}
