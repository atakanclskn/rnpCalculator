using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    class Operand
    {
        public int Value { get; private set; }
        public Operand(int value) { Value = value; }
    }
}
