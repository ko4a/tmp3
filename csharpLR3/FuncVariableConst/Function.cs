using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public abstract class Function : Expr
    {
        public override abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        public override abstract IEnumerable<string> Variables { get; }
        public override abstract bool IsConstant { get; }
        public override abstract bool IsPolynom { get; }
    }
}
