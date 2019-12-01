using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public abstract class UnaryOperation : Expr
    {
        protected Expr A;
        public UnaryOperation(Expr a) { A = a; }
        public override abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        public override IEnumerable<string> Variables => A.Variables;
        public override abstract bool IsConstant { get; }
        public override abstract bool IsPolynom { get; }
    }
}
