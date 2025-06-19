using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class Divide : Operator
    {
        public override int Apply(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Sıfıra bölme hatası!");
            return a / b;
        }
    }
}
