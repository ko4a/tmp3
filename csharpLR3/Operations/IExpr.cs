﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    interface IExpr
    {
        double Compute(IReadOnlyDictionary<string, double> variableValues);
        IEnumerable<string> Variables { get; }
        bool IsConstant { get; }
        bool IsPolynom { get; }
    }
}
