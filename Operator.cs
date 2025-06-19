using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    abstract class Operator
    {
        public abstract int Apply(int a, int b);
    }
}
