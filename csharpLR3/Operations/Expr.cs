using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public abstract class Expr : IExpr
    {
        public abstract double Compute(IReadOnlyDictionary<string, double> variableValues);
        public abstract IEnumerable<string> Variables { get; }
        public abstract bool IsConstant { get; }
        public abstract bool IsPolynom { get; }
        public static Expr operator +(Expr op1, Expr op2) => new Sum(op1, op2);
        public static Expr operator *(Expr op1, Expr op2) => new Mult(op1, op2);
        public static Expr operator /(Expr op1, Expr op2) => new Div(op1, op2);
        public static Expr operator -(Expr op1) => new Min(op1);
    }
}
