using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Sum : BinaryOperation
    {
        public Sum(Expr a, Expr b) : base(a, b) { }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) =>
           A.Compute(variableValues) + B.Compute(variableValues);
        public override bool IsConstant => false;
        public override bool IsPolynom => true;
        public override string ToString() => A + " + " + B;
    }
}
