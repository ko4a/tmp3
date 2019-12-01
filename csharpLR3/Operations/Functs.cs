using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpLR3
{
    public class Functs
    {
        public static Pow Pow(Expr arg1, Expr arg2) => new Pow(arg1, arg2);
        public static Sin Sin(Expr arg1) => new Sin(arg1);
        public static Cos Cos(Expr arg1) => new Cos(arg1);
        public static Tg Tg(Expr arg1) => new Tg(arg1);
        public static Ctg Ctg(Expr arg1) => new Ctg(arg1);
        public static Arcsin Arcsin(Expr arg1) => new Arcsin(arg1);
        public static Arccos Arccos(Expr arg1) => new Arccos(arg1);
        public static Arctg Arctg(Expr arg1) => new Arctg(arg1);
        public static Arcctg Arcctg(Expr arg1) => new Arcctg(arg1);
        public static Sh Sh(Expr arg1) => new Sh(arg1);
        public static Ch Ch(Expr arg1) => new Ch(arg1);
        public static Th Th(Expr arg1) => new Th(arg1);
        public static Cth Cth(Expr arg1) => new Cth(arg1);
        public static Arsh Arsh(Expr arg1) => new Arsh(arg1);
        public static Arch Arch(Expr arg1) => new Arch(arg1);
        public static Arth Arth(Expr arg1) => new Arth(arg1);
        public static Arcth Arcth(Expr arg1) => new Arcth(arg1);
    }
}
