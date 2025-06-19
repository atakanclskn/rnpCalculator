using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class Add : Operator
    {
        public override int Apply(int a, int b) => a + b;
    }
}
