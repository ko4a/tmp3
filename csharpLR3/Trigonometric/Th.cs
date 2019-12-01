using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Th : Function
    {
        Expr A;
        public Th(Expr a) { A = a; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => Math.Tanh(A.Compute(variableValues));
        public override IEnumerable<string> Variables => A.Variables;
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override string ToString() => "Th(" + A + ")";
    }
}
