using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public abstract class BinaryOperation : Expr
    {
        protected Expr A, B;
        public BinaryOperation(Expr a, Expr b) { A = a; B = b; }
        public override abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        /*public override abstract IReadOnlyDictionary<string, double> sos;*/
        public override IEnumerable<string> Variables => A.Variables.Concat(B.Variables);
        public override abstract bool IsConstant { get; }
        public override abstract bool IsPolynom { get; }
    }
}
