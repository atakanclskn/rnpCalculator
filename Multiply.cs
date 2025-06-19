using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rnpCalculator
{
    // Çarpma işlemini temsil eden sınıf
    class Multiply : Operator
    {
        // İki tamsayıyı çarpar ve sonucu döndürür
        public override int Apply(int a, int b) => a * b;
    }
}
