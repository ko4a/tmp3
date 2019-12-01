using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Constant : Expr
    {
        public string Name { get; }
        public Constant(string name) { Name = name; }
        public override double Compute(IReadOnlyDictionary<string, double> variableValues) => variableValues[Name];
        public override IEnumerable<string> Variables => new[] { Name };
        public override bool IsConstant => true;
        public override bool IsPolynom => true;
        public override string ToString() => Name;
    }
}
